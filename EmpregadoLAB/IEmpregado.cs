using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpregadoLAB
{
    public interface IEmpregado
    {
        double salario();
        int anosDeCasa(int anoCorrente);
    }
}
