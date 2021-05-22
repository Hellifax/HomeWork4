using System;

namespace HW4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа:"); 
            SumOfNumbers(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())); 
            //SumOfNumbers(20, 30); // также данные можно передать и таким образом
        }
        static int SumOfNumbers(int a, int b)
        {
            int result = a + b;            
            Console.WriteLine(result);
            return result;

        }


    }
}
