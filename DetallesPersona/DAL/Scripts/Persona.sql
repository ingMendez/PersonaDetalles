CREATE DATABASE PersonasDb

GO

USE PersonasDb

GO

CREATE TABLE Personas
(
   id int primary key identity,
   Nombre varchar(30),
   Telefono varchar(13),
   Cedula varchar(13),
   Direccion varchar (max)
);


