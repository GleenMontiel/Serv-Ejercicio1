using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{

    public delegate void MyDelegate();
    class Program
    {
        static void f1()
        {
            Console.WriteLine("A");
        }
        static void f2()
        {
            Console.WriteLine("B");
        }
        static void f3()
        {
            Console.WriteLine("C");
        }

        public static void MenuGenerator(string[] v, MyDelegate[] d) 
        {
            bool flag = false;
            int opc = 0;
            for (int  i = 0;  i < v.Length;  i++)
            {
                Console.WriteLine("{0}.- {1}", i+1,v[i]);
            }
            Console.WriteLine("{0}.- Exit",v.Length+1);
            do
            {
                try
                {
                    Console.Write("Introduce opción: ");
                    opc = int.Parse(Console.ReadLine());
                    if (opc > 0 && opc <= v.Length)
                    {
                        d[opc-1]();
                        flag = true;
                    }
                    else if (opc == v.Length + 1) 
                    {
                        flag = true;
                        Console.WriteLine("Adios");
                    }
                    else
                    {
                        Console.WriteLine("Introduce un número valido");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Epale overflow");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Epale con el formato");
                }
            } while (!flag);
        }

        static void Main(string[] args)
        {
            MenuGenerator(new string[] { "Op1", "Op2", "Op3" },
 new MyDelegate[] { f1, f2, f3 });
            Console.ReadKey();

        }
    }
}
