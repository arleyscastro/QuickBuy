using QuickBuy.Dominio.Enumeradores;
using System;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataPedido { get; set; }
        public bool EhBoleto
        {
            get
            {
                return Id == (int)TipoFormaPagamentoEnum.Boleto;
            }
            set { Id = 0; }
        }
        public bool Ehcartao
        {
            get
            {
                return Id == (int)TipoFormaPagamentoEnum.Cartao;
            }
            set { Id = 0; }
        }
        public bool EhDeposito
        {
            get
            {
                return Id == (int)TipoFormaPagamentoEnum.Deposito;
            }
            set { Id = 0; }
        }
        public bool EhNaoDefinido
        {
            get
            {
                return Id == (int)TipoFormaPagamentoEnum.NaoDefinido;
            }
            set { Id = 0; }
        }
    }
}
