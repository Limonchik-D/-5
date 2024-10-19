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
        //Вычислить квадратное уровнение
        {
            /*  Задание 1
              
                try 
                {
                Console.WriteLine("Введите a:");
                double a = double.Parse(Console.ReadLine()); 
                Console.WriteLine("Введите b:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите c:");
                double c = double.Parse(Console.ReadLine());
                double discriminant = Math.Pow(b,2) - 4 * a * c;
                if (discriminant > 0)
                {
                    Console.WriteLine(" 2 Корня");
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine($"x1= {x1:f2}\t x2={x2:f2}");
                }
                else if (discriminant == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Уравнение имеет один корень (кратный):");
                    Console.WriteLine("$x = {x}");
                }
                else
                    Console.WriteLine("уорней в уровнении не будет");
                Console.Read();
                }

                catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }

            Задание 2
            
            Console.WriteLine("Введите стороны треугольника");

            Console.WriteLine("Введите a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите c:");
            double c = double.Parse(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                // полупериметра
                double p = (a + b + c) / 2;
                // Вычисление площади по формуле Герона
                double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                // Вывод результата
                Console.WriteLine("Площадь треугольника: " + result);
            }
            else
            {
                Console.WriteLine("Треугольника с такими сторонами не существует.");
            }
            Console.ReadLine();
            */
        }
        
    }

}
