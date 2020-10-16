using CP.Api.Usuario.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP.Api.Usuario
{
    public class ApplicationContext: DbContext
    {


        public DbSet<Usuarios> Usuarios { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext>options) : base(options)
        {

        }

        public ApplicationContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuarios>().HasKey(c => c.Cpf);
            
        }

    }
}
