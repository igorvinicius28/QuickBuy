using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<T> : IDisposable where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        void Adicionar(T obj);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T ObterPorId(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> ObterTodos();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        void Atualizar(T obj);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        void Remover(T obj);

    }
}
