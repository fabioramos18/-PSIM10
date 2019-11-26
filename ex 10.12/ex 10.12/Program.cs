using System;

namespace ex_10._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int lido;
            string lerTeclado;
            
            do
            {
              
 
            Console.WriteLine("CONVERSÃO ");
            Console.WriteLine("DIGITE 1 DE POLEGADAS PARA CENTIMETROS");
            Console.WriteLine("DIGITE 2 DE CENTIMETROS PARA POLEGADAS ");
            Console.WriteLine("DIGITE 3 DE FAHRENHEIT PARA CENTIGRADOS/CELSUS ");
            Console.WriteLine("DIGITE 4 DE CENTIGRADOS/CELSUS PARA FAHRENHEIT ");
            Console.WriteLine("DIGITE 5 DE JOULES PARA CALORIAS");
            Console.WriteLine("DIGITE 6 DE CALORIAS PARA JOULES ");
            Console.WriteLine("7- Sair.");

            string lerTeclado = Console.ReadLine();
            int.TryParse(lerTeclado, out lido);

                if (e == 1)
                {
                    Console.WriteLine("Digite um número: ");
                    double n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Resultado: {Conversoes.PolCen(n)}");
                }
                else if (e == 2)
                {
                    Console.WriteLine("Digite um número: ");
                    double n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Resultado: {Conversoes.CenPol(n)}");
                }
                else if (e == 3)
                {
                    Console.WriteLine("Digite um número: ");
                    double n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Resultado: {Conversoes.FahCel(n)}");
                }
                else if (e == 4)
                {
                    Console.WriteLine("Digite um número: ");
                    double n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Resultado: {Conversoes.CelFah(n)}");
                }
                else if (e == 5)
                {
                    Console.WriteLine("Digite um número: ");
                    double n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Resultado: {Conversoes.JCal(n)}");
                }
                else if (e == 6)
                {
                    Console.WriteLine("Digite um número: ");
                    double n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Resultado: {Conversoes.CalJ(n)}");
                }




            }
            while (e != 7);
        }
    }
}
        }
    }
}
