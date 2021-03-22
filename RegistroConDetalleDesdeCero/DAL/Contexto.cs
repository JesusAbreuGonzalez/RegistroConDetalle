using Microsoft.EntityFrameworkCore;
using RegistroConDetalleDesdeCero.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroConDetalleDesdeCero.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA/GestionUsuarios.Db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permisos>().HasData(
                new Permisos() { PermisoId = 1, Descripcion = "Descuenta" },
                new Permisos() { PermisoId = 2, Descripcion = "Vende" },
                new Permisos() { PermisoId = 3, Descripcion = "Cobra" }
            );
        }
    }
}
