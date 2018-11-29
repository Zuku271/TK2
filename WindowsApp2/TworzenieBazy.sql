CREATE TABLE [dbo].[Brands]
(
	[Brand_ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [BrandName] NCHAR(20) NULL
);

CREATE TABLE [dbo].[Models] (
    [Model_ID]  INT        NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [ModelName] NCHAR (20) NOT NULL,
    [Brand_ID]  INT        NOT NULL
);

CREATE TABLE [dbo].[Equipment] (
    [Eq_ID]       INT     NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [CarEq]    NCHAR (26) NOT NULL,
    [Brand_ID] INT        NOT NULL,
    [Model_ID] INT        NOT NULL,
);

CREATE TABLE [dbo].[Engines]
(
	[Engine_ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [EngineType] NCHAR(20) NOT NULL, 
    [Brand_ID] INT NOT NULL, 
    [Model_ID] INT NOT NULL
);

CREATE TABLE [dbo].[Colors]
(
	[Color_ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [ColorType] NCHAR(26) NOT NULL, 
    [Color] NCHAR(30) NOT NULL, 
    [Brand_ID] INT NOT NULL, 
    [Model_ID] INT NOT NULL
);