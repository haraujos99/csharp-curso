﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadorAtribuicao {
        public static void Executar() {
            int num1 = 10;
            num1 += 10; // num1 = num1 + 10;
            num1 -= 7; // num1 = num1 - 7;
            num1 *= 5; // num1 = num1 * 5;
            num1 /= 2; // num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++;
            b--;

            Console.WriteLine($"{a} {b}");
        }
    }
}
