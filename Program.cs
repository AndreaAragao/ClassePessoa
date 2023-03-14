using System;
using Pessoas01.Entidade;

namespace Pessoas01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa andrea = new Pessoa();
            Pessoa andreaClone = andrea;
            Pessoa douglas = new Pessoa();
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = "Bob";
        }
    }
}
