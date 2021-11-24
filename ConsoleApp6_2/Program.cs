using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.WriteLine("Введите предложение без знаков препинания");
            string str = Console.ReadLine();
            str = str.ToLower();
            str = str.Replace(" ", "");            
            if (str.Length%2 != 0 || str.Length<2)
            {
                Console.WriteLine("Пустая строка или строка с нечётным количеством символов не может быть палиндромом");
                Console.ReadLine();
                Run();
                Environment.Exit(0);
            }
            int half = str.Length / 2;
            string first = str.Substring(0, half);
            string second = str.Substring(half, half);

            for (int i = 0; i< half; i++)
            {
                if (first[i] != second[half-i-1])
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Строка не является палиндромом");

                    Console.ReadLine();
                    Run();
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Строка является палиндромом");

            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }
    }
}