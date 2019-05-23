using System;

namespace Lesson3_t76
{
    class Program
    {
        public static void Main(string[] args)
        {
            Task76();
        }


        private static void Task76()
        {
            /*
            76. Дано четырехзначное число. Определить:
                а) равна ли сумма двух первых его цифр сумме двух его последних цифр;
                б) кратна ли трем сумма его цифр;
                в) кратно ли четырем произведение его цифр;
                г) кратно ли произведение его цифр числу а.
            */

            Console.Write("Введите 4-х значное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (number < 0)
                    throw new Exception($"Число ({number}) меньше 0 !");

                if (number < 1000 || number > 9999)
                    throw new Exception($"Число ({number}) не является 4х значным!");

                int n1 = number / 1000 % 10,
                    n2 = number / 100 % 10,
                    n3 = number / 10 % 10,
                    n4 = number / 1 % 10;

                Console.WriteLine($"{n1} : {n2} : {n3} : {n4}");

                int sumN1N2 = n1 + n2;
                int sumN3N4 = n3 + n4;

                Console.WriteLine($"\nА) Сумма двух первых его цифр ({sumN1N2}) { ((sumN1N2 == sumN3N4) ? "" : "НЕ ") }равна сумме двух его последних цифр ({sumN3N4});");

                int sumAllNums = n1 + n2 + n3 + n4;
                Console.WriteLine($"Б) Сумма цифр ({sumAllNums}) { ((sumAllNums % 3 == 0) ? "" : "НЕ ") }кратна 3;");

                int multAllNums = n1 * n2 * n3 * n4;
                Console.WriteLine($"В) Произведение цифр ({multAllNums}) { ((multAllNums % 4 == 0) ? "" : "НЕ ") }кратно 4;");

                Console.Write("\nВведите число для проверки кратности: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Г) Произведение цифр ({multAllNums}) { ((multAllNums % a == 0) ? "" : "НЕ ") }кратно {a};");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
