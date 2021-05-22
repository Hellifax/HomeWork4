using System;

namespace HW4._3
{
    class Program
    {

        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число месяца:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MySeason(a));
        }
        static string MySeason(int a)
        {
            
            if (a == 1 || a == 2 || a == 12)
            {                
                return Seasons.Winter.ToString();                
            }
            if (a == 3 || a == 4 || a == 5)
            {
                return Seasons.Spring.ToString();
            }
            if (a == 6 || a == 7 || a == 8)
            {
                return Seasons.Summer.ToString();
            }
            if (a == 9 || a == 10 || a == 11)
            {
                return Seasons.Autumn.ToString();
            }
            else
            {
                return ("Ошибка: введите число от 1 до 12");              
            }

        }
    }
}
