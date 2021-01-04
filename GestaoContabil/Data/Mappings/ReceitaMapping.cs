using GestaoContabil.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace GestaoContabil.Data.Mappings
{
    public class ReceitaMapping : IEntityTypeConfiguration<Receita>
    {
        public void Configure(EntityTypeBuilder<Receita> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Descricao)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(f => f.Valor)
               .IsRequired();

            builder.Property(f => f.Data)
               .IsRequired();

            builder.Property(f => f.Recebido)
               .HasColumnType("boolean")
               .IsRequired();


            builder.ToTable("Receitas");
        }
    }
}
