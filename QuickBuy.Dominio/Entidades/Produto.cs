namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagensDeValidacao();

            if (string.IsNullOrEmpty(Nome))
                AdicionalCritica("ERRO: Informe um nome do produto");
            if (string.IsNullOrEmpty(Descricao))
                AdicionalCritica("ERRO: Informe uma descrição do produto");

            if (Preco <= 0)
                AdicionalCritica("ERRO: Informe um preço");

        }
    }
}
