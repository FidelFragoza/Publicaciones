CREATE DATABASE AvisosLaPalma

USE AvisosLaPalma

--Crear las tablas para almacenar los post
CREATE TABLE EDUCACION
(
	ID int IDENTITY(1,1) NOT NULL,
	Titulo varchar(100),
	Descripcion text,
	Creador varchar(100),
	Fecha date
)

CREATE TABLE SALUD
(
	ID int IDENTITY(1,1) NOT NULL,
	Titulo varchar(100),
	Descripcion text,
	Creador varchar(100),
	Fecha date
)

CREATE TABLE DEPORTES
(
	ID int IDENTITY(1,1) NOT NULL,
	Titulo varchar(100),
	Descripcion text,
	Creador varchar(100),
	Fecha date
)

CREATE TABLE SINDICATURA
(
	ID int IDENTITY(1,1) NOT NULL,
	Titulo varchar(100),
	Descripcion text,
	Creador varchar(100),
	Fecha date
)

CREATE TABLE EVENTOS
(
	ID int IDENTITY(1,1) NOT NULL,
	Titulo varchar(100),
	Descripcion text,
	Creador varchar(100),
	Fecha date
)

CREATE TABLE COMERCIO
(
	ID int IDENTITY(1,1) NOT NULL,
	Titulo varchar(100),
	Descripcion text,
	Creador varchar(100),
	Fecha date
)


--Creamos un procedimiento para agregar una publicacion
CREATE OR ALTER PROCEDURE SP_AgregarPublicacion
@NombreDeLaTabla varchar(50),
@Titulo varchar(100),
@Descripcion text,
@Creador varchar(100)
AS
BEGIN
    IF @NombreDeLaTabla = 'EDUCACION'
    BEGIN
        -- Verificar si el t�tulo ya existe en la tabla 'Comercio'
        IF NOT EXISTS (SELECT 1 FROM EDUCACION WHERE Titulo = @Titulo)
        BEGIN
            -- Insertar solo si el t�tulo no se repite
            INSERT INTO EDUCACION(Titulo, Descripcion, Creador, Fecha)
            VALUES (@Titulo, @Descripcion, @Creador, GETDATE());
        END
        ELSE
        BEGIN
            PRINT 'El t�tulo ya existe en la tabla. No se realiz� la inserci�n.';
        END
    END
    ELSE IF @NombreDeLaTabla = 'SALUD'
    BEGIN
        -- Verificar si el t�tulo ya existe en la tabla 'Comercio'
        IF NOT EXISTS (SELECT 1 FROM SALUD WHERE Titulo = @Titulo)
        BEGIN
            -- Insertar solo si el t�tulo no se repite
            INSERT INTO SALUD(Titulo, Descripcion, Creador, Fecha)
            VALUES (@Titulo, @Descripcion, @Creador, GETDATE());
        END
        ELSE
        BEGIN
            PRINT 'El t�tulo ya existe en la tabla. No se realiz� la inserci�n.';
        END
    END
    ELSE IF @NombreDeLaTabla = 'DEPORTES'
    BEGIN
        -- Verificar si el t�tulo ya existe en la tabla 'Comercio'
        IF NOT EXISTS (SELECT 1 FROM DEPORTES WHERE Titulo = @Titulo)
        BEGIN
            -- Insertar solo si el t�tulo no se repite
            INSERT INTO DEPORTES(Titulo, Descripcion, Creador, Fecha)
            VALUES (@Titulo, @Descripcion, @Creador, GETDATE());
        END
        ELSE
        BEGIN
            PRINT 'El t�tulo ya existe en la tabla. No se realiz� la inserci�n.';
        END
    END
	ELSE IF @NombreDeLaTabla = 'SINDICATURA'
    BEGIN
        -- Verificar si el t�tulo ya existe en la tabla 'Comercio'
        IF NOT EXISTS (SELECT 1 FROM SINDICATURA WHERE Titulo = @Titulo)
        BEGIN
            -- Insertar solo si el t�tulo no se repite
            INSERT INTO SINDICATURA(Titulo, Descripcion, Creador, Fecha)
            VALUES (@Titulo, @Descripcion, @Creador, GETDATE());
        END
        ELSE
        BEGIN
            PRINT 'El t�tulo ya existe en la tabla. No se realiz� la inserci�n.';
        END
    END
	ELSE IF @NombreDeLaTabla = 'EVENTOS'
    BEGIN
        -- Verificar si el t�tulo ya existe en la tabla 'Comercio'
        IF NOT EXISTS (SELECT 1 FROM EVENTOS WHERE Titulo = @Titulo)
        BEGIN
            -- Insertar solo si el t�tulo no se repite
				INSERT INTO EVENTOS(Titulo, Descripcion, Creador, Fecha)
            VALUES (@Titulo, @Descripcion, @Creador, GETDATE());
        END
        ELSE
        BEGIN
            PRINT 'El t�tulo ya existe en la tabla. No se realiz� la inserci�n.';
        END
    END
    ELSE IF @NombreDeLaTabla = 'COMERCIO'
    BEGIN
        -- Verificar si el t�tulo ya existe en la tabla 'Comercio'
        IF NOT EXISTS (SELECT 1 FROM COMERCIO WHERE Titulo = @Titulo)
        BEGIN
            -- Insertar solo si el t�tulo no se repite
            INSERT INTO COMERCIO(Titulo, Descripcion, Creador, Fecha)
            VALUES (@Titulo, @Descripcion, @Creador, GETDATE());
        END
        ELSE
        BEGIN
            PRINT 'El t�tulo ya existe en la tabla. No se realiz� la inserci�n.';
        END
    END
