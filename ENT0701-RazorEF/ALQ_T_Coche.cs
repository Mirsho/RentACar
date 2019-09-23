namespace ENT0701_RazorEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALQ_T_Coche
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALQ_T_Coche()
        {
            ALQ_T_Alquiler = new HashSet<ALQ_T_Alquiler>();
        }

        [Key]
        [StringLength(10)]
        public string Matricula { get; set; }

        [StringLength(100)]
        public string DescripcionEstado { get; set; }

        public int? codTipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALQ_T_Alquiler> ALQ_T_Alquiler { get; set; }

        public virtual ALQ_T_tipoCoche ALQ_T_tipoCoche { get; set; }
    }
}
