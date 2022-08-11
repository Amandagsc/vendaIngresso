

namespace SistemaParaVendaDeIngressos.Ingressos
{
    public class Pista : Ingresso
    {
        public decimal CalculaValorDoIngresso(Evento evento)
        {
            return evento.GetValorUnico();
        }
    }
}
