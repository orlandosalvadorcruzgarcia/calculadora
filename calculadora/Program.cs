using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            char operador;

            //Enviamos un mensaje de bienvenidad y una descripcion del programas 

            Console.WriteLine("bienvenido a nuestro programa ");
            Console.WriteLine("este programa permite operaciones basicas sobre dos numero");
            Console.WriteLine("-----------------------");

            Console.WriteLine("De el valor del primer numero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("De el valor del segundo numero:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indique la operacion(*,+,-,/");
            operador = char.Parse(Console.ReadLine());
            /*indentificamos el tipo de opracion a ralizar haciendo uso del condicional IF*/

            if (operador == '*')
            {
                Console.WriteLine("la multiplicacion es de: " + (num1 * num2));
            }


            if (operador == '/')
            {
                Console.WriteLine("la divison es de: " + (num1 / num2));
            }

            if (operador == '+')
            {
                Console.WriteLine("la suma es de: " + (num1 + num2));
            }

            if (operador == '-')
            {
                Console.WriteLine("la resta es de: " + (num1 - num2));
            }
            Console.ReadLine();

            switch (operador)
            { case '*':
                   Console.WriteLine("la multiplicacion es de: " + (num1 * num2));
                    break;

                case '/':
                   Console.WriteLine("la division  es de: " + (num1 / num2));
                    break;

                case '+':
                   Console.WriteLine("la suma es de: " + (num1 + num2));
                    break;

                case '-':
                   Console.WriteLine("la resto es de: " + (num1 - num2));
                    break;

                default: Console.WriteLine("No es una opcion validad");
                    break;

            }
            Console.ReadLine();

        }
    }
}
