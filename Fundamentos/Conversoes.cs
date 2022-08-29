using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine($"Nota truncada: {notaTruncada}");

            Console.Write("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInt = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida: {idadeInt}");

            idadeInt = Convert.ToInt32(idadeString);
            Console.WriteLine($"Resultado: {idadeInt}");

            Console.Write("Digite o primeiro numero:");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine($"Resultado: {numero}");

            Console.Write("Digite o segundo numero:");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Resultado: {numero2}");
        }
    }
}
