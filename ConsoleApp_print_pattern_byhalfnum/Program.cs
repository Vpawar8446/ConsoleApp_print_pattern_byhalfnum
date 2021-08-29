using System;

namespace ConsoleApp_print_pattern_byhalfnum
{
    class PatternNo
    {
        public void pattern(int num)
        {
            for (int i = 0 ; i <=num ; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    
                    Console.Write(+ j);
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                PatternNo obj = new PatternNo();
                Console.Write("Enter the any number : ");
                int n = Convert.ToInt32(Console.ReadLine());
                obj.pattern(n);
        }
    }
}
