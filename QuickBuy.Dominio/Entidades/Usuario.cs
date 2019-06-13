using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        /// <summary>
        /// Ususario pode ter nenhum ou muntos pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensDeValidacao();

            if (string.IsNullOrEmpty(Nome))
                AdicionalCritica("ERRO: Informe um nome");

            if (string.IsNullOrEmpty(Email))
                AdicionalCritica("ERRO: Informe um E-mail");
        }
    }
}
