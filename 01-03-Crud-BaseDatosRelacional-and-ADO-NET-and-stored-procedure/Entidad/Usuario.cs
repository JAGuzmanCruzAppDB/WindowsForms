using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_03_Crud_BaseDatosRelacional_and_ADO_NET_and_stored_procedure.Entidad
{
    class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public int rolid { get; set; }
    }
}
