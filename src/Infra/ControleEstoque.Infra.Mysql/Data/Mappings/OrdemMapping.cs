using ControleEstoque.DataModels.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Infra.Mysql.Data.Mappings
{
    internal class OrdemMapping : IEntityTypeConfiguration<Ordem>
    {
        public void Configure(EntityTypeBuilder<Ordem> builder)
        {
            builder.ToTable("Ordem");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.DataCadastro)
               .HasColumnType("datetime")
               .IsRequired();

            builder.Property(p => p.NumeroOrdem)
                .HasColumnType("int")
                .IsRequired();

            builder.HasMany(p => p.OrdemItens)
            .WithOne(oi => oi.Ordem)
            .HasForeignKey(oi => oi.OrdemId);
        }
    }
}
