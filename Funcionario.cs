using System;
namespace NovoSal
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Sal { get; private set; }

        public Funcionario(int id, string nome, double sal)
        {
            nome = char.ToUpper(nome[0]) + nome.Substring(1);
            Id = id;
            Nome = nome;
            Sal = sal;
        }

        public double Aumento(double porc)
        {
            Sal = Sal + (Sal * (porc / 100));
            return Sal;
        }

        public override string ToString()
        {
            return $"ID:{Id}\nNome:{Nome}\nSalario:{Sal}\n"; 
        }
    }
}
