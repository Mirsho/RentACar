namespace ENT0701_RazorEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALQ_T_Alquiler
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string DNICliente { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Matricula { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFinal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrecioDiaEfectuado { get; set; }

        public virtual ALQ_T_Cliente ALQ_T_Cliente { get; set; }

        public virtual ALQ_T_Coche ALQ_T_Coche { get; set; }
    }
}
