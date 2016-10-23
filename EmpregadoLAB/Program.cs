using System;

namespace EmpregadoLAB
{
    class Program
    {
        EmpregadoLAB e = new Empregado();

        static void Main(string[] args)
        {
            

            Console.WriteLine("o nome é: "+e.lerNome());

        }
    }
}
