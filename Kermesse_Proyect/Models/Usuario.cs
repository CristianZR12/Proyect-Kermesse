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
    using System.ComponentModel.DataAnnotations;

    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.ArqueoCaja = new HashSet<ArqueoCaja>();
            this.ArqueoCaja1 = new HashSet<ArqueoCaja>();
            this.ArqueoCaja2 = new HashSet<ArqueoCaja>();
            this.Gasto = new HashSet<Gasto>();
            this.Gasto1 = new HashSet<Gasto>();
            this.Gasto2 = new HashSet<Gasto>();
            this.IngresoComunidad = new HashSet<IngresoComunidad>();
            this.IngresoComunidad1 = new HashSet<IngresoComunidad>();
            this.IngresoComunidad2 = new HashSet<IngresoComunidad>();
            this.Kermesse = new HashSet<Kermesse>();
            this.Kermesse1 = new HashSet<Kermesse>();
            this.Kermesse2 = new HashSet<Kermesse>();
            this.RolUsuario = new HashSet<RolUsuario>();
        }
    
        [Display( Name = "IdUsuario" )]
        public int idUsuario { get; set; }

        [Display(Name = "UserName")]
        [Required]
        [StringLength(40, ErrorMessage = "Tamaño máximo 40 caracteres")]
        public string userName { get; set; }
        
        [Display(Name = "Contraseña")]
        [Required]
        [StringLength(45, ErrorMessage = "Tamaño máximo 45 caracteres")]
        public string pwd { get; set; }

        [Display(Name = "Nombres")]
        [Required]
        [StringLength(45, ErrorMessage = "Tamaño máximo 45 caracteres")]
        public string nombres { get; set; }

        [Display(Name = "Apellidos")]
        [Required]
        [StringLength(45, ErrorMessage = "Tamaño máximo 45 caracteres")]
        public string apellidos { get; set; }

        [Display(Name = "Email")]
        [Required]
        [StringLength(45, ErrorMessage = "Tamaño máximo 45 caracteres")]
        public string email { get; set; }
        
        [Display(Name = "Estado")]
        public int estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArqueoCaja> ArqueoCaja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArqueoCaja> ArqueoCaja1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArqueoCaja> ArqueoCaja2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gasto> Gasto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gasto> Gasto1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gasto> Gasto2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngresoComunidad> IngresoComunidad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngresoComunidad> IngresoComunidad1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngresoComunidad> IngresoComunidad2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kermesse> Kermesse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kermesse> Kermesse1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kermesse> Kermesse2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolUsuario> RolUsuario { get; set; }
    }
}
