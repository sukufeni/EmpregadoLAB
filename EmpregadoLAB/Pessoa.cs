using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpregadoLAB
{
    abstract class Pessoa
    {
        protected string Nome;
        
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        public abstract string lerNome();

    }
}
