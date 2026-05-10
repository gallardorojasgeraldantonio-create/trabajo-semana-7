using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_semana_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejemplo01();
            //ejemplo02();
            //ejemplo03();
            //ejercicio01();
            //ejercicio02();
            
        }
        static void ejemplo01()
            //identificadores de multiplos
        {
            int i = 0;

            Console.Write("ingrese el un numero : ");
            int numero = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(i);
                i = +i + numero;
            }
            while (i < 100);
        }
        static void ejemplo02()
            //sumas acumulativas
        {
            int numero;
            int suma = 0;

            do
            {
                Console.Write("ingrese un numero (0 para terminar)");
                numero = int.Parse(Console.ReadLine());

                suma += numero;
            } while (numero != 0);
            Console.WriteLine($"la suma total de numeros ingresados es de {suma}");
            Console.ReadLine();
        }
        static void ejemplo03()
        {
            string contraseña_C = "admin";
            string contraseña = "";

            while (contraseña != contraseña_C)
            {
                Console.Write("ingrese la contraseña : ");
                contraseña = Console.ReadLine();
                if (contraseña != contraseña_C)
                {
                    Console.WriteLine("contraseña incorrecta");
                }
                else
                {
                    Console.WriteLine("contraseña correcta");
                    break;
                }

            }
        }
        static void ejercicio01()
        {
            int C_numeros;
            int promedio = 0;
            int cantidad = 0;
            double valor_total;
            do
            {
                Console.Write("ingrese el numero a promediar (0 para salir) : ");
                C_numeros = int.Parse(Console.ReadLine());
                if (C_numeros != 0)
                {
                    cantidad++;
                    promedio += C_numeros;
                }
               

            } while (C_numeros != 0);

            valor_total = (double)promedio / cantidad;

            Console.Write($"el promedio total es {valor_total:F2}");

        }
        static void ejercicio02()
        {
            int numeros;
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;
            Console.WriteLine("ingrese numeros enteros (999 para salir)");
            Console.Write("numeros : ");
            numeros = int.Parse(Console.ReadLine());
            
            while (numeros != 999)
            {
                if (numeros > 0)
                {
                    Console.WriteLine("positivo");
                    positivos++;
                }
                else if (numeros < 0)
                {
                    Console.WriteLine("negativos");
                    negativos++;
                }
                else
                {
                    Console.WriteLine("cero");
                    ceros++;
                }
                Console.Write("numeros : ");
                numeros = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("\n resumen de resultados");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("postivos = " + positivos);
            Console.WriteLine("negativos = " + negativos);
            Console.WriteLine("ceros = " + ceros);
            Console.WriteLine("----------------------------------");

            Console.ReadKey();
        }
    }
}

