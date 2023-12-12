CREATE DATABASE AvisosLaPalma

USE AvisosLaPalma

--Crear las tablas para almacenar los post
CREATE TABLE PUBLICACIONES
(
	ID char(8) NOT NULL,
	Titulo varchar(100),
	Descripcion text,
	Creador varchar(100),
	Fecha date
)

--Creamos un procedimiento para agregar una publicacion
CREATE OR ALTER PROCEDURE SP_AgregarPublicacion
@ID char(8),
@Titulo varchar(100),
@Descripcion text,
@Creador varchar(100)
AS
BEGIN
    INSERT INTO PUBLICACIONES(ID, Titulo, Descripcion, Creador, Fecha)
	VALUES(@ID, @Titulo, @Descripcion, @Creador, GETDATE())
END


--Datos de prueba
EXEC SP_AgregarPublicacion'PWZ-5000', 'Prueba', 'Beca de estudios', 'Fidel Fragoza';
SELECT * FROM PUBLICACIONES


--Creamos un procedimiento para eliminar las publicaciones
CREATE OR ALTER PROCEDURE SP_EliminarPublicacion
@ID char(8)
AS
BEGIN
    DELETE FROM PUBLICACIONES WHERE ID = @ID;
END

--Datos de prueba
EXEC SP_EliminarPublicacion'PWZ-5000';
SELECT * FROM PUBLICACIONES


SELECT @@SERVERNAME
--DESKTOP-4SJDRKO\SQLEXPRESS

SP_HELPTEXT SP_AgregarPublicacion