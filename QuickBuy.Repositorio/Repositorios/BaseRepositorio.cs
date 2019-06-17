using System.Collections.Generic;
using System.Linq;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity>:IBaseRepositorio<TEntity> where TEntity: class
    {
        protected readonly QuickByContexto QuickByContexto;

        public BaseRepositorio(QuickByContexto quickByContexto)
        {
            QuickByContexto = quickByContexto;
        }

        public void Dispose()
        {
            QuickByContexto.Dispose();
        }

        public void Adicioar(TEntity entity)
        {
            QuickByContexto.Set<TEntity>().Add(entity);
            QuickByContexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return QuickByContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return QuickByContexto.Set<TEntity>().ToList(); 
        }

        public void Atualizar(TEntity entity)
        {
            QuickByContexto.Set<TEntity>().Update(entity);
            QuickByContexto.SaveChanges();
        }

        public void Remover(TEntity entity)
        {
            QuickByContexto.Remove(entity);
            QuickByContexto.SaveChanges();
        }
    }
}