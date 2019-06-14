using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(155)
                .HasColumnType("Varchar");

            builder.Property(f => f.DataPedido)
                .IsRequired();

            builder.Property(f => f.EhBoleto)
                .HasColumnType("Bit");

            builder.Property(f => f.EhDeposito)
                .HasColumnType("Bit");

            builder.Property(f => f.EhNaoDefinido)
                .HasColumnType("Bit");

            builder.Property(f => f.Ehcartao)
                .HasColumnType("Bit");

        }
    }
}