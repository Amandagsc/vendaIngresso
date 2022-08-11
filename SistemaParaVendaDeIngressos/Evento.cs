using System;
using System.Collections.Generic;

namespace SistemaParaVendaDeIngressos
{
    public class Evento
    {
        private string Nome;
        private DateTime Data;
        private decimal ValorUnico;
        private int CapacidadeMaxima;
        private List<Ingresso> ListaIngressosVendidos;

        public string GetNome(string valor)
        {
            return this.Nome = valor;
        }

        public DateTime GetData(DateTime valor)
        {
            return Data = valor;
        }

        public decimal GetValorUnico()
        {
            return ValorUnico;
        }

        public void SetValorUnico(decimal valor)
        {
            this.ValorUnico = valor;
        }

        public int GetCapacidadeMaxima()
        {
            return CapacidadeMaxima;
        }

        public void SetCapacidadeMaxima(int valor)
        {
            this.CapacidadeMaxima = valor;
        }

        public string SetNomeEvento(string valor)
        {
            return this.Nome = valor;
        }

        public DateTime SetData(DateTime dateTime)
        {
            return Data;
        }
        public List<Ingresso> GetListaIngressosVendidos(List<Ingresso> valor)
        {
            return ListaIngressosVendidos = valor;
        }

        public void SetListaIngressosVendidos(List<Ingresso> valor)
        {
            this.ListaIngressosVendidos = valor;
        }
    }
}
