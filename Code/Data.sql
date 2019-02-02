--Data.sql
-- SQL to populate all tables with data

-- Note - The data all came from IMDB (Internet Movie Database)
-- The datasets can be found here: https://datasets.imdbws.com/

-- We used the following tables: name.basics, title.crew, title.basics
-- 		These were imported into temporary tables in our database
-- 		called IMDBMovies, dbo.CrewImdb, [WIN2\bmfisher].NamesImdb

-- This made it easier to clean and work with the data before populating
-- 		our final table structure


USE cis560_team10;

----------------------------------------------------------------------------------------
--Populate Role Script
----------------------------------------------------------------------------------------

INSERT MovieDB.[Role] ([Name])
VALUES
	('Director'),
	('Writer'),
	('Actor');
	
	
----------------------------------------------------------------------------------------
--Populate Genre Script
----------------------------------------------------------------------------------------

INSERT MovieDB.Genre([Name])
SELECT DISTINCT VALUE AS Genre
FROM 
(
	SELECT DISTINCT MV.genres AS MVG 
	FROM IMDBMovies AS MV 
	WHERE MV.genres != '\N'
) AS DG CROSS APPLY STRING_SPLIT(DG.MVG, ',')
ORDER BY Genre ASC;


----------------------------------------------------------------------------------------
--Populate Movie Script
----------------------------------------------------------------------------------------

--If reloading data from IMDB, this query finds all movies that will violate the Unique
--Key constraint...delete the duplicates
SELECT *
FROM IMDBMovies MV
	INNER JOIN IMDBMovies SM ON MV.primaryTitle = SM.primaryTitle 
	AND MV.startYear = SM.startYear
	AND MV.id != SM.id;

DELETE IMDBMovies
WHERE id IN ('tt0005061','tt0009008','tt0004214', 'tt0003139', 'tt0002405', 'tt0007271', 'tt0003507');

--Insert the rest of the values
INSERT MovieDB.Movie(MovieID, Title, Runtime, YearReleased)
SELECT id, primaryTitle, runtimeMinutes, startYear
FROM IMDBMovies;


----------------------------------------------------------------------------------------
--Populate MovieGenre Script
----------------------------------------------------------------------------------------

INSERT MovieDB.MovieGenre(MovieID, GenreID)
SELECT IDGen.id, G.GenreID
FROM
(
	SELECT GMV.ID, VALUE AS Genre
	FROM 
	(
		SELECT * FROM IMDBMovies IMV WHERE IMV.genres != '\N'
	) AS GMV
		CROSS APPLY STRING_SPLIT(GMV.genres, ',')
) AS IDGen
	INNER JOIN MovieDB.Genre G ON IDGen.Genre = G.[Name];
	
	
----------------------------------------------------------------------------------------
--Populate Person Script
----------------------------------------------------------------------------------------

--THIS FILE IS USED TO CREATE A NEW TABLE FOR THE [WIN2\bmfisher].NamesImdb
--THIS SCRIPT REMOVES DUPLICATES AND PEOPLE WITH ONLY ONE NAME IN THE SYSTEM

DROP TABLE IF EXISTS MovieDB.NamesOfPeople;
CREATE TABLE MovieDB.NamesOfPeople
(
	PersonID NVARCHAR(32) NOT NULL PRIMARY KEY,
	FirstName NVARCHAR(32) NOT NULL,
	LastName NVARCHAR(32) NULL,
	BirthYear NVARCHAR(8) NOT NULL,
	DeathYear NVARCHAR(8) NULL,
	PrimaryProfession NVARCHAR(128) NULL,
	KnownForTitles NVARCHAR(128) NOT NULL,
);

GO
INSERT MovieDB.NamesOfPeople(PersonID, FirstName, LastName, BirthYear, DeathYear, PrimaryProfession, KnownForTitles)
SELECT N.nconst,
CASE
         WHEN N.primaryName LIKE '% %' THEN LEFT(N.primaryName, Charindex(' ', N.primaryName) - 1)
         ELSE N.primaryName
       END,
