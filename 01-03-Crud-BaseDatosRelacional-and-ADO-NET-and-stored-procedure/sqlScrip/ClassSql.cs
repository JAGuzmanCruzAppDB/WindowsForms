using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_03_Crud_BaseDatosRelacional_and_ADO_NET_and_stored_procedure.sqlScrip
{
    class ClassSql
    {
		/*
         create database dbtst

use dbtst
use master

drop database dbtst

create table modulo(
	id int identity(1,1),
	nombre varchar(60)not null,
	--opcion
	primary key(id)
);

create table opcion(
	id int identity(1,1),
	nombre varchar(60) not null,
	moduloid int references modulo(id)not null
	primary key(id)
);
create table rol(
	id int identity(1,1),
	nombre varchar(60)not null
	primary key(id) 
);

create table permiso(
	id int identity(1,1),
	rolUsuarioid int references rol(id)not null,
	opcionid int references opcion(id)not null,
	permitido bit not null
);

create table usuario(
	id int identity(1,1),
	nombre varchar(60)not null,
	passwordd varchar(60)not null,
	rolid int references rol(id)not null
	primary key(id)
);

select *from modulo


insert into modulo(nombre)values('ADMINISTRACION');
insert into modulo(nombre)values('SERVICIOS');
insert into modulo(nombre)values('MANTENIMIENTO');
insert into modulo(nombre)values('CLIENTES');
--insert into modulo(nombre)values('ADMINISTRACION');

SELECT *FROM opcion

insert into opcion(nombre, moduloid)values('SOCIOS',1);
insert into opcion(nombre, moduloid)values('EMPLEADOS',1);
insert into opcion(nombre, moduloid)values('USUARIOS',1);
insert into opcion(nombre, moduloid)values('PESAS',2);
insert into opcion(nombre, moduloid)values('SPINNING',2);
insert into opcion(nombre, moduloid)values('PILATES',2);
insert into opcion(nombre, moduloid)values('SERVICIOS',3);
insert into opcion(nombre, moduloid)values('MEMBRESIAS',3);
insert into opcion(nombre, moduloid)values('LOCKER',3);
insert into opcion(nombre, moduloid)values('ROL DE USUARIO',3);
insert into opcion(nombre, moduloid)values('ALTA',4);
insert into opcion(nombre, moduloid)values('BAJA',4);
insert into opcion(nombre, moduloid)values('VENTA',4);

select * from rol

insert into rol(nombre)values('ADMINISTRACION');
insert into rol(nombre)values('CLIENTES');

select *from permiso

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


select * from usuario

insert into usuario(nombre,passwordd,rolid)values('juan','123',1)

create procedure spguardar_rol
@nombre varchar(30),
@id int output
as 
	begin
		set nocount on;
			begin
				insert into rol(nombre)
				values(@nombre)
				select @id =SCOPE_IDENTITY()
			end
	end

create procedure spGuardarPermiso
@rolusuarioid int,
@opcionid int,
@permitido bit
	as
		begin
			set nocount on;
				begin
					insert into permiso(rolUsuarioid,opcionid,permitido)
					values(@rolusuarioid,@opcionid,@permitido)
				end
		end

use dbtst

create procedure spComboRol
as
	begin
		set nocount on;
			begin
				select * from rol
			end
	end

create procedure spGuardarUsuario
@nombre varchar(60),
@passwordd varchar(60),
@rolid int
as
	begin
		set nocount on;
			begin
				insert into usuario(nombre,passwordd,rolid)
				values(@nombre,@passwordd,@rolid)
			end
	end

alter procedure spBuscarUsuario
@nombre varchar(60),
@passwordd varchar(60),
@idUsuario int output
as
	begin
		set nocount on;
			begin
				if exists(select * from usuario where
						nombre=@nombre and passwordd=@passwordd)

					select @idUsuario=(select id from usuario where
						nombre=@nombre and passwordd=@passwordd)
					
					else
						select @idUsuario=0
			end
	end





declare @idUsuario int
exec spBuscarUsuario 'juan','123',@idUsuario output
select @idUsuario

select *from usuario

create procedure spSelectOpcion
@idRol int 
as
	begin
		set nocount on;
			begin
				select * from permiso
					where rolUsuarioid=@idRol
			end
	end
         
         */
	}
}
