using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentários.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuicao - Fundamentos", OperadorAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},

                // Estruturas de controle                
                {"If - Estruturas de controle", EstruturaIf.Executar},
                {"If/Else - Estruturas de controle", EstruturaIfElse.Executar},
                {"If/Else/If - Estruturas de controle", EstruturaIfElseIf.Executar},
                {"Switch - Estruturas de controle", EstruturaSwitch.Executar},
                {"While - Estruturas de controle", EstruturaWhile.Executar},
                {"Do While - Estruturas de controle", EstruturaDoWhile.Executar},
                {"For - Estruturas de controle", EstruturaFor.Executar},
                {"ForEach - Estruturas de controle", EstruturaForEach.Executar},

                //Classes e metodos
                {"Membros - Classes e metodos", Membros.Executar},
                {"Construtores - Classes e metodos", Construtores.Executar},
                {"Metodos com retorno - Classes e metodos", MetodosComRetorno.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}