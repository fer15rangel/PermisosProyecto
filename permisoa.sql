CREATE DATABASE permisos;

CREATE TABLE usuarios(
idusuario INT PRIMARY KEY,
nombre VARCHAR(50),
apellidop VARCHAR(50),
apellidom VARCHAR(50),
fdn DATE,
rfc VARCHAR(70),
fkidaccesos ENUM('Admi', 'General'),
FOREIGN KEY(fkidaccesos) REFERENCES accesos(idaccesos));

CREATE TABLE producto(
codigobarras INT PRIMARY KEY,
nombre VARCHAR(50),
descripcion VARCHAR(100),
marca VARCHAR(50));

CREATE TABLE herramientas(
codigoherramienta INT PRIMARY KEY,
nombre VARCHAR(50),
medida VARCHAR(50),
marca VARCHAR(50),
descripcion VARCHAR(100));

CREATE TABLE accesos(
idaccesos ENUM('Admi', 'General') PRIMARY KEY);

