//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kermesse_Proyect.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ArqueoCaja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ArqueoCaja()
        {
            this.ArqueoCajaDet = new HashSet<ArqueoCajaDet>();
        }
    
        public int idArqueoCaja { get; set; }
        public int kermesse { get; set; }
        public Nullable<System.DateTime> fechaArqueo { get; set; }
        public Nullable<decimal> granTotal { get; set; }
        public int usuarioCreacion { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public Nullable<int> usuarioModificacion { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<int> usuarioEliminacion { get; set; }
        public Nullable<System.DateTime> fechaEliminacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArqueoCajaDet> ArqueoCajaDet { get; set; }
        public virtual Kermesse Kermesse1 { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        public virtual Usuario Usuario2 { get; set; }
    }
}