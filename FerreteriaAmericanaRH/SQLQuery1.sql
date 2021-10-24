create table Encabezado(
	Id int not null primary key identity(1,1),
	TipoAutodeterminacion nvarchar(2) not null,
	RNC int not null,
	Periodo nvarchar(6) not null
);
create table Detalle(
	Id int not null primary key identity(1,1),
	EncabezadoId int FOREIGN KEY REFERENCES Encabezado(Id),
	TipoDocumento nvarchar(3) not null,
	Documento int not null,
	CodigoNomina nvarchar(4) not null,
	Empleado nvarchar(60) null
);