using GestaoContabil.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoContabil.Data.Mappings
{
    public class DespesaMapping : IEntityTypeConfiguration<Despesa>
    {
        public void Configure(EntityTypeBuilder<Despesa> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Descricao)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(f => f.Valor)
                .IsRequired();

            builder.Property(f => f.Data)
               .IsRequired();

            builder.Property(f => f.Pago)
               .HasColumnType("boolean")
               .IsRequired();


            builder.ToTable("Despesas");
        }
    }
}
