using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using Modelo;


namespace AccesoDatos
{
    public class AccesoADatos : DbContext
    {

        public DbSet<Factor> Factor { get; set; }
        public DbSet<Gerente> Gerente { get; set; }
        public DbSet<Proyecto> Proyecto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FactorConfiguracion());
            modelBuilder.Configurations.Add(new GerenteConfiguracion());
            modelBuilder.Configurations.Add(new ProyectoConfiguracion());
        }


    }

    public class FactorConfiguracion : EntityTypeConfiguration<Factor>
    {
        public FactorConfiguracion()
        {
            Property(d => d.Id).IsRequired();
            Property(d => d.Nombre).IsRequired();
            Property(d => d.Ponderacion).HasMaxLength(500);
            Property(d => d.Habilitado).HasColumnType("bit");
        }
    }

    public class GerenteConfiguracion : EntityTypeConfiguration<Gerente>
    {
        public GerenteConfiguracion()
        {
            Property(l => l.Nombre).IsRequired().HasMaxLength(200);
            Property(l => l.Apellido).IsRequired().HasMaxLength(200);
            Property(l => l.DNI).IsRequired().HasMaxLength(200);
            Property(l => l.Usuario).IsRequired().HasMaxLength(200);
            Property(l => l.Contraseña).IsRequired().HasMaxLength(200);
        }
    }

    public class ProyectoConfiguracion : EntityTypeConfiguration<Proyecto>
    {
        public ProyectoConfiguracion()
        {
            Property(p => p.Nombre).IsRequired().HasMaxLength(200);
            Property(p => p.Descripcion).IsRequired().HasMaxLength(200);
            Property(p => p.Id).IsRequired();
            Property(p => p.Fecha).IsRequired().HasColumnType("DateTime");

        }
    }
}
