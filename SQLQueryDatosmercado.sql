use SYMercadoDbo


select * from usuario

select * from rol

INSERT INTO rol (descripcion)
VALUES ('Admin');

-- Inserción en la tabla rol
INSERT INTO rol (descripcion)
VALUES ('Admin');

-- Inserción en la tabla usuario
INSERT INTO usuario (documento, Razon_Social, correo, clave, idrol, estado)
VALUES 
('0001', 'Admin', 'admin@gmail.com', '123', 1, 1),
('0002', 'Juan Perez', 'juan.perez@gmail.com', 'abc123', 1, 1),
('0003', 'Maria Garcia', 'maria.garcia@gmail.com', 'def456', 1, 1)

CREATE VIEW Vusuario AS
SELECT idusuario, clave
FROM usuario

select * from Vusuario
go

