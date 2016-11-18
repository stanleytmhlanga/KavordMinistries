CREATE TABLE [dbo].[UserProfile] (
    [UserId]   INT           IDENTITY (1, 1) NOT NULL,
    [Username] NVARCHAR (56) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC),
    UNIQUE NONCLUSTERED ([Username] ASC)
);

