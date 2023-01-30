CREATE DATABASE CRUD
USE CRUD
CREATE TABLE USUARIO(
USUARIO VARCHAR(25) PRIMARY KEY NOT NULL,
CONTRASEÑA VARCHAR(25),
ROLL VARCHAR(25)
)
INSERT USUARIO VALUES
(
'chris@gmail.com','123abc','Administrador'
)
INSERT USUARIO VALUES
(
'erick.com','123abcc','Secretario'
)
INSERT USUARIO VALUES
(
'manis.com','123abcd','Usuario'
)

CREATE TABLE ADMINISTRADOR
(
ID INT NOT NULL PRIMARY KEY,
NOMBRE VARCHAR(25),
APELLIDO VARCHAR(25),
EDAD INT,
CORREO VARCHAR(25),
USUARIO VARCHAR(25),
CONTRASEÑA VARCHAR(25),
ROL VARCHAR(25)
)
INSERT ADMINISTRADOR VALUES 
(
	1,'Christian','Juarez',16,'calejandrojp@gmail.com','Cronos','123abcc','Administrador'
)
INSERT ADMINISTRADOR VALUES 
(
	2,'Erick','Lopez',17,'grericdi@gmail.com','Grericdi','eri2005','Cliente'
)
INSERT ADMINISTRADOR VALUES 
(
	3,'Daniel','Barrios',18,'','Daniel16','Dani2004','Secretaria'
)
INSERT ADMINISTRADOR VALUES 
(
	4,'Lucia','Paz',22,'','Luchi15@gmail.com','luchi15','Administrador'
)
INSERT ADMINISTRADOR VALUES 
(
	5,'Oscar','Paz',24,'','Lsdj@gmail.com','Menfra','Usuario'
)
select * from ADMINISTRADOR; 

