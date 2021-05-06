IF DB_ID('MIT') IS NULL
	BEGIN
		CREATE DATABASE MIT
	END
GO

USE MIT
GO

IF OBJECT_ID('dbo.Team') IS NULL
	BEGIN
		CREATE TABLE [Team](
			[Id] int PRIMARY KEY,
			[TeamName] char(50),
			[Point] int,
			[Status] tinyint default 1
		)
	END
GO

IF OBJECT_ID('dbo.Round') IS NULL
	BEGIN
		CREATE TABLE [Round](
			[Id] int PRIMARY KEY,
			[RoundName] char(50),
			[Quantity] int,
			[Maxpoint] int,
			[Status] tinyint default 1
		)
	END
GO

IF OBJECT_ID('dbo.Question') IS NULL
	BEGIN
		CREATE TABLE [Question](
			[Id] int PRIMARY KEY,
			[RoundId] int REFERENCES [Round]([Id]),
			[ImageUri] nvarchar(max) default null,
			[Point] int,
			[Solution] nvarchar(max),
			[MaxPoint] int,
			[Status] tinyint default 1
		)
	END
GO

IF OBJECT_ID('dbo.Testcase') IS NULL
	BEGIN
		CREATE TABLE [Testcase](
			[Id] int PRIMARY KEY,
			[QuestionId] int REFERENCES [Question]([Id]),
			[Input] nvarchar(max) null,
			[Output] nvarchar(max) null,
			[Point] int,
			[Status] tinyint default 1
		)
	END
GO

IF OBJECT_ID('dbo.Answer') IS NULL
	BEGIN
		CREATE TABLE [Answer](
			[Id] int PRIMARY KEY,
			[Team] int REFERENCES [Team]([Id]),
			[QuestionId] int REFERENCES [Question]([Id]),
			[Answer] nvarchar(max),
			[Time] time,
			[Point] int,
			[Status] tinyint default 0
		)
	END
GO

IF OBJECT_ID('dbo.Shape') IS NULL
	BEGIN
		CREATE TABLE [Shape](
			[Id] int PRIMARY KEY,
			[Question] int REFERENCES [Question]([Id]),
			[Type] int,
			[Text] nvarchar(max),
			[Status] tinyint default 1
		)
	END
GO

IF OBJECT_ID('dbo.AnswerTest') IS NULL
	BEGIN
		CREATE TABLE [AnswerTest](
			[TestCaseId] int REFERENCES [TestCase]([Id]),
			[AnswerId] int REFERENCES [Answer]([Id]),
			[Status] tinyint default 0
			PRIMARY KEY ([TestCaseId], [AnswerId])
		)
	END
GO
