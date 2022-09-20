using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro() {

        }

        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
    }
    class Construtores {
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Modelo = "Prisma";
            carro1.Fabricante = "Chevrolet";
            carro1.Ano = 2018;

            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            Carro carro2 = new Carro("Gol", "Volkswagem", 2016);

            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            Carro carro3 = new Carro() {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2015
            };

            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}
