
CREATE TABLE Persona (
    id_persona INT PRIMARY KEY,
    nombre VARCHAR(50),
    apellidos VARCHAR(100),
    telefono VARCHAR(15),
    ci VARCHAR(15),
    correo VARCHAR(100),
    estado VARCHAR(20)
);

-- Insertar datos de ejemplo
INSERT INTO Persona (id_persona, nombre, apellidos, telefono, ci, correo, estado)
VALUES
    (1, 'Juan', 'Pérez', '123456789', '1234567', 'juan@example.com', 'activo'),
    (2, 'María', 'González', '987654321', '7654321', 'maria@example.com', 'inactivo');
SELECT * FROM Persona;

CREATE TABLE Usuario (
    id_usuario INT PRIMARY KEY,
    id_persona INT,
    nombreuser VARCHAR(50),
    contraseña VARCHAR(100),
    fechareg DATE
);

-- Insertar datos de ejemplo
INSERT INTO Usuario (id_usuario, id_persona, nombreuser, contraseña, fechareg)
VALUES
    (1, 101, 'juan123', 'secreto123', '2024-03-11'),
    (2, 102, 'maria456', 'clave456', '2024-03-11');


SELECT * FROM Usuario;


CREATE TABLE UsuarioRol (
    idusuariorol INT PRIMARY KEY,
    idusuario INT,
    ideol INT,
    fechaasigna DATE,
    estado VARCHAR(20)
);


INSERT INTO UsuarioRol (idusuariorol, idusuario, ideol, fechaasigna, estado)
VALUES
    (1, 101, 201, '2024-03-11', 'activo'),
    (2, 102, 202, '2024-03-11', 'inactivo');


SELECT * FROM UsuarioRol;


CREATE TABLE Rol (
    idrol INT PRIMARY KEY,
    nombre VARCHAR(50),
    estado VARCHAR(20)
);
INSERT INTO Rol (idrol, nombre, estado)
VALUES
    (1, 'Administrador', 'activo'),
    (2, 'Usuario', 'inactivo');
SELECT * FROM Rol;

CREATE TABLE Cliente (
    idcliente INT PRIMARY KEY,
    id_persona INT,
    tipo_cliente VARCHAR(50),
    codigoclie VARCHAR(20),
    estado VARCHAR(20)
);

INSERT INTO Cliente (idcliente, id_persona, tipo_cliente, codigoclie, estado)
VALUES
    (1, 101, 'Particular', 'CL1001', 'activo'),
    (2, 102, 'Empresa', 'CL2002', 'inactivo');
SELECT * FROM Cliente;

CREATE TABLE Venta (
    idventa INT PRIMARY KEY,
    idcliente INT,
    idvendedor INT,
    fecha DATE,
    total DECIMAL(10, 2),
    estado VARCHAR(20)
);
INSERT INTO Venta (idventa, idcliente, idvendedor, fecha, total, estado)
VALUES
    (1, 101, 201, '2024-03-11', 150.75, 'activo'),
    (2, 102, 202, '2024-03-12', 220.50, 'inactivo');

SELECT * FROM Venta;
-- Crear la tabla 
CREATE TABLE DetalleVenta (
    iddetallevent INT PRIMARY KEY,
    idventa INT,
    idproducto INT,
    cantidad INT,
    precio_venta DECIMAL(10, 2),
    subtotal DECIMAL(10, 2),
    estado VARCHAR(20)
);
--ejemplo
INSERT INTO DetalleVenta (iddetallevent, idventa, idproducto, cantidad, precio_venta, subtotal, estado)
VALUES
    (1, 101, 501, 5, 25.50, 127.50, 'activo'),
    (2, 102, 502, 3, 18.75, 56.25, 'inactivo');
SELECT * FROM DetalleVenta;

