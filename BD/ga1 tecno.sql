create database ga1tecno;
go
use ga1tecno;
go 
create table login(
idadministrador int primary key, 
nombre varchar (25), 
apellido varchar (25),  
correo varchar (30),
contraseña varchar (30),
 rol varchar (15)
 );
 insert into login values (1,'ale','monzon','alemonzon.com','chinoxd', 'administrador');
  insert into login values (2,'chino','pache','chinito.com','123', 'cliente ');
  insert into login values (3,'jose','sando','sandoval.com','123', 'secretaria ');

create table datos(
id int primary key,
nombre varchar (30),
apellido varchar(30),
edad int ,
);
insert into datos values(1,'ale','mon',16)


select * from login