using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.Write("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if(numeroSecreto == palpite){
                    numeroEncontrado = true;
                    var corInicial = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write($"Numero encontrado em {tentativas} tentativas");
                    Console.BackgroundColor = corInicial;
                } else if(palpite > numeroSecreto){
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                } else {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                }
            }
        }
    }
}
