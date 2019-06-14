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
        }
        public bool Ehcartao
        {
            get
            {
                return Id == (int)TipoFormaPagamentoEnum.Cartao;
            }
        }
        public bool EhDeposito
        {
            get
            {
                return Id == (int)TipoFormaPagamentoEnum.Deposito;
            }
        }
        public bool EhNaoDefinido
        {
            get
            {
                return Id == (int)TipoFormaPagamentoEnum.NaoDefinido;
            }
        }
    }
}
