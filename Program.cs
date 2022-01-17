/*Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.
Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.
Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.*/
using System;
using System.Collections.Generic;

namespace AjusteSalarioComListas
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe o total de funcionarios:");
            int n = int.Parse(Console.ReadLine());

            Funcionario a;

            List<object> listaFuncionarios = new List<object>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Informe o id do {i + 1} funcionario:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine($"Informe o nome do {i + 1} funcionario:");
                string nome = Console.ReadLine();
                Console.WriteLine($"Informe o salario do {i + 1} funcionario:");
                double sal = double.Parse(Console.ReadLine());

            }
        }
    }
}