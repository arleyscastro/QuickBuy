using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios
{
    public class UsuarioRepositorio:BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(QuickByContexto quickByContexto) : base(quickByContexto)
        {
        }
    }
}