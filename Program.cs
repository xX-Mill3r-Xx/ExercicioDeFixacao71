using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioDeFixacao71
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int qteQuartos = int.Parse(Console.ReadLine());
            Inquilinos[] inq = new Inquilinos[qteQuartos];
            Console.WriteLine($"Informe os dados dos {qteQuartos} Inquilinos:");
            for(int i = 0; i < qteQuartos; i++)
            {
                Console.WriteLine($"Rent #{i+1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                inq[i] = new Inquilinos { Name = name, Email = email, Room = room };
            }

            Console.WriteLine("Informações dos inquilinos: ");

            Console.ReadLine();
        }
    }
}
