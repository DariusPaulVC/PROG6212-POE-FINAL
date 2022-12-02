# ST10084349-PROG6212-POE-FINAL
This is the Programming 2B POE FINAL for ST10084349 Darius Lynton Paul
## Table of Contents
1. [General Info](#general-info)
2. [Software](#software)
3. [Installation Instructions](#installation-instructions)
4. [Database Instructions](#database-instructions)
5. [Additional Artefacts](#additional-artefacts)
6. [Developer Info](#developer-info)
7. [Troubleshooting](#troubleshooting)
7. [FAQs](#faqs)
8. [Code Attributions](#code-attributions) 
***
### General Info
I am tasked to create a program that will help organize a user's time management in their classes. The program will take values such as the name of the modules, hours spent studying the modules, etc and use those values to do specific calculations to help the user manange their time for studying. This program will make use of a database which will store a user's information and display it back to them in a tabular format. The program is going to be made into a website to make it easily accessible. This program is created by Darius Lynton Paul.
#### Screenshot of the Program
![Screenshot (167)](https://user-images.githubusercontent.com/106805800/205328554-5c0bb3fd-78f9-4fad-9d30-bcd26eb7227e.png)
***
### Software
* [Microsoft Visual Studio 2022] (Version no: 17.2)
* [Git] (Version no: 2.36.1)
* [Net Frameworks] (Net Framework 4.7.2)
* [Microsoft SQL Server Mangement Studio] (Version no: 18.11.1)

**Plugins used**
* EntityFramework
* Visual Studio IntelliCode
* Visual Studio Rich Navigation
* Microsoft Identity
***
### Installation Instructions
A. **Download Links**
* Microsoft Visual Studio 2022 - https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false
* Microsoft SQL Server Mangement Studio - https://aka.ms/ssmsfullsetup

B. **To run the program WITH Microsoft Visual Studio installed, follow these steps:**
* _Download Microsoft Visual Studio Using the above link._
* _Download the file named "FinaleTwo" onto your desktop._
* _Double click on the folder titled "FinaleTwo"._
* _Double click on the Visual Studio Solution file named "FinaleTwo.sln"._
* _After the program has finished loading, press on the green play symbol with the words "Start" written next to it, or press the "F5" key on your keyboard._
_Please note: Download all the files from the POE_FINAL folder to make sure the program executes with no errors_
***
### Database Instuctions
* _The program allows for information to be added in a database but it also allows users to edit or even delete information._
* _Certain fields require a certain data type to be entered. Entering the incorrect data type will result in errors occurring._
***
### Additional Artefacts
_To execute the following statements, paste it in Microsoft SQL Server Mangement Studio_
***
A. **Create database**
* _Open Microsoft SQL Server Mangement Studio._
* _Right click on the word "Databases" and select "New Database..."._
* _Name the database "FinaleTwo" and press the OK button._

B. **Create Table SQL statements**
CREATE TABLE [dbo].[__EFMigrationsHistory] (
    [MigrationId]    NVARCHAR (150) NOT NULL,
    [ProductVersion] NVARCHAR (32)  NOT NULL,
    CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED ([MigrationId] ASC)
);

CREATE TABLE [dbo].[AspNetRoleClaims] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [RoleId]     NVARCHAR (450) NOT NULL,
    [ClaimType]  NVARCHAR (MAX) NULL,
    [ClaimValue] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[AspNetRoles] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId]
    ON [dbo].[AspNetRoleClaims]([RoleId] ASC);

CREATE TABLE [dbo].[AspNetRoles] (
    [Id]               NVARCHAR (450) NOT NULL,
    [Name]             NVARCHAR (256) NULL,
    [NormalizedName]   NVARCHAR (256) NULL,
    [ConcurrencyStamp] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex]
    ON [dbo].[AspNetRoles]([NormalizedName] ASC) WHERE ([NormalizedName] IS NOT NULL);

CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [UserId]     NVARCHAR (450) NOT NULL,
    [ClaimType]  NVARCHAR (MAX) NULL,
    [ClaimValue] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId]
    ON [dbo].[AspNetUserClaims]([UserId] ASC);

CREATE TABLE [dbo].[AspNetUserLogins] (
    [LoginProvider]       NVARCHAR (128) NOT NULL,
    [ProviderKey]         NVARCHAR (128) NOT NULL,
    [ProviderDisplayName] NVARCHAR (MAX) NULL,
    [UserId]              NVARCHAR (450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED ([LoginProvider] ASC, [ProviderKey] ASC),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId]
    ON [dbo].[AspNetUserLogins]([UserId] ASC);

CREATE TABLE [dbo].[AspNetUserRoles] (
    [UserId] NVARCHAR (450) NOT NULL,
    [RoleId] NVARCHAR (450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED ([UserId] ASC, [RoleId] ASC),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId]
    ON [dbo].[AspNetUserRoles]([RoleId] ASC);

CREATE TABLE [dbo].[AspNetUsers] (
    [Id]                   NVARCHAR (450)     NOT NULL,
    [UserName]             NVARCHAR (256)     NULL,
    [NormalizedUserName]   NVARCHAR (256)     NULL,
    [Email]                NVARCHAR (256)     NULL,
    [NormalizedEmail]      NVARCHAR (256)     NULL,
    [EmailConfirmed]       BIT                NOT NULL,
    [PasswordHash]         NVARCHAR (MAX)     NULL,
    [SecurityStamp]        NVARCHAR (MAX)     NULL,
    [ConcurrencyStamp]     NVARCHAR (MAX)     NULL,
    [PhoneNumber]          NVARCHAR (MAX)     NULL,
    [PhoneNumberConfirmed] BIT                NOT NULL,
    [TwoFactorEnabled]     BIT                NOT NULL,
    [LockoutEnd]           DATETIMEOFFSET (7) NULL,
    [LockoutEnabled]       BIT                NOT NULL,
    [AccessFailedCount]    INT                NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [EmailIndex]
    ON [dbo].[AspNetUsers]([NormalizedEmail] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex]
    ON [dbo].[AspNetUsers]([NormalizedUserName] ASC) WHERE ([NormalizedUserName] IS NOT NULL);

CREATE TABLE [dbo].[AspNetUserTokens] (
    [UserId]        NVARCHAR (450) NOT NULL,
    [LoginProvider] NVARCHAR (128) NOT NULL,
    [Name]          NVARCHAR (128) NOT NULL,
    [Value]         NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED ([UserId] ASC, [LoginProvider] ASC, [Name] ASC),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[modules] (
    [ModuleID]       INT            IDENTITY (1, 1) NOT NULL,
    [ModuleCode]     VARCHAR (10)   NOT NULL,
    [ModuleName]     VARCHAR (50)   NOT NULL,
    [Credits]        INT            NOT NULL,
    [ClassHours]     INT            NOT NULL,
    [StudyDate]      DATETIME       NOT NULL,
    [SelfStudyHours] INT            NOT NULL,
    [UserID]         NVARCHAR (450) NULL,
    [SemesterID]     INT            NULL,
    PRIMARY KEY CLUSTERED ([ModuleID] ASC),
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[AspNetUsers] ([Id]),
    FOREIGN KEY ([SemesterID]) REFERENCES [dbo].[semester] ([SemesterID])
);

CREATE TABLE [dbo].[semester] (
    [SemesterID]        INT            IDENTITY (1, 1) NOT NULL,
    [SemesterName]      VARCHAR (25)   NOT NULL,
    [SemesterWeeks]     INT            NOT NULL,
    [SemesterStartDate] DATETIME       NOT NULL,
    [UserID]            NVARCHAR (450) NULL,
    PRIMARY KEY CLUSTERED ([SemesterID] ASC),
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[AspNetUsers] ([Id])
);
***
### Developer Info
* Name: Darius Lynton Paul
* Student No: ST10084349
* Email: ST10084349@vcconnect.edu.za
* Link to GIT Repository: https://github.com/DariusPaulVC/PROG6212-POE-FINAL.git 
***
### Troubleshooting
1. **My modules aren't saving.**
_Please copy and paste the above mentioned SQL Scripts. This will solve all problems that deal with saving, editing, deleting and viewing._
***
### FAQs
1. **How do I switch between pages?**
_There are 4 buttons at the top left hand side of the website that allows you to switch between all pages of the website, however you will be unable to do this if you are not signed in. You will be redirected to the login page_
2. **Why aren't my Self-Study Hours and Remaining Self Study Hours being displayed?**
_As the website is still in early development there are numerous functions that I am trying to perfect, in the next update these issues will be solved._
***
### Code Attributions
1. https://www.youtube.com/watch?v=JvN8yAp8epk&t=1786s - used to understand how to transfer my database to my program
2. https://www.youtube.com/watch?v=4nXB_GfYIko&t=214s - used to understand how to edit the Login/Register pages
3. https://www.youtube.com/watch?v=T-e554Zt3n4&t=495s - used to understand how to create a basic version of this program
