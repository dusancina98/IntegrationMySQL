using Microsoft.EntityFrameworkCore;
using MQuince.IntegrationMySQL.PersistenceEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MQuince.IntegrationMySQL.DataAccess
{
    public class DataContext : DbContext
    {
        public DbSet<PharmacyPersistence> Pharmacies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=localhost;user=root;password=root;database=MQuince");
        }
    }
}
