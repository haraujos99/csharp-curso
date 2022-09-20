﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaFor {
        public static void Executar() {
            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();

            int.TryParse(entrada, out int tamanhoTurma);

            for( int i = 1; i <= tamanhoTurma; i++) {
                Console.Write($"Digite a nota do aluno {i}: ");
                entrada = Console.ReadLine();

                double.TryParse(entrada, out double notaAtual);
                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine($"A media da turma e: {media}");
        }
    }
}