CASE
         WHEN N.primaryName LIKE '% %' THEN RIGHT(N.primaryName, Charindex(' ', Reverse(N.primaryName)) - 1)
       END,
N.birthYear,
CASE
	WHEN N.deathYear LIKE '\N' THEN NULL
	ELSE N.deathYear
	END,
N.primaryProfession, N.knownForTitles
FROM [WIN2\bmfisher].NamesImdb N;

GO
DELETE MovieDB.NamesOfPeople
WHERE FirstName IS NULL OR LastName IS NULL;

GO
DELETE N
FROM MovieDB.NamesOfPeople N
	INNER JOIN MovieDB.NamesOfPeople N2 ON N.FirstName = N2.FirstName
		AND N.LastName = N2.LastName
		AND N.PersonID != N2.PersonID;

GO
SELECT *
FROM MovieDB.NamesOfPeople N
	INNER JOIN MovieDB.NamesOfPeople N2 ON N.FirstName = N2.FirstName
		AND N.LastName = N2.LastName
		AND N.PersonID != N2.PersonID

--THIS IS THE SCRIPT THAT ACTUALLY POPULATES THE MovieDB.Person TABLE
INSERT MovieDB.Person(PersonID, FirstName, LastName)
SELECT N.PersonID, N.FirstName, N.LastName
FROM MovieDB.NamesOfPeople N


----------------------------------------------------------------------------------------
--Populate MoviePerson Script
----------------------------------------------------------------------------------------
TRUNCATE TABLE MovieDB.MoviePerson;

--Insert Directors
INSERT MovieDB.MoviePerson(MovieID, PersonID, RoleID)
SELECT 
	M.MovieID, 
	P.PersonID,
	(SELECT R.RoleID FROM MovieDB.[Role] AS R WHERE R.[Name] = 'Director')
FROM
(
	SELECT C.tconst AS MovieID, VALUE AS Director
	FROM [dbo.CrewImdb] AS C
		CROSS APPLY STRING_SPLIT(C.directors, ',')
	WHERE C.directors != '\N'
) AS CD INNER JOIN MovieDB.Movie AS M ON CD.MovieID = M.MovieID
	INNER JOIN MovieDB.Person AS P ON CD.Director = P.PersonID;

--Insert Writers
INSERT MovieDB.MoviePerson(MovieID, PersonID, RoleID)
SELECT 
	M.MovieID, 
	P.PersonID,
	(SELECT R.RoleID FROM MovieDB.[Role] AS R WHERE R.[Name] = 'Writer')
FROM
(
	SELECT C.tconst AS MovieID, VALUE AS Writer
	FROM [dbo.CrewImdb] AS C
		CROSS APPLY STRING_SPLIT(C.writers, ',')
	WHERE C.writers != '\N'
) AS CW INNER JOIN MovieDB.Movie AS M ON CW.MovieID = M.MovieID
	INNER JOIN MovieDB.Person AS P ON CW.Writer = P.PersonID;


--Insert Actors:
INSERT MovieDB.MoviePerson(MovieID, PersonID, RoleID)
SELECT 
	M.MovieID,
	P.PersonID,
	(SELECT R.RoleID FROM MovieDB.[Role] AS R WHERE R.[Name] = 'Actor')
FROM
(
	SELECT NP.PersonID, NP.PrimaryProfession, VALUE AS MovieID
	FROM MovieDB.NamesOfPeople AS NP
		CROSS APPLY STRING_SPLIT(NP.KnownForTitles, ',')
	WHERE NP.PrimaryProfession LIKE '%actor%' OR NP.PrimaryProfession LIKE '%actress%'
) AS Actors 
	INNER JOIN MovieDB.Movie M ON Actors.MovieID = M.MovieID
	INNER JOIN MovieDB.Person P ON Actors.PersonID = P.PersonID;