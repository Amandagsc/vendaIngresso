using SistemaParaVendaDeIngressos.Ingressos;
using System;
using System.Collections.Generic;

namespace SistemaParaVendaDeIngressos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ingresso = new Ingresso();
            ingresso.SetNome("Amanda");
            ingresso.SetCpf("222.935.520-12");

            var vip = new Vip();
            ingresso.SetNome("Amanda");
            ingresso.SetCpf("222.935.520-12");

            Evento evento = new Evento();
            evento.SetNomeEvento("Show");
            evento.SetData(Convert.ToDateTime("08-10-2022"));
            evento.SetCapacidadeMaxima(2);
            Console.WriteLine();

            var lista = new List<Ingresso>();
            

        }
    }
}
