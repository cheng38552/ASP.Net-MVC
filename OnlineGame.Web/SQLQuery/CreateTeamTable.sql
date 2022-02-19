--1.Drop Table if it exists
IF( EXISTS ( SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Team'))
	BEGIN
		TRUNCATE TABLE Team;
		DROP TABLE Team;
	END;
GO -- Run the previous command and begins new batch

--2. Create Table
CREATE TABLE Team
	(
 	   Id INT PRIMARY KEY
	 	      IDENTITY(1,1)
	 	      NOT NULL,
	   [Name] NVARCHAR(100) NULL
	);
GO -- Run the previous command and begins new batch

--3. Insert Data
INSERT Team
VALUES (N'Team1');
INSERT Team
VALUES (N'Team2');
INSERT Team
VALUES (N'Team3');
GO -- Run the previous command and begins new batch