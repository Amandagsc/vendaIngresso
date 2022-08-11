using System;

namespace SistemaParaVendaDeIngressos
{
    public class Ingresso
    {
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private Evento EventoRelacionado { get; set; }
        
        public string GetNome()
        {
            return Nome;
        }

        public string GetCpf()
        {
            return Cpf;
        }
        public string SetNome(string valor)
        {
            return this.Nome = valor;
        }

        public string SetCpf(string valor)
        {
            return this.Cpf = valor;
        }

        public Evento GetEvento(Evento valor)
        {
            return this.EventoRelacionado = valor;
        }

        public void SetEvento(Evento valor)
        {
             this.EventoRelacionado = valor;
        }


        public decimal CalculaValorDoIngresso(Evento evento)
        {
            return evento.GetValorUnico();
        }

        public void MostrarResumo(Ingresso nomeIngresso, Ingresso cpf, Evento nomeEvento, Evento data)
        {
            nomeIngresso.SetNome("");
            cpf.SetCpf("");
            nomeEvento.SetNomeEvento("");
            data.SetData(Convert.ToDateTime(""));
           
        }
        public decimal ImprimirValor(Evento evento)
        {
            return evento.SetValorUnico();
        }

        public decimal CalculaValorDoIngresso(Evento evento)
        {
            return evento.GetValorUnico();
        }
    }
}
