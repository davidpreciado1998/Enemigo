using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemigo enemigo = new Enemigo();
            Random r = new Random();
            int a = r.Next(1, 4);
            do
            {
                a = r.Next(1, 4);
                if (a == 1)
                {
                    Console.WriteLine("El enemigo " + enemigo.moverse);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (a == 2)
                {
                    Console.WriteLine("El enemigo " + enemigo.disparar);
                    Console.ReadLine();
                    Console.Clear();
                }
                if (a == 3)
                {
                    Console.WriteLine("El enemigo " + enemigo.explotar);
                    Console.WriteLine("puntos: " + enemigo.puntos);
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (a != 3);
        }  
    }
}
