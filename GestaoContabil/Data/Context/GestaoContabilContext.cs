
using GestaoContabil.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoContabil.Data.Context
{
    public class GestaoContabilContext : DbContext
    {
        public GestaoContabilContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Despesa> Despesas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Receita>().Property(f => f.Valor).HasColumnType("decimal(5,2)");
            modelBuilder.Entity<Despesa>().Property(f => f.Valor).HasColumnType("decimal(5,2)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GestaoContabilContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

    }
}
