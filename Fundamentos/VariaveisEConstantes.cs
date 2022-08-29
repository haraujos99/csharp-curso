using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // Area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é: " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo: " + estaChovendo);

            byte idade = 45;
            // 0 a 256
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            // -256 a 256
            Console.WriteLine("Saldo de gols:" + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);

            int menorValorInt = int.MinValue;
            //Tipo mais usado dos inteiros
            Console.WriteLine("Menor int: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            // Sem sinal, apenas o modulo
            Console.WriteLine("População brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial: " + populacaoMundial);

            float precoComputador = 1299.99f;
            // Tem que por o f, se não é double
            Console.WriteLine("Preço do computador: " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            //Mais usados dos reais
            Console.WriteLine("Valor Apple: " + valorDeMercadoDaApple);

            decimal distEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas: " + distEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);

        }
    }
}
