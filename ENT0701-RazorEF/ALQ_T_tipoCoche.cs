namespace ENT0701_RazorEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALQ_T_tipoCoche
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALQ_T_tipoCoche()
        {
            ALQ_T_Coche = new HashSet<ALQ_T_Coche>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodTipo { get; set; }

        [StringLength(100)]
        public string DescripcionTipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrecioDia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALQ_T_Coche> ALQ_T_Coche { get; set; }
    }
}
