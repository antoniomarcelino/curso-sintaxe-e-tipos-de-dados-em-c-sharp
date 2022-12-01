using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_1_sintaxe_e_indentacao.PessoaCopia
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}