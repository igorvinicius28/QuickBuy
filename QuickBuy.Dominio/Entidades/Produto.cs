﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
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
        public decimal Preco { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
