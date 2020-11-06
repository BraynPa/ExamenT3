using Microsoft.EntityFrameworkCore;
using N00029793T3.Models.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793T3.Models
{
    public class N00029793Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Ejercicio> Ejercicios { get; set; }
        public DbSet<DetalleRutina> DetalleRutinas { get; set; }
        public DbSet<Rutina> Rutinas { get; set; }


        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseSqlServer("Server=HP-PORTATIL-240\\SQLEXPRES; DataBase=BeamyMusic;Trusted_Connection=True;MultipleActiveResultSets=true");
         }*/
        public N00029793Context(DbContextOptions<N00029793Context> options) : base(options)
        {


        }

        public N00029793Context()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new EjercicioMap());
            modelBuilder.ApplyConfiguration(new DetalleRutinaMap());
            modelBuilder.ApplyConfiguration(new RutinaMap());



        }
    }
}
