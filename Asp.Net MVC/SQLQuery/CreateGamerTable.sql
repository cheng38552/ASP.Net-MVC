--1. Drop Table if it exists
IF( EXISTS ( SELECT * From INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Gamer') )
	BEGIN
	TRUNCATE TABLE Gamer;
	DROP TABLE Gamer;
	END;
GO --Run the previous command and begins new batch
--2. Create Table
CREATE TABLE Gamer
    (
      Id INT PRIMARY KEY
             IDENTITY(1, 1)
             NOT NULL ,
      [Name] NVARCHAR(100) NULL ,
      Gender NVARCHAR(10) NULL ,
      City NVARCHAR(50) NULL,
         DateOfBirth DATETIME NULL,
         TeamId INT FOREIGN KEY REFERENCES Team(Id)
    );
GO --Run the previous command and begins new batch
--3. Insert Data
INSERT  Gamer
VALUES  ( N'Name01 ABB', N'Male', N'City01', '1979/4/28', 1);
INSERT  Gamer
VALUES  ( N'Name02 CDDE', N'Female', N'City03', '1981/7/24', 2);
INSERT  Gamer
VALUES  ( N'Name03 FIJK', N'Female', N'City01', '1984/12/5', 3);
INSERT  Gamer
VALUES  ( N'Name04 LMOPPQ', N'Male', N'City02', '1983/5/29', 1);
INSERT  Gamer
VALUES  ( N'Name05 QRSTT', N'Male', N'City01', '1979/6/20', 3);
INSERT  Gamer
VALUES  ( N'Name06 TUVVX', N'Female', N'City03', '1984/5/15', 3);
INSERT  Gamer
VALUES  ( N'Name07 XYZZXX', N'Female', N'City01', '1986/4/29', 2);
INSERT  Gamer
VALUES  ( N'Name08 ABBCDE', N'Male', N'City02', '1985/7/28', 1);
INSERT  Gamer
VALUES  ( N'Name09 QRSTTUVXX', N'Male', N'City02', '1983/4/16', 1);