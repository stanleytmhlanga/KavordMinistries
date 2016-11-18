CREATE TABLE [dbo].[Users] (
    [UserID]        INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (MAX) NULL,
    [Surname]       NVARCHAR (MAX) NULL,
    [Id_Number]     NVARCHAR (MAX) NULL,
    [Age]           INT            NOT NULL,
    [Address]       NVARCHAR (MAX) NULL,
    [photo]         NVARCHAR (MAX) NULL,
    [DateOfBirth]   NVARCHAR (MAX) NULL,
    [MeritalStatus] NVARCHAR (MAX) NULL,
    [Gender]        NVARCHAR (MAX) NULL,
    [MemberFrom]    NVARCHAR (MAX) NULL,
    [ContactNo]     NVARCHAR (MAX) NULL,
    [Username]      NVARCHAR (MAX) NULL,
    [Password]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED ([UserID] ASC)
);

