using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Console.WriteLine("INGRESA UNA CADENA DE BÚSQUEDA");

            //string cadenaBusqueda = Console.ReadLine();
            ////string  iso= textNormalize(cadenaBusqueda);
            ////string busquedaSInTilde = palabrasSinTildes(cadenaBusqueda);
            //string SinTilde = textoSinTilde(cadenaBusqueda);
            //var x = string.Compare(cadenaBusqueda, SinTilde, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace);

            ////string sinTildes = StringExtensions.SinTildes(cadenaBusqueda);
            ////Console.WriteLine("Ejemplo 1 " + busquedaSInTilde);
            ////Console.ReadLine();
            ////Console.WriteLine("Ejemplo 2"+ SinTilde);
            //Console.WriteLine("Ejemplo iso"+ x);
            ////Console.ReadLine();
            //Console.WriteLine("Ejemplo 3" + sinTildes);


            string s1 = "Cultivo de uñas y manos";
            string s2 = "Cultivo de unas y manos";
            if (String.Compare(s1, s2, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase) == 0)
            {
                Console.WriteLine("texto s1 = " + s1 + "\n" + "texto s2 = " + s2);
            }
           
            else
            {
                Console.WriteLine("texto s1 = " + s1 + "\n" + "texto s2 = " + s2);
            }

            //ENTRADA POR TECLADO
            //Console.WriteLine("Escribe tu nombre completo: ");
            //string nombre = Console.ReadLine();

            //Console.WriteLine($"Tu nombre es {nombre}");
            //int a = 3;
            //int b = 6;
            //if (a < b)
            //{
            //    Console.WriteLine("a es menor  que b");
            //}
            //else
            //{
            //    Console.WriteLine("b es mayor que a");
            //}
            //string mes = "Junio";
            //switch (mes)
            //{
            //    case "enero":
            //        Console.WriteLine("enero tiene 31 dias");
            //        break;
            //    case "febrero":
            //        Console.WriteLine("febrero tiene 28 dias");
            //        break;
            //    default:
            //        Console.WriteLine("mes no encontrado");
            //        break;
            //}
            //int contador = 0;
            //while (contador < 10)
            //{
            //    Console.WriteLine("Iteración número " + contador);
            //    contador++;
            //}






            //List<int> numeros = new List<int>{ 1, 2, 3, 2, 1, 5 };

            //var suma = numeros.Where(x=> x ==1);
            //foreach (var item in suma)
            //{
            //    Console.WriteLine("El numero seleccionado es " + item);
            //}

            //int a = 3;
            //int b = 2;


            //int c = b += a;
            //Console.WriteLine("La suma de los nunmeros es : " + c);

            //int a = 10;
            //int b = 8;
            //if (a > b)
            //{
            //    Console.WriteLine("El numero es " + b);
            //}
            //else
            //{
            //    Console.WriteLine("El numero es " + a);
            //}
            //int[] nums = { 1, -2, -3, 5 };
            //int[] nums = { 9, 1, 2, 5, 4, 3 };
            //var itAvg = from n in nums
            //                //orderby n descending
            //                //select n * 4 / 2;
            //            let x = nums.Average()
            //            where n < x
            //            select n;



            //foreach (int i in itAvg)
            //foreach (var i in itAvg)
            //{
            //    //Console.WriteLine(i + " ");
            //    Console.WriteLine(i );

            //}

            //Func<float, float> result;


            //decimal _Total = 1234.56M;
            //Console.WriteLine("{0:C}", _Total);
            //Administrador dan = (Administrador)(new Empleado());

            //Console.WriteLine(Sumar(3.34M,2.34M));
            //float _value = 3.4028235F;
            //int _result = (int)_value;
            //Console.WriteLine(_result);

            //Administrador _admin = new Administrador();
            //_admin.
            //int I = 10;

            //object Iobject = I;
            //Console.WriteLine(Iobject);



            //int myVar = 0;
            //int value = 0;
            //Console.WriteLine( "Miercoles es igual a : "+ _Days.miercoles);

            //do
            //{
            //    Console.WriteLine(value );
            //    break;
            //} while (value > 10);

            //List<int> listInt = new List<int>() { 1, 2, 3, 4 };

            //    foreach (int item in listInt)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    for (int i = 0; i < listInt.Count; i++)
            //    {
            //        Console.WriteLine(i);
            //    }


            Console.WriteLine("Preciona cualquier tecla para salir");
            Console.ReadKey();
        }
        //        enum _Days
        //        {
        //            Lunes = 1, martes, miercoles, jueves, viernes, sabado, domingo

        //        };
        //        private static dynamic Sumar(dynamic operando1, dynamic
        //operando2)
        //        {
        //            var resultado = operando1 + operando2;

        //            return resultado;
        //        }
        public static string palabrasSinTildes(string palabaConTildes )
        {

            string palabaSinTildes = Regex.Replace(palabaConTildes.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");
            return palabaSinTildes;
        }
        public static string textoSinTilde(string texto)
        {
           return texto.Replace('á', 'a').Replace('é', 'e').Replace('í', 'i').
                     Replace('ó', 'o').Replace('ú', 'u');
        }
        public static string textNormalize(string texto)
        {
            //string accentedStr;
            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(texto);
            string asciiStr = System.Text.Encoding.UTF8.GetString(tempBytes);
            return asciiStr;
        }
    
    }
    public static class StringExtensions
    {
        public static string SinTildes(this string texto) =>
            new String(
                texto.Normalize(NormalizationForm.FormD)
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                .ToArray()
            )
            .Normalize(NormalizationForm.FormC);
    }
   

}
