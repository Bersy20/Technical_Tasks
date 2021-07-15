create database Students

use Students

create table tbl_student(
StudentId int Identity(1,1),
Name varchar(25),
ContactNo varchar(10),
City varchar(20),
PinCode varchar(6),
constraint pk_SId primary key(StudentId)
);

select * from tbl_student