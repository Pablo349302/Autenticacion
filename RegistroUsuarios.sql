create database Registro
go

USE Registro

create table ROL(
IdRol int primary key,
Descripcion varchar(50)
)

go 

insert into ROL(IdRol,Descripcion) values(1,'Administrador')

insert into ROL(IdRol,Descripcion) values(2,'Empleado')

select * from ROL

go 

create table REGISTROUSUARIOS(
Nombre varchar(50),
Apellido varchar(50),
Edad varchar(2),
Correo varchar(50)primary key,
Clave varchar(50),
IdRol int references ROL(IdRol)
)

insert into REGISTROUSUARIOS (Nombre,Apellido,Edad,Correo,Clave,IdRol) values('Pablo','Sánchez','23','pablito_29xavi@hotmail.com','123456',1)


insert into REGISTROUSUARIOS (Nombre,Apellido,Edad,Correo,Clave,IdRol) values('Xavier','Caizaluisa','20','pxsc@hotmail.com','654321',2)


Select *
from REGISTROUSUARIOS


create table USUARIOS(
Nombres varchar(50),
Correo varchar(50) primary key,
Clave varchar(50),
IdRol int references ROL(IdRol)
)


insert into USUARIOS (Nombres,Correo,Clave,IdRol) values('Pablo Sánchez','pablito_29xavi@hotmail.com','123456',1)


insert into USUARIOS (Nombres,Correo,Clave,IdRol) values('Pablo Xavier','pxsc@hotmail.com','654321',2)

Select *
from USUARIOS
