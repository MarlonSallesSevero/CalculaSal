using System;
using System.Collections.Generic;
namespace NovoSal
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe quantos Funcionarios quer cadastrar:");
            int n = int.Parse(Console.ReadLine());
            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            int[] idFuncio = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Informe o id do {i + 1} funcionario:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine($"Informe o nome do {i + 1} funcionario:");
                string nome = Console.ReadLine();
                Console.WriteLine($"Informe o salario do {i + 1} funcionario:");
                double sal = double.Parse(Console.ReadLine());
                listaFuncionarios.Add(new Funcionario(id, nome, sal));
            }
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Funcionario [{listaFuncionarios[i].Id}] : {listaFuncionarios[i].Nome} : {listaFuncionarios[i].Sal}");
            }
           for (int q = 0; q != 2; q++) {
                Console.WriteLine("Informe a ID que voce quer alterar:");
                int z = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    if (listaFuncionarios[i].Id == z)
                    {
                        Console.WriteLine("Funcionario Encontrado!!\nInforme a porcentagem a aumentar:");
                        double porc = double.Parse(Console.ReadLine());
                        listaFuncionarios[i].Aumento(porc);
                        Console.WriteLine($"O novo salario do funcionario {listaFuncionarios[i].Nome} passou a ser {listaFuncionarios[i].Sal}$");
                    }
                }
                for (int k = 0; k < n; k++)
                {
                    Console.WriteLine($"Funcionario [{listaFuncionarios[k].Id}] : {listaFuncionarios[k].Nome} : {listaFuncionarios[k].Sal}");
                }
                Console.WriteLine("Quer continuar ?\n1-Sim\n2-Nao");
                int h = int.Parse(Console.ReadLine());
                if (h == 2)
                {
                    Console.WriteLine("Ate Mais!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Ok!");
                }
            }
        }
    }
}
