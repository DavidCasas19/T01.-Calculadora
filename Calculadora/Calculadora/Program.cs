using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mandamos a llamar a los metodos
            Principal op = new Principal();
            op.Bienvenida();
            Console.WriteLine("   ");
            op.Valor();
            Console.WriteLine("   ");
            op.Menu();
         
            
        }
    }
}
