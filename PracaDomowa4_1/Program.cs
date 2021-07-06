using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj proszę liczbę: ");
                int number = GetNumber();

                int evenNumber = number % 2;


                if (evenNumber == 0)
                {
                    Console.WriteLine("Liczba jest parzysta");
                }

                else if (evenNumber == 1)
                {
                    Console.WriteLine("Liczba jest nieparzysta");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }



        }
        private static int GetNumber()
        {
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                throw new Exception("Podana wartość jest nieprawidłowa!");
            }
            return number;
        }
    }
}
