using Microsoft.EntityFrameworkCore;
using SebastianSuarez_AP1_P1.Models;

namespace SebastianSuarez_AP1_P1.DAL
{
    public class Contexto : DbContext
    {
       public Contexto(DbContextOptions<Contexto> options)
        : base(options) { }

        public DbSet<Registro> Registro { get; set; }
    }

}

