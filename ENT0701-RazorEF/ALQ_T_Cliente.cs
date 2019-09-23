namespace ENT0701_RazorEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALQ_T_Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALQ_T_Cliente()
        {
            ALQ_T_Alquiler = new HashSet<ALQ_T_Alquiler>();
        }

        [Key]
        [StringLength(9)]
        public string DNICliente { get; set; }

        [StringLength(50)]
        public string Apellidos { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string DatosCliente { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public DateTime? FechaCarnet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALQ_T_Alquiler> ALQ_T_Alquiler { get; set; }
    }
}
