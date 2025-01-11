
USE [EmployeePortal]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE Organization (
    Id UniqueIdentifier PRIMARY KEY,  
    OrgName NVARCHAR(255) NOT NULL,   
    OrgEmail NVARCHAR(255) NOT NULL,  
    OrgAddress NVARCHAR(500) NULL,    
    CreatedOn DATETIME NOT NULL DEFAULT GETUTCDATE(), 
    CreatedBy NVARCHAR(255) NOT NULL, 
    UpdatedOn DATETIME NULL,          
    UpdatedBy NVARCHAR(255) NULL,     
    DeletedDate DATETIME NULL        
);




