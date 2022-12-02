using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите координату x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату y: ");
                double y = Convert.ToDouble(Console.ReadLine());
                if ((y < 12) && (y > Math.Abs(x))) Console.WriteLine("Да");
                else if ((y > 12) || (y < Math.Abs(x))) Console.WriteLine("Нет");
                else Console.WriteLine("На границе");
            }
            catch
            {
                Console.WriteLine("Некорректный ввод данных");
            }
            Console.ReadKey();

        }
    }
}
