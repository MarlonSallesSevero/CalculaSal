using System;
namespace CalculaSal
{
    public class Funcionario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Sal { get; set; }

        public Funcionario(int id, string nome, double sal)
        {
            Id = id;
            Nome = nome;
            Sal = sal;
        }
    }
}
