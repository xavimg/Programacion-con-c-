sing System;

namespace PrimeraApliacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora. Introduzca el primer numero ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el operador ");
            string operador = Console.ReadLine();
            Console.WriteLine("Introduzca el segundo operador ");
            int num2 = int.Parse(Console.ReadLine());
            
            void calculadora(){

                if (operador == "+") Console.WriteLine(" El resultado es " + (num1 + num2));
                if (operador == "-") Console.WriteLine(" El resultado es " + (num1 - num2));
                if (operador == "*") Console.WriteLine(" El resultado es " + (num1 * num2));
                if (operador == "/") Console.WriteLine(" El resultado es " + (num1 / num2));

            }
            calculadora();

        }
    }
}
