using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_Crud_BaseDatosRelacional_ADO_NET
{
    class dbScrip
    {
		/*
create database dbtst

use dbtst

drop database dbtst

create table modulo(
	id int identity(1,1),
	nombre varchar(60),
	--opcion
	primary key(id)
);

create table opcion(
	id int identity(1,1),
	nombre varchar(60),
	moduloid int references modulo(id)null
	primary key(id)
);

create table permiso(
	id int identity(1,1),
	rolUsuarioid int references rol(id)null,
	opcionid int references opcion(id)null,
	permitido bit null
);


create table rol(
	id int identity(1,1),
	nombre varchar(60)
	primary key(id)
);
create table usuario(
	id int identity(1,1),
	nombre varchar(60),
	passwordd varchar(60),
	rolid int references rol(id)null
	primary key(id)
);


insert into modulo(nombre)values('ADMINISTRACION');
insert into modulo(nombre)values('SERVICIOS');
insert into modulo(nombre)values('MANTENIMIENTO');
insert into modulo(nombre)values('CLIENTES');
--insert into modulo(nombre)values('ADMINISTRACION');

insert into opcion(nombre, moduloid)values('SOCIOS',1);
insert into opcion(nombre, moduloid)values('EMPLEADOS',1);
insert into opcion(nombre, moduloid)values('USUARIOS',1);
insert into opcion(nombre, moduloid)values('PESAS',2);
insert into opcion(nombre, moduloid)values('SPINNING',2);
insert into opcion(nombre, moduloid)values('PILATES',2);
insert into opcion(nombre, moduloid)values('SERVICIOS',3);
insert into opcion(nombre, moduloid)values('MEMBRESIAS',3);
insert into opcion(nombre, moduloid)values('LOCKER',3);
insert into opcion(nombre, moduloid)values('ROL USUARIO',3);
insert into opcion(nombre, moduloid)values('ALTA',4);
insert into opcion(nombre, moduloid)values('BAJA',4);
insert into opcion(nombre, moduloid)values('VENTA',4);

insert into rol(nombre)values('ADMINISTRACION');
insert into rol(nombre)values('CLIENTES');

--los siguientes son los permisos para un admin y solo es para el primer inicio del sistema
--despues se agregaran los permisos para los clientes, con la app en ejecución 
insert into permiso(rolUsuarioid,opcionid,permitido)values(1,1,1);
insert into permiso(rolUsuarioid,opcionid,permitido)values(1,2,1);
insert into permiso(rolUsuarioid,opcionid,permitido)values(1,3,1);
insert into permiso(rolUsuarioid,opcionid,permitido)values(1,4,1);
insert into permiso(rolUsuarioid,opcionid,permitido)values(1,5,1);
insert into permiso(rolUsuarioid,opcionid,permitido)values(1,6,1);
insert into permiso(rolUsuarioid,opcionid,permitido)values(1,7,1);
insert into permiso(rolUsuarioid,opcionid,permitido)values(1,8,1);
insert into permiso(rolUsuarioid,opcionid,permitido)values(1,9,1);
insert into permiso(rolUsuarioid,opcionid,permitido)values(1,10,1);
insert into permiso(rolUsuarioid,opcionid,permitido)values(1,11,1);
insert into permiso(rolUsuarioid,opcionid,permitido)values(1,12,1);
insert into permiso(rolUsuarioid,opcionid,permitido)values(1,13,1);


insert into permiso(rolUsuarioid,opcionid,permitido)values(2,1,0);
insert into permiso(rolUsuarioid,opcionid,permitido)values(2,2,0);
insert into permiso(rolUsuarioid,opcionid,permitido)values(2,3,0);
insert into permiso(rolUsuarioid,opcionid,permitido)values(2,4,0);
insert into permiso(rolUsuarioid,opcionid,permitido)values(2,5,0);
insert into permiso(rolUsuarioid,opcionid,permitido)values(2,6,0);
insert into permiso(rolUsuarioid,opcionid,permitido)values(2,7,0);
insert into permiso(rolUsuarioid,opcionid,permitido)values(2,8,0);
insert into permiso(rolUsuarioid,opcionid,permitido)values(2,9,0);
insert into permiso(rolUsuarioid,opcionid,permitido)values(2,10,0);
insert into permiso(rolUsuarioid,opcionid,permitido)values(2,11,1);
insert into permiso(rolUsuarioid,opcionid,permitido)values(2,12,1);
insert into permiso(rolUsuarioid,opcionid,permitido)values(2,13,1);


insert into usuario(nombre,passwordd,rolid)values('juan','123',1)

select *from permiso

SELECT *FROM opcion

select * from rol

select * from usuario
*/
	}
}
