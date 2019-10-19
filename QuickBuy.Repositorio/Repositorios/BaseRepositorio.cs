using QuickBuy.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : class
    {
        public BaseRepositorio()
        {

        }

        public void Adicionar(T obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(T obj)
        {
            throw new NotImplementedException();
        }

        public T ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(T obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
