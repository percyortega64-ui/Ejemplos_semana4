using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos_semana4
{
    internal class Program
    {
        static public void ejercicio01()
        {
            double[] notas = { 10.0, 9.0, 15.0, 12.0, 8.0 };
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Nota [" + i + "]=" + notas[i]);
            }   
        }
        static public void ejercicio02()
        { int[] edad = { 19, 20, 18, 21, 22 };
            int S=0;
            for (int i = 0; i < edad.Length; i++)
            {
                S += edad[i];
            }
            Console.WriteLine("la suma es: " + S);
        }
        static public void ejercicio03()
        {
            double[] notas = { 10.0, 9.0, 15.0, 12.0, 8.0,16.0 };
            int c_aprob = 0;
            
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >= 12)
                {
                    c_aprob++;
                }
            }
            Console.WriteLine("la cantidad de Alumnos aprobados es: " + c_aprob);
        }
        static void Main(string[] args)
        {
            
            ejercicio01();
            ejercicio02();
            ejercicio03();
            Console.ReadKey();
        }
    }
}
