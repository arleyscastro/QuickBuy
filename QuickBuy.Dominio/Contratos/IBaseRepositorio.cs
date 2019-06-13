﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity>:IDisposable where TEntity : class
    {
        void Adicioar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
    }
}