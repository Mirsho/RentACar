namespace ENT0701_RazorEF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ArodpeAzureDB : DbContext
    {
        public ArodpeAzureDB()
            : base("name=ArodpeAzureDB")
        {
        }

        public virtual DbSet<ALQ_T_Alquiler> ALQ_T_Alquiler { get; set; }
        public virtual DbSet<ALQ_T_Cliente> ALQ_T_Cliente { get; set; }
        public virtual DbSet<ALQ_T_Coche> ALQ_T_Coche { get; set; }
        public virtual DbSet<ALQ_T_tipoCoche> ALQ_T_tipoCoche { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ALQ_T_Alquiler>()
                .Property(e => e.DNICliente)
                .IsUnicode(false);

            modelBuilder.Entity<ALQ_T_Alquiler>()
                .Property(e => e.Matricula)
                .IsUnicode(false);

            modelBuilder.Entity<ALQ_T_Alquiler>()
                .Property(e => e.PrecioDiaEfectuado)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ALQ_T_Cliente>()
                .Property(e => e.DNICliente)
                .IsUnicode(false);

            modelBuilder.Entity<ALQ_T_Cliente>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<ALQ_T_Cliente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ALQ_T_Cliente>()
                .Property(e => e.DatosCliente)
                .IsUnicode(false);

            modelBuilder.Entity<ALQ_T_Cliente>()
                .HasMany(e => e.ALQ_T_Alquiler)
                .WithRequired(e => e.ALQ_T_Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALQ_T_Coche>()
                .Property(e => e.Matricula)
                .IsUnicode(false);

            modelBuilder.Entity<ALQ_T_Coche>()
                .Property(e => e.DescripcionEstado)
                .IsUnicode(false);

            modelBuilder.Entity<ALQ_T_Coche>()
                .HasMany(e => e.ALQ_T_Alquiler)
                .WithRequired(e => e.ALQ_T_Coche)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ALQ_T_tipoCoche>()
                .Property(e => e.DescripcionTipo)
                .IsUnicode(false);

            modelBuilder.Entity<ALQ_T_tipoCoche>()
                .Property(e => e.PrecioDia)
                .HasPrecision(10, 2);
        }
    }
}
