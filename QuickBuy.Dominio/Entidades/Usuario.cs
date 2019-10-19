using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Senha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        ///     
        /// </summary>
        public string SobreNome { get; set; }

        /// <summary>
        /// Usuario pode ter nenhum ou muitos pedidos.
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
