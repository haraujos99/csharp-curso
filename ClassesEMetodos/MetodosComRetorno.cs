using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadoraComum {
        public double Somar(double a, double b) {
            return a + b;
        }
        public double Subtrair(double a, double b) {
            return a - b;
        }
        public double Multiplicar(double a, double b) {
            return a * b;
        }
        public double Dividir(double a, double b) {
            return a / b;
        }
    }
    class MetodosComRetorno {
        public static void Executar() {
            var calculadora = new CalculadoraComum();

            Console.WriteLine(calculadora.Somar(3 , 5));
            Console.WriteLine(calculadora.Subtrair(3 , 5));
            Console.WriteLine(calculadora.Multiplicar(3 , 5));
            Console.WriteLine(calculadora.Dividir(3 , 5));
        }
    }
}
