using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_01_Crud_ADO_NET.filedb
{
    class SqlServer
    {
        /*
         * lineas de Sql-Server
         * 
        create database crudbasic
            go
        use crudbasic
            go
        create table persona(
		id int identity(1,1),
		nombre varchar(60),
		apellido varchar(60),
		correo varchar(60)
		primary key(id)
	    );

        select * from persona
         
         */
        /*
         --para que el proyecto funcione es necesario agregar (EntityFramework.SqlServer y EntityFramework) desde el administrador de paquetes NuGet si el proyecto se descargo de gitHUb
         --pero si se esta recreando desde 0 se agregan por default cuando agregamos el modelo con ADO.NET Entity  se agrega (EntityFramework.SqlServer y EntityFramework) 
         --o no probe pero creo seria una solucion el borrar el modelo y sgregar uno nuevo con ADO.NET
         */
    }
}
