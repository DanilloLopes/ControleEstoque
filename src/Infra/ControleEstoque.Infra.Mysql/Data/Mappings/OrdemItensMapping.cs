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
    internal class OrdemItensMapping : IEntityTypeConfiguration<OrdemItens>
    {
        public void Configure(EntityTypeBuilder<OrdemItens> builder)
        {
            builder.ToTable("OrdemItens");

            builder.HasKey(oi => new { oi.OrdemId, oi.ItemId });

            builder.Property(oi => oi.Quantidade)
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(oi => oi.Ordem)
                .WithMany(o => o.OrdemItens)
                .HasForeignKey(oi => oi.OrdemId);

            builder.HasOne(oi => oi.Item)
                .WithMany(i => i.OrdemItens)
                .HasForeignKey(oi => oi.ItemId);
        }
    }
}
