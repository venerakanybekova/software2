﻿CREATE TABLE [dbo].[Document_Format] (
    [Id]             [dbo].[IdenticalChild] IDENTITY (1, 1) NOT NULL,
    [Name_ru]        NVARCHAR (MAX)         NULL,
    [Name_kg]        NVARCHAR (MAX)         NULL,
    [Description_ru] NVARCHAR (MAX)         NULL,
    [Description_kg] NVARCHAR (MAX)         NULL,
    [CODE]           NVARCHAR (MAX)         NULL,
    CONSTRAINT [XPKÔîðìàò_Äîêóìåíòà] PRIMARY KEY CLUSTERED ([Id] ASC)
);



