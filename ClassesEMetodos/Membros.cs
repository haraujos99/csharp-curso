using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa cicrano = new Pessoa();

            cicrano.Nome = "Henrique";
            cicrano.Idade = 23;

            Console.WriteLine(cicrano.Apresentar());

            cicrano.ApresentarNoConsole();
        }
    }
}
