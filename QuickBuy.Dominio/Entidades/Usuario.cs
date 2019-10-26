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
        public virtual ICollection<Pedido> Pedidos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não foi informado");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não foi informada");
        }
    }
}
