using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ProdutoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Quantidade { get; set; }
    }
}
