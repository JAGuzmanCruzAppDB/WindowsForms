//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _01_02_Crud_BaseDatosRelacional_ADO_NET
{
    using System;
    using System.Collections.Generic;
    
    public partial class permiso
    {
        public int id { get; set; }
        public Nullable<int> rolUsuarioid { get; set; }
        public Nullable<int> opcionid { get; set; }
        public Nullable<bool> permitido { get; set; }
    
        public virtual opcion opcion { get; set; }
        public virtual rol rol { get; set; }
    }
}
