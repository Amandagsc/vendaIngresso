

namespace SistemaParaVendaDeIngressos.Ingressos
{
    public class Vip : Ingresso
    {
        public decimal CalculaValorDoIngresso(Evento evento)
        {
            return evento.GetValorUnico() * 1.3m;
        }
    }
}
