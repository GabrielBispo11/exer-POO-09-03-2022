using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_4.Models
{
    public class Pessoa
    {
        public string Nome {get; set; }
        public int Idade {get; set; }

        public Pessoa(){

        }
        public Pessoa(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }
        
        // Excluir da lista pessoa maior de idade (olhar Fessor bruno (C#) - exe. similar; Apostila de C#)
        // for (int i = 0; i < P.Count; i++)  .....
        // Encontrar a Jessica;


    }
}