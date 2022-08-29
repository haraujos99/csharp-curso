using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            bool trabalho1 = false;
            bool trabalho2 = true;

            bool comprouTv50 = trabalho1 && trabalho2;
            Console.WriteLine($"Comrpu a TV de 50? {comprouTv50}");

            bool comprouSorvete = trabalho1 || trabalho2;
            Console.WriteLine($"Comprou sorvete? {comprouSorvete}");

            bool comprouTv32 = trabalho1 ^ trabalho2;
            Console.WriteLine($"Comprou a TV de 32? {comprouTv32}");

            Console.WriteLine($"Mais saudavel? {!comprouSorvete}");
        }
    }
}
