namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public override void Validate()
        {
            LimparMensagensDeValidacao();

            if (ProdutoId==0)
                AdicionalCritica("ERRO: Informe um produto");
            
            if(Quantidade==0)
                AdicionalCritica("ERRO: Informe a quantidade");

            
        }
    }
}
