create database DdlAjax

use DdlAjax

create table tbl_Country(
Id int primary key identity(1,1), 
Country varchar(30)
);

create table tbl_State(
Id int primary key identity(100,1),
State varchar(30),
CId int 
);

create table tbl_District(
Id int primary key identity(1000,1),
District varchar(30),
SId int,
CId int
);

select * from tbl_Country
select * from tbl_State
select * from tbl_District
 
