
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/23/2019 16:29:48
-- Generated from EDMX file: C:\Users\harry\source\repos\WelcareForYou-Iteration-1\WelcareForYou-Iteration-1\Models\Iteration1Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Iteration1Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AgeGroup] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [NumOfFamily] int  NOT NULL,
    [Suburb] nvarchar(max)  NOT NULL,
    [Salary] int  NOT NULL
);
GO

-- Creating table 'Housings'
CREATE TABLE [dbo].[Housings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Suburb] nvarchar(max)  NOT NULL,
    [NumOfRoom] int  NOT NULL,
    [MediumPrice] int  NOT NULL,
    [HouseType] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Housings'
ALTER TABLE [dbo].[Housings]
ADD CONSTRAINT [PK_Housings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------