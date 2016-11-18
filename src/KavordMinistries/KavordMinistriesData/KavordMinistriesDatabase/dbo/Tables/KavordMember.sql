CREATE TABLE [dbo].[KavordMember] (
    [KavordMember_Id] INT            IDENTITY (1, 1) NOT NULL,
    [Name]           NVARCHAR (MAX) NULL,
    [Surname]        NVARCHAR (MAX) NULL,
    [Id_Number]      NVARCHAR (MAX) NULL,
    [Age]            INT            NOT NULL,
    [Address]        NVARCHAR (MAX) NULL,
    [photo]          NVARCHAR (MAX) NULL,
    [DateOfBirth]    NVARCHAR (MAX) NULL,
    [MeritalStatus]  NVARCHAR (MAX) NULL,
    [Gender]         NVARCHAR (MAX) NULL,
    [MemberFrom]     NVARCHAR (MAX) NULL,
    [ContactNo]      NVARCHAR (MAX) NULL,
    [MemberRole]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.KavordMember] PRIMARY KEY CLUSTERED ([KavordMember_Id] ASC)
);