-- Crear la tabla 
CREATE TABLE DetalleIngreso (
    iddetalleing INT PRIMARY KEY,
    idproducto INT,
    idingreso INT,
    fechavenc DATE,
    cantidad INT,
    precio_costo DECIMAL(10, 2),
    precioventa DECIMAL(10, 2),
    subtotal DECIMAL(10, 2),
    estado VARCHAR(20)
);
--ejemplo
INSERT INTO DetalleIngreso (iddetalleing, idproducto, idingreso, fechavenc, cantidad, precio_costo, precioventa, subtotal, estado)
VALUES
    (1, 501, 1001, '2024-03-11', 10, 15.50, 25.00, 250.00, 'activo'),
    (2, 502, 1002, '2024-03-12', 5, 12.75, 20.00, 100.00, 'inactivo');
SELECT * FROM DetalleIngreso;

-- Crear la tabla 
CREATE TABLE Ingreso (
    idingreso INT PRIMARY KEY,
    idproveedor INT,
    fechaingreso DATE,
    total DECIMAL(10, 2),
    estado VARCHAR(20)
);
-- ejemplo
INSERT INTO Ingreso (idingreso, idproveedor, fechaingreso, total, estado)
VALUES
    (1, 101, '2024-03-11', 500.75, 'activo'),
    (2, 102, '2024-03-12', 800.50, 'inactivo');

SELECT * FROM Ingreso;

-- Crear la tabla
CREATE TABLE Producto (
    idproducto INT PRIMARY KEY,
    idtipoproducto INT,
    nombre VARCHAR(100),
    codigobarra VARCHAR(50),
    idmarca INT,
    unidad VARCHAR(20),
    descripcion TEXT,
    estado VARCHAR(20)
);
--ejemplo
INSERT INTO Producto (idproducto, idtipoproducto, nombre, codigobarra, idmarca, unidad, descripcion, estado)
VALUES
    (1, 101, 'Smartphone', '123456789', 201, 'Unidad', 'Teléfono móvil inteligente', 'activo'),
    (2, 102, 'Laptop', '987654321', 202, 'Unidad', 'Computadora portátil', 'inactivo');

SELECT * FROM Producto;

-- Crear la tabla Provee
CREATE TABLE Provee (
    idprovee INT PRIMARY KEY,
    idproducto INT,
    idproveedor INT,
    fecha DATE,
    precio DECIMAL(10, 2)
);

-- ejemplo
INSERT INTO Provee (idprovee, idproducto, idproveedor, fecha, precio)
VALUES
    (1, 101, 201, '2024-03-11', 50.75),
    (2, 102, 202, '2024-03-12', 80.50);

SELECT * FROM Provee;

-- Crear la tabla Proveedor
CREATE TABLE Proveedor (
    idproveedor INT PRIMARY KEY,
    nombre VARCHAR(100),
    telefono VARCHAR(15),
    direccion VARCHAR(200),
    estado VARCHAR(20)
);

-- Insertar datos de ejemplo
INSERT INTO Proveedor (idproveedor, nombre, telefono, direccion, estado)
VALUES
    (1, 'Proveedor A', '123456789', 'Calle 123, Ciudad X', 'activo'),
    (2, 'Proveedor B', '987654321', 'Avenida ABC, Ciudad Y', 'inactivo');

SELECT * FROM Proveedor;

-- Crear la tabla TipoProducto
CREATE TABLE TipoProducto (
    idtipoprod INT PRIMARY KEY,
    nombre VARCHAR(50),
    estado VARCHAR(20)
);

-- ejemplo
INSERT INTO TipoProducto (idtipoprod, nombre, estado)
VALUES
    (1, 'Electrónica', 'activo'),
    (2, 'Ropa', 'inactivo');

SELECT * FROM TipoProducto;

-- Crear la tabla Marca
CREATE TABLE Marca (
    idmarca INT PRIMARY KEY,
    nombre VARCHAR(50),
    estado VARCHAR(20)
);

--ejemplo
INSERT INTO Marca (idmarca, nombre, estado)
VALUES
    (1, 'Samsung', 'activo'),
    (2, 'Apple', 'inactivo');
SELECT * FROM Marca;