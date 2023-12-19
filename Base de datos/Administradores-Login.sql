CREATE DATABASE AvisosLaPalma

USE AvisosLaPalma

--Crear las tablas para almacenar los usuarios y contraseñas
CREATE TABLE USUARIOS
(
	UserName char(8) NOT NULL,
	Password varchar(100),
)


--Creamos un procedimiento para agregar un administrador
CREATE OR ALTER PROCEDURE SP_AgregarUsuario
@UserName char(8),
@Password varchar(100)
AS
BEGIN
    INSERT INTO USUARIOS(UserName, Password)
	VALUES(@UserName, @Password)
END

--Datos de prueba
EXEC SP_AgregarUsuario 'Isaac', 'Papadopolus';
SELECT * FROM USUARIOS


--Creamos un procedimiento para eliminar a los administradores
CREATE OR ALTER PROCEDURE SP_EliminarUsuarios
@UserName char(8)
AS
BEGIN
    DELETE FROM USUARIOS WHERE @UserName = UserName;
END

--Datos de prueba
EXEC SP_EliminarUsuarios'Isaac';
SELECT * FROM USUARIOS

