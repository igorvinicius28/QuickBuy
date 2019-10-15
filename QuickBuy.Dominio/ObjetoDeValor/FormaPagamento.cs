using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool EhBoleto 
        {
            get { return Id == (int) TipoFormaPagamentoEnum.Boleto; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool EhCartao
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool NaoFoiDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }


    }
}
