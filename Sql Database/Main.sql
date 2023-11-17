USE [master];

ALTER DATABASE Kørselslog SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE IF EXISTS Kørselslog;
CREATE Database Kørselslog;

GO

USE [Kørselslog];

CREATE TABLE Users (
	UserID int primary key,
	Username varchar(25),
	UserPassword varchar(25)
);

INSERT INTO Users (UserID, Username, UserPassword) VALUES (1, 'Asbjørn', 'Asbjørn123');
INSERT INTO Users (UserID, Username, UserPassword) VALUES (2, 'Ahmed', 'Ahmed123');
INSERT INTO Users (UserID, Username, UserPassword) VALUES (3, 'Lucas', 'Lucas123');


CREATE TABLE Admins (
	AdminID int,
	AdminUsername varchar(25),
	AdminPassword varchar(25)
);

INSERT INTO Admins (AdminID, AdminUsername, AdminPassword) VALUES (0, 'Admin', 'Admin123');


CREATE TABLE Logs (
	LogID int,
	UserID int,
	WhereFrom varchar(25),
	WhereTo varchar(25)
);

INSERT INTO Logs (LogID, UserID, WhereFrom, WhereTo) VALUES (0, 0, 'Hvidovre', 'Hvidovre');

INSERT INTO Logs (LogID, UserID, WhereFrom, WhereTo) VALUES (1, 1, 'Hvidovre', 'Vejen');
INSERT INTO Logs (LogID, UserID, WhereFrom, WhereTo) VALUES (2, 1, 'Rødovre', 'Vejle');
INSERT INTO Logs (LogID, UserID, WhereFrom, WhereTo) VALUES (3, 1, 'Ballerup', 'Greve');

INSERT INTO Logs (LogID, UserID, WhereFrom, WhereTo) VALUES (4, 2, 'Vallensbæk', 'Greve');
INSERT INTO Logs (LogID, UserID, WhereFrom, WhereTo) VALUES (5, 2, 'Vejle', 'Brøndby');

INSERT INTO Logs (LogID, UserID, WhereFrom, WhereTo) VALUES (6, 3, 'Vejle', 'Hillerød');
INSERT INTO Logs (LogID, UserID, WhereFrom, WhereTo) VALUES (7, 3, 'Ishøj', 'Greve');
INSERT INTO Logs (LogID, UserID, WhereFrom, WhereTo) VALUES (8, 3, 'Kokkedal', 'Greve');
INSERT INTO Logs (LogID, UserID, WhereFrom, WhereTo) VALUES (9, 3, 'Allerød', 'Karlslunde');
