CREATE DATABASE NOTAS_APP;
GO

USE NOTAS_APP;
GO

-- Tabla de usuarios
CREATE TABLE Usuarios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Contrasena NVARCHAR(255) NOT NULL
);
GO

-- Tabla de tags (etiquetas)
CREATE TABLE Tags (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL UNIQUE
);
GO

-- Tabla de notas
CREATE TABLE Notas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioId INT NOT NULL,
    TagId INT NOT NULL,
    Titulo NVARCHAR(100) NULL,
    Contenido NVARCHAR(200) NOT NULL,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id),
    FOREIGN KEY (TagId) REFERENCES Tags(Id)
);
GO

-- Insertar usuario de prueba
INSERT INTO Usuarios (Email, Contrasena)
VALUES ('prueba@mail.com', 'contraseña1234');
GO

-- Insertar tags
INSERT INTO Tags (Nombre) VALUES ('futbol'), ('facultad'), ('familia');
GO

-- Insertar notas de ejemplo
DECLARE @UsuarioId INT = (SELECT TOP 1 Id FROM Usuarios WHERE Email = 'prueba@mail.com');
DECLARE @FutbolTagId INT = (SELECT Id FROM Tags WHERE Nombre = 'futbol');
DECLARE @FacultadTagId INT = (SELECT Id FROM Tags WHERE Nombre = 'facultad');
DECLARE @FamiliaTagId INT = (SELECT Id FROM Tags WHERE Nombre = 'familia');

INSERT INTO Notas (UsuarioId, TagId, Contenido)
VALUES
(@UsuarioId, @FutbolTagId, 'River ganó el clásico este fin de semana'),
(@UsuarioId, @FutbolTagId, 'Messi jugó un gran partido en la selección'),
(@UsuarioId, @FacultadTagId, 'Tengo que entregar el TP de bases de datos'),
(@UsuarioId, @FacultadTagId, 'Empezaron las inscripciones al nuevo cuatrimestre'),
(@UsuarioId, @FacultadTagId, 'Aprobar el examen de ASP.NET es mi objetivo'),
(@UsuarioId, @FamiliaTagId, 'El domingo almorzamos todos en casa de mamá');
GO