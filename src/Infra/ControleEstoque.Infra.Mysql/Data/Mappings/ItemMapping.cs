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
    internal class ItemMapping : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.CodigoItem)
                .HasColumnType("int")
                .IsRequired();

            builder.HasMany(p => p.OrdemItens)
                .WithOne(oi => oi.Item)
                .HasForeignKey(oi => oi.ItemId);
        }
    }
}
