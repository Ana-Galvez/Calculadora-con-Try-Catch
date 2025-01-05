using System;


namespace Calculadora_con_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string salir;
            do
            {
                try
                {
                    Console.WriteLine("Ingrese el primer número");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo número");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el signo matemático: + - * /");
                    string signo = Console.ReadLine();

                    switch (signo)
                    {
                        case "+":
                            Console.WriteLine($"El resultado es: {num1 + num2}");
                            break;
                        case "-":
                            Console.WriteLine($"El resultado es: {num1 - num2}");
                            break;
                        case "*":
                            Console.WriteLine($"El resultado es: {num1 * num2}");
                            break;
                        case "/":
                            if(num2 ==0) Console.WriteLine("No se puede dividir por 0");
                            else Console.WriteLine($"El resultado es: {num1 / num2}");
                        break;
                        default:
                            Console.WriteLine("Signo inválido");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }                
                Console.WriteLine("¿Desea hacer otra cuenta? si/no");
                salir=Console.ReadLine().ToLower();
            } while (salir == "si");
            Console.WriteLine("Muchas gracias por usar la calculadora");
        }
    }
}