END


--Datos de prueba
EXEC SP_AgregarPublicacion'EDUCACION', 'Prueba', 'Noticia de prueba', 'Fidel Fragoza';
EXEC SP_AgregarPublicacion 'SALUD', 'Nuevo descubrimiento m�dico', 'Se ha hecho un importante descubrimiento en el campo de la medicina.', 'Dr. L�pez';
EXEC SP_AgregarPublicacion 'DEPORTES', 'Nuevo r�cord en el mundo del deporte', 'Se ha establecido un nuevo r�cord en una competici�n importante.', 'Carlos Mart�nez';
EXEC SP_AgregarPublicacion 'SINDICATURA', 'Nuevo informe sobre la gesti�n municipal', 'Se ha presentado un informe detallado sobre la gesti�n municipal actual.', 'Ana Rodr�guez';
EXEC SP_AgregarPublicacion 'EVENTOS', 'Pr�ximo evento comunitario', 'Se anuncia un evento comunitario para la pr�xima semana.', 'Juan P�rez';
EXEC SP_AgregarPublicacion 'COMERCIO', 'Nueva apertura de tienda en el centro', 'Se inaugura una nueva tienda en el coraz�n de la ciudad.', 'Mar�a Guti�rrez';


--Creamos un procedimiento para eliminar las publicaciones
CREATE OR ALTER PROCEDURE SP_EliminarPublicacion
@NombreDeLaTabla varchar(50),
@Titulo varchar(100)
AS
BEGIN
    IF @NombreDeLaTabla = 'EDUCACION'
    BEGIN
        DELETE FROM EDUCACION WHERE ID = @Titulo;
    END
    ELSE IF @NombreDeLaTabla = 'SALUD'
    BEGIN
        DELETE FROM SALUD WHERE Titulo = @Titulo;
    END
    ELSE IF @NombreDeLaTabla = 'DEPORTES'
    BEGIN
       DELETE FROM DEPORTES WHERE Titulo = @Titulo;
    END
	ELSE IF @NombreDeLaTabla = 'SINDICATURA'
    BEGIN
        DELETE FROM SINDICATURA WHERE Titulo = @Titulo;
    END
	ELSE IF @NombreDeLaTabla = 'EVENTOS'
    BEGIN
        DELETE FROM EVENTOS WHERE Titulo = @Titulo;
    END
    ELSE IF @NombreDeLaTabla = 'COMERCIO'
    BEGIN
       DELETE FROM COMERCIO WHERE Titulo = @Titulo;
    END
END

--Datos de prueba
EXEC SP_EliminarPublicacion'EDUCACION','Prueba';
EXEC SP_EliminarPublicacion 'SALUD', 'Nuevo descubrimiento m�dico';
EXEC SP_EliminarPublicacion 'DEPORTES', 'Nuevo r�cord en el mundo del deporte';
EXEC SP_EliminarPublicacion 'SINDICATURA', 'Nuevo informe sobre la gesti�n municipal';
EXEC SP_EliminarPublicacion 'EVENTOS', 'Pr�ximo evento comunitario';
EXEC SP_EliminarPublicacion 'COMERCIO', 'Nueva apertura de tienda en el centro';

