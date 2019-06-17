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
                .HasMaxLength(10);

            builder.Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(80);

            builder.Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(p => p.DataPedido)
                .IsRequired();

            builder.Property(p => p.DataPrevisaoEntrega)
                .IsRequired();

            builder.Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.FormaPagamentoId)
                .IsRequired();

            //pode ser opcional, porque definimos o relacionamento na classe usuario que e 1 usuario para muitos pedidos
            builder.HasOne(p => p.Usuario);
        }
    }
}