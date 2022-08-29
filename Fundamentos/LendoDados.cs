using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.Write("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Seu nome é {nome}, você tem {idade} anos.");
        }
    }
}
