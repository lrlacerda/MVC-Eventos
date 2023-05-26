using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoMVCEvento.Model;

namespace ProjetoMVCEvento.View
{
    public class EventoView
    {
        public Evento CriarEvento()
        {
            Console.WriteLine("\n=== Cadastro de Evento ===");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();

            Console.Write("Data (dd/mm/yyyy): ");
            DateTime data;
            DateTime.TryParse(Console.ReadLine(), out data);
            Console.ResetColor();

            return new Evento { Nome = nome, Descricao = descricao, Data = data };
        }

        public void ListarEventos(Evento[] eventos)
        {
            Console.WriteLine("\n=== Lista de Eventos ===\n");
            foreach (var evento in eventos)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Nome: {evento.Nome}");
                Console.WriteLine($"Descrição: {evento.Descricao}");
                Console.WriteLine($"Data: {evento.Data.ToShortDateString()}");
                Console.WriteLine();
                Console.ResetColor();
            }
        }

    }
}