﻿CREATE TABLE [dbo].[Sugestoes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [titulo] VARCHAR(50) NULL, 
    [descricao] TEXT NULL, 
    [data_criacao] DATE DEFAULT GETDATE(), 
    [Usuario_email] NVARCHAR(50) NULL
)
