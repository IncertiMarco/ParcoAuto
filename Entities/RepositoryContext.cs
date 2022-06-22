using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;


namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
        : base(options)
        {
        }

        

        public DbSet<Auto> Auto { get; set; }
        public DbSet<Utenti> Utenti { get; set; }

        public DbSet<Prenotazioni> Prenotazioni { get; set; }


    }
}
