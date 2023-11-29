using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            quadrato q1 = new quadrato();

            
            Console.WriteLine("inserisci il lato del quadrato:");
            q1.lato_quadrato=float.Parse(Console.ReadLine());
            Console.WriteLine( "il quadrato ha superfice = {0}", q1.lato_quadrato*q1.lato_quadrato);
            Console.ReadLine();

        }
    }
}
