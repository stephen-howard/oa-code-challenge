USE [master]
GO
/****** Object:  Database [TestObjectArt]    Script Date: 01/28/2016 02:33:23 ******/
CREATE DATABASE [TestObjectArt] ON  PRIMARY 
( NAME = N'TestObjectArt', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\TestObjectArt.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TestObjectArt_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\TestObjectArt_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TestObjectArt] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TestObjectArt].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TestObjectArt] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [TestObjectArt] SET ANSI_NULLS OFF
GO
ALTER DATABASE [TestObjectArt] SET ANSI_PADDING OFF
GO
ALTER DATABASE [TestObjectArt] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [TestObjectArt] SET ARITHABORT OFF
GO
ALTER DATABASE [TestObjectArt] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [TestObjectArt] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [TestObjectArt] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [TestObjectArt] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [TestObjectArt] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [TestObjectArt] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [TestObjectArt] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [TestObjectArt] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [TestObjectArt] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [TestObjectArt] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [TestObjectArt] SET  DISABLE_BROKER
GO
ALTER DATABASE [TestObjectArt] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [TestObjectArt] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [TestObjectArt] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [TestObjectArt] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [TestObjectArt] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [TestObjectArt] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [TestObjectArt] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [TestObjectArt] SET  READ_WRITE
GO
ALTER DATABASE [TestObjectArt] SET RECOVERY FULL
GO
ALTER DATABASE [TestObjectArt] SET  MULTI_USER
GO
ALTER DATABASE [TestObjectArt] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [TestObjectArt] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'TestObjectArt', N'ON'
GO
USE [TestObjectArt]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 01/28/2016 02:33:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[LastName] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[Address] [varchar](250) NULL,
	[PostalCode] [int] NULL,
	[IDNumber] [varchar](13) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[LastName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Customers] UNIQUE NONCLUSTERED 
(
	[IDNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Customers] ([LastName], [FirstName], [Address], [PostalCode], [IDNumber]) VALUES (N'Allen', N'Maria', N'33-88-55  JNB', 9555, N'623456578')
INSERT [dbo].[Customers] ([LastName], [FirstName], [Address], [PostalCode], [IDNumber]) VALUES (N'Bell', N'Michael', N'11-22-33  CPT', 9111, N'523400100')
INSERT [dbo].[Customers] ([LastName], [FirstName], [Address], [PostalCode], [IDNumber]) VALUES (N'Coleman', N'David', N'88-66-99 PLZ', 9632, N'916254122')
INSERT [dbo].[Customers] ([LastName], [FirstName], [Address], [PostalCode], [IDNumber]) VALUES (N'Cook', N'James', N'33-88-44  CPT', 9632, N'423698522')
INSERT [dbo].[Customers] ([LastName], [FirstName], [Address], [PostalCode], [IDNumber]) VALUES (N'Gibson', N'Andrew', N'33-88-11  JNB', 9856, N'909251422')
INSERT [dbo].[Customers] ([LastName], [FirstName], [Address], [PostalCode], [IDNumber]) VALUES (N'Lee', N'Alexander', N'1-2-2-2  PLZ', 9100, N'823453321')
INSERT [dbo].[Customers] ([LastName], [FirstName], [Address], [PostalCode], [IDNumber]) VALUES (N'Miller', N'Ethan', N'22-33-44   JNB', 9110, N'823400000')
INSERT [dbo].[Customers] ([LastName], [FirstName], [Address], [PostalCode], [IDNumber]) VALUES (N'Parker', N'Robert', N'66-99-33  CPT', 9211, N'623414112')
INSERT [dbo].[Customers] ([LastName], [FirstName], [Address], [PostalCode], [IDNumber]) VALUES (N'Smith        ', N'Brown', N'11-22-22   JNB', 9110, N'923456780')
INSERT [dbo].[Customers] ([LastName], [FirstName], [Address], [PostalCode], [IDNumber]) VALUES (N'Thomas', N'William', N'22-44-99  PLZ', 9111, N'923402350')
INSERT [dbo].[Customers] ([LastName], [FirstName], [Address], [PostalCode], [IDNumber]) VALUES (N'Wilson', N'Liam', N'33-44-88   JNB', 9119, N'623456221')
INSERT [dbo].[Customers] ([LastName], [FirstName], [Address], [PostalCode], [IDNumber]) VALUES (N'Wood', N'Patrick', N'22-88-66  CPT', 9514, N'862514222')
