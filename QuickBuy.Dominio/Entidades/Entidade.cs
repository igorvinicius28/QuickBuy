using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        /// <summary>
        /// 
        /// </summary>
        private List<string> _mensagensValidacao{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        private List<string> mensagemValidacao 
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        /// <summary>
        /// 
        /// </summary>
        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem"></param>
        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }

        /// <summary>
        /// 
        /// </summary>
        public abstract void Validate();

        protected bool EhValido
        {
            get{ return !mensagemValidacao.Any(); }
        }
    }
}
