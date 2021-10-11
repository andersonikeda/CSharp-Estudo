using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_MVC.Models;


namespace Projeto_MVC.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
          : base(options)
        {
        }
        public DbSet<ProprietarioModel> ProprietarioModel { get; set; }

        public DbSet<AnimalModel> AnimalModel { get; set; }

        public DbSet<EspecieModel> EspecieModel { get; set; }
    }
}
