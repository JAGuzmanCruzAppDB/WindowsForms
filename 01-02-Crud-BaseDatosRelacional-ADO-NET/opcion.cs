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
    
    public partial class opcion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public opcion()
        {
            this.permiso = new HashSet<permiso>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public Nullable<int> moduloid { get; set; }
    
        public virtual modulo modulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<permiso> permiso { get; set; }
    }
}
