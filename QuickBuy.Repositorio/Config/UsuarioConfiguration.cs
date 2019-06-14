using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration: IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnType("VarChar");

            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnType("VarChar");

            builder.Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("VarChar");

            builder.Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400)
                .HasColumnType("VarChar");

            //builder.Property(u => u.Pedidos);
        }
    }
}