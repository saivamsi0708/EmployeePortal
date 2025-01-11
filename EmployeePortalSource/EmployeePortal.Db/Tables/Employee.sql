USE [EmployeePortal]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE Employee (
    Id UniqueIdentifier PRIMARY KEY,       
    EmpName NVARCHAR(255) NOT NULL,            
    EmpCode NVARCHAR(50) NOT NULL UNIQUE,   
    Designation NVARCHAR(100) NOT NULL,     
    DateOfJoined DATETIME NOT NULL,             
    DateOfExit DATETIME NULL,                   
    OrganizationId UniqueIdentifier NOT NULL,            
    CreatedOn DATETIME NOT NULL , 
    CreatedBy NVARCHAR(255) NOT NULL,       
    UpdatedOn DATETIME NULL,                
    UpdatedBy NVARCHAR(255) NULL,           
    DeletedDate DATETIME NULL,              

    CONSTRAINT FK_Employee_Organization FOREIGN KEY (OrganizationId) 
    REFERENCES Organization(Id) ON DELETE CASCADE
);
