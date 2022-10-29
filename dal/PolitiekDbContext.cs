using Microsoft.EntityFrameworkCore;
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class PolitiekDbContext : DbContext
    {
        public DbSet<Niveau> Niveaus { get; set; }
        public DbSet<Politicus> Politici { get; set; }
        public DbSet<PolitiekePartijNiveau> PolitiekePartijNiveaus { get; set; }
        public DbSet<PolitiekePartij> PolitiekePartijen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Politiek;Trusted_Connection=True;");
        }

       
    }
}