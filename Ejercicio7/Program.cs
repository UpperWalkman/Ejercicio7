using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de platos rotos");
            int montoDescaontar = 0;
            string TotalPlatosRotos = Console.ReadLine();
            int platosRotos = int.Parse(TotalPlatosRotos);
            /*string[,] matriz = new string[,] { { "A1", "10" }, { "A2", "20"}, { "A3", "10"}, { "A4", "58"}, 
                                               { "B1", "20" }, { "B2", "20"}, { "B3", "39"}, { "B4", "60"}, 
                                               { "C1", "30" }, { "C2", "58"}, { "C3", "40"}, { "C4", "60"}, 
                                               { "D1", "57" }, { "D2", "60"}, { "D3", "75"}, { "D4", "60"} };*/

            string[,] matriz = new string[,] { { "A1", "10" }, { "A2", "20"}, { "A3", "10"}, { "A4", "58"},
                                               { "B1", "20" }, { "B2", "20"}, { "B3", "39"}, { "B4", "50"},
                                               { "C1", "30" }, { "C2", "58"}, { "C3", "40"}, { "C4", "50"},
                                               { "D1", "57" }, { "D2", "60"}, { "D3", "75"}, { "D4", "50"} };

            Console.WriteLine("Defina la posicion de platos que se rompieron de A1 - D4");
            for (int i = 0; i < platosRotos; i++)
            {
                string posicionPlato = Console.ReadLine().ToUpper();
                for (int j = 0; j < matriz.GetLength(0); j++) {
                    if (matriz[j, 0] == posicionPlato)
                    {
                        montoDescaontar += int.Parse(matriz[j, 1]);
                        break;
                    }
                }
            }

            Console.WriteLine($"Total descontado: {montoDescaontar}");
        }
    }
}
