

namespace SistemaParaVendaDeIngressos.Ingressos
{
    public class Camarote : Ingresso
    {
        public decimal CalculaValorDoIngresso(Evento evento)
        {
            return evento.GetValorUnico() * 1.6m;
        }
    }
}
