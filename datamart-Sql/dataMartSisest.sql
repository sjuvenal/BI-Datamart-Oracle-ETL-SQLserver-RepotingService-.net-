create table DimTiempo
(
	KeyTiempo int primary key identity(1,1),
    FechaSK int ,
    AñoMes int not null,
    Fecha date not null, 
    Año smallint not null,
    Trimestre smallint not null,
    Mes smallint not null,
    Semana smallint not null,
    Dia smallint not null,
    DiaSemana smallint not null,
    NTrimestre char(7) not null,
    NMes char(15) not null,
    NMes3L char(3) not null,
    NSemana char(10) not null,
    NDia char(6) not null,
    NDiaSemana char(10) not null
)


create table DimParadaTramo
(
KeyParadaTramo integer primary key identity(1,1),
dPtrCodParada integer,
dPtrParada varchar(25),
dPtrTramo varchar(25))


create table DimTipoDia
(
KeyTipoDia integer primary key identity(1,1),
dTdiCodTipoDia integer,
dTdiNombre varchar(25))

create table DimPerfil
(
KeyPerfil integer primary key identity(1,1),
dPerCodPerfil char(2),
dPerNombre varchar(25))


create table HechoValidaciones_Dia
(
KeyValidaciones integer identity(1,1),
KeyTiempo integer,
KeyParadaTramo  integer,
keyTipoDia  integer,
KeyPerfil integer,
cantidad integer
primary key(KeyValidaciones,KeyTiempo,KeyParadaTramo,keyTipoDia,KeyPerfil),
FOREIGN KEY (KeyTiempo) REFERENCES DimTiempo(KeyTiempo),
FOREIGN KEY (KeyParadaTramo) REFERENCES DimParadaTramo(KeyParadaTramo),
FOREIGN KEY (keyTipoDia) REFERENCES DimTipoDia(keyTipoDia),
FOREIGN KEY (KeyPerfil) REFERENCES DimPerfil(KeyPerfil))

--select * from DimTiempo


--select * from DimTiempo

--select * from HechoValidaciones_Dia