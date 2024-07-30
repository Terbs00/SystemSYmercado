create database SYMercadoDbo

go 

use SYMercadoDbo

go

create table rol  (
	idrol int primary key identity,
	descripcion varchar(50),
	Fecha_Registro datetime default getdate()
)

go

create table Permiso (
idpermiso int primary key identity,
idrol int references rol (idrol),
Descripcion varchar(50),
Fecha_Registro datetime default getdate()
)

go 

create table PROVEEDOR (
idproverdor int primary key identity,
descripcion varchar(50),
Razon_Social varchar(50),
correo varchar(50),
Telefono varchar(50),
estado bit,
Fecha_Registro datetime default getdate()
)

go 

create table cliente
(
idCliente int primary key identity,
Documento varchar(50),
NombreCompleto varchar(50),
correo varchar(50),
Telefono varchar(50),
estado bit,
Fecha_Registro datetime default getdate()
)

go 

create table usuario
(
idusuario int primary key identity,
documento varchar(50),
Razon_Social varchar(50),
correo varchar(50),
clave varchar(50),
idrol int references rol (idrol),
estado bit,
Fecha_Registro datetime default getdate()
)

go 

create table Categoria (
idCategoria int primary key identity,
descripcion varchar(100),
estado bit,
Fecha_Registro datetime default getdate ()
)

go

create table Producto (
idproducto int primary key identity,
codigo varchar(50),
Nombre varchar(50),
Descripcion varchar(100),
idCategoria int references Categoria (idCategoria),
stock int not null default 0,
Precio_compra decimal (10,2) default 0,
Precio_Venta decimal (10,2) default 0,
estado bit,
Fecha_Registro datetime default getdate ()
)

go

create table compra (
idCompra int primary key identity,
idusuario int references usuario (idusuario),
idproverdor int references PROVEEDOR (idproverdor),
TipoDocumento varchar(50),
NumeroDocumento varchar(50),
Montototal decimal (10,2),
Fecha_Registro datetime default getdate()
)

go 

create table detalle_compra (
idDCompra int primary key identity,
idCompra int references compra (idCompra),
idproducto int references Producto (idproducto),
Precio_compra decimal (10,2) default 0,
Precio_Venta decimal (10,2) default 0,
cantidad int,
Montototal decimal (10,2),
Fecha_Registro datetime default getdate()
)

go

create table venta (
idventa int primary key identity,
idusuario int references usuario (idusuario),
TipoDocumento varchar(50),
NumeroDocumento varchar(50),
Documento_cliente varchar(50),
Nombre_cliente varchar(100),
MontoPago  decimal (10,2),
MontoCambio decimal (10,2), 
Montototal decimal (10,2),
Fecha_Registro datetime default getdate()
)

go

create table Detalle_venta(
idDVenta int primary key identity,
idventa int references venta (idventa),
idproducto int references Producto (idproducto),
Precio_Venta decimal (10,2),
cantidad int,
Subtotal decimal (10,2),
Fecha_Registro datetime default getdate()
)





