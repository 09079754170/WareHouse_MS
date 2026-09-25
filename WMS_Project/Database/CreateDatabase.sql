-- Warehouse Management System - SQL Server database
-- The app creates all of this automatically on first run.
-- You only need this script if you want to create the database yourself
-- (e.g. in SQL Server Management Studio). Default login: admin / admin123 is added by the app.

IF DB_ID(N'WarehouseDB') IS NULL CREATE DATABASE [WarehouseDB];
GO
USE [WarehouseDB];
GO

IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
CREATE TABLE dbo.Users (
    UserId       INT IDENTITY(1,1) PRIMARY KEY,
    Username     NVARCHAR(50)  NOT NULL UNIQUE,
    PasswordHash NVARCHAR(128) NOT NULL,
    Salt         NVARCHAR(64)  NOT NULL,
    FullName     NVARCHAR(100) NOT NULL,
    Role         NVARCHAR(30)  NOT NULL,
    CreatedAt    DATETIME2     NOT NULL DEFAULT SYSDATETIME()
);

IF OBJECT_ID(N'dbo.LoginHistory', N'U') IS NULL
CREATE TABLE dbo.LoginHistory (
    LoginHistoryId INT IDENTITY(1,1) PRIMARY KEY,
    UserId         INT          NOT NULL REFERENCES dbo.Users(UserId),
    Action         NVARCHAR(10) NOT NULL,          -- 'Login' or 'Logout'
    ActionAt       DATETIME2    NOT NULL DEFAULT SYSDATETIME()
);

IF OBJECT_ID(N'dbo.Warehouses', N'U') IS NULL
CREATE TABLE dbo.Warehouses (
    WarehouseId INT IDENTITY(1,1) PRIMARY KEY,
    Code        NVARCHAR(20)  NOT NULL UNIQUE,
    Name        NVARCHAR(100) NOT NULL,
    Address     NVARCHAR(200) NULL,
    CreatedAt   DATETIME2     NOT NULL DEFAULT SYSDATETIME()
);

IF OBJECT_ID(N'dbo.Items', N'U') IS NULL
CREATE TABLE dbo.Items (
    ItemId       INT IDENTITY(1,1) PRIMARY KEY,
    Sku          NVARCHAR(30)  NOT NULL,
    Name         NVARCHAR(100) NOT NULL,
    Unit         NVARCHAR(20)  NOT NULL DEFAULT N'pcs',
    WarehouseId  INT           NOT NULL REFERENCES dbo.Warehouses(WarehouseId),
    Quantity     INT           NOT NULL DEFAULT 0 CHECK (Quantity >= 0),
    ReorderLevel INT           NOT NULL DEFAULT 0 CHECK (ReorderLevel >= 0),
    CreatedAt    DATETIME2     NOT NULL DEFAULT SYSDATETIME(),
    UpdatedAt    DATETIME2     NULL,
    CONSTRAINT UQ_Items_Sku_Warehouse UNIQUE (Sku, WarehouseId)
);
GO
