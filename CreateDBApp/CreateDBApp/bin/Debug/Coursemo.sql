--
-- SQL DDL to create Coursemo database
-- 
-- Misbah Hussain mhussa43
-- U. of Illinois, Chicago
-- Project 4
--

CREATE TABLE STUDENT
(
  NetID       NVARCHAR(50) PRIMARY KEY,
  LastName   NVARCHAR(50) NOT NULL,
  FirstName    NVARCHAR(50) NOT NULL  
);
  
CREATE TABLE COURSE
(
  CRN            INT PRIMARY KEY,
  Department     NVARCHAR(50) NOT NULL,
  CourseNumber   SMALLINT NOT NULL,
  Semester       NVARCHAR(50) NOT NULL,
  Year           SMALLINT NOT NULL,  
  Type           NVARCHAR(50) NOT NULL,
  Day            NVARCHAR(50) NOT NULL,
  Time           NVARCHAR(50) NOT NULL,
  ClassSize      SMALLINT NOT NULL
);

CREATE TABLE REGISTRATION
(
  RID		  INT IDENTITY(1,1) PRIMARY KEY,
  NetID 	  NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES STUDENT(NetID),
  CRN   	  INT NOT NULL FOREIGN KEY REFERENCES COURSE(CRN),
  Registered  BIT NOT NULL,
  WaitList    BIT NOT NULL
);

CREATE TABLE WAITLIST
(
  WID	     INT IDENTITY(1,1) PRIMARY KEY,
  NetID 	  NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES STUDENT(NetID),
  CRN   	  INT NOT NULL FOREIGN KEY REFERENCES COURSE(CRN),
);
