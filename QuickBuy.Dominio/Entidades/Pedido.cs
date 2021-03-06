﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DataPedido { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int UsuarioId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Usuario Usuario{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DataPrevisaoEntrega { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Estado { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EnderecoCompleto { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int NumeroDoEndereco { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int FormaPagamentoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um item de pedido 
        /// ou muitos itens de pedidos.
        /// </summary>
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public override void Validate()
        {
            LimparMensagensValidacao();
            if (!ItensPedido.Any())
            {
                AdicionarCritica("Item de pedido não pode ficar vazio");
            }

            if (String.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("Campo cep obrigatório");
            }
        }
    }
}
