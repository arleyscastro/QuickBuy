using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("VarChar");

            builder.Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnType("VarChar");

            builder.Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnType("VarChar");

            builder.Property(p => p.DataPedido)
                .IsRequired();

            builder.Property(p => p.DataPrevisaoEntrega)
                .IsRequired();

            builder.Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("Char");

            builder.Property(p => p.FormaPagamentoId)
                .IsRequired();
        }
    }
}