using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIf {
        public static void Executar() {
            double nota;
            string entrada;
            bool bomComportamento = false;

            Console.Write("Digite a nota do aluno:");
            entrada = Console.ReadLine();
            nota = Double.Parse(entrada);

            Console.Write("O aluno teve um bom comportamento(S/N)?");
            entrada = Console.ReadLine();

            bomComportamento = entrada.ToLower() == "s";

            if(nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra!");
            }

        }
    }
}
