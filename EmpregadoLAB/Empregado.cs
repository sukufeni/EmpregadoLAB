using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpregadoLAB
{
   public class Empregado : Pessoa, IEmpregado
    {
        private int anoAdmissao;
        private double salHora;
        private int horas;

        public Empregado(string nome, int anoAdmissao, double salHora, int horas) : base(nome)
        {
            this.anoAdmissao = anoAdmissao;
            this.salHora = salHora;
            this.horas = horas;
        }
        public override string lerNome()
        {
            return Nome;
        }
        public double salario()
        {
            return salHora * horas;
        }

        public int anosDeCasa(int anoCorrente)
        {
            return (anoCorrente - anoAdmissao);
        }
    }
}
