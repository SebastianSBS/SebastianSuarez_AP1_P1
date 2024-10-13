using Microsoft.EntityFrameworkCore;
using SebastianSuarez_AP1_P1.Models;

namespace SebastianSuarez_AP1_P1.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
         : base(options) { }

        public DbSet<Prestamos> Prestamo { get; set; }

        public DbSet<Cobros> Cobros { get; set; }
        public DbSet<CobrosDetalle> CobrosDetalle { get; set; }
        public DbSet<Deudor> Deudor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Deudor>().
            HasData(new List<Deudor>() {
                new Deudor(){DeudorId = 1, DeudorName= "Pedro" },
                new Deudor(){DeudorId= 2, DeudorName = "Angel" },
                new Deudor(){DeudorId= 3, DeudorName= "Diego"}
            });
        } 
    }
       
}



