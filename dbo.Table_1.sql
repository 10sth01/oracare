CREATE TABLE [dbo].[tblapp]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [username] VARCHAR(50) NOT NULL, 
    [age] NCHAR(10) NOT NULL, 
    [phoneNum] NCHAR(10) NOT NULL, 
    [date] NCHAR(10) NOT NULL, 
    [time] NCHAR(10) NOT NULL, 
    [dentist] NCHAR(10) NOT NULL, 
    [serviceCategory] NCHAR(10) NOT NULL, 
    [comments] NCHAR(10) NULL 
)
