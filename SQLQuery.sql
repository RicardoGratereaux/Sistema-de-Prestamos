create database LoginPrestamos

create table USUARIO
(
IdUsuario int primary key identity,
NombreUsuario varchar(50),
Correo varchar(50),
Clave varchar(100)
)

select *from USUARIO