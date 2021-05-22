using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
             Console.WriteLine(GetFullName());
            }
            
        }
        static string GetFullName()
        {
            Console.WriteLine("Enter name:");
            string firtstName = Console.ReadLine();
            Console.WriteLine("Enter surname:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter patronymic:");
            string patronymic = Console.ReadLine();
            return $"{lastName} {firtstName} {patronymic}";
                        

        }

    }
}
