using Entities.Models;
using Microsoft.EntityFrameworkCore;
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
        public DbSet<Auto> autoId { get; set; }
        public DbSet<NomeAuto> NomeAuto { get; set; }

        public DbSet<Storico> StoricoAuto { get; set; }

    }
}
