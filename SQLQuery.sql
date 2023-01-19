CREATE DATABASE businessdb
 
CREATE TABLE Code
(
    id INT PRIMARY KEY NOT NULL, 
    code NVARCHAR (20) NOT NULL
)

CREATE TABLE Processes
(
  id INT PRIMARY KEY NOT NULL,
  nameProcess NVARCHAR(20),
  codeId int,
  divisionsId int
)
CREATE TABLE Divisions 
(
id INT PRIMARY KEY NOT NULL,
division NVARCHAR(20) NOT NULL,
)

select Divisions.division, Processes.nameProcess from Divisions
join Processes on Divisions.id = Processes.divisionsId

select Divisions.division, Code.code, Processes.nameProcess from Divisions
join Processes on Divisions.id = Processes.divisionsId
join Code on Processes.codeId = Code.id
where Code.code