using System;

namespace _02._02._2023HM_MASS
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
             Console.BackgroundColor = ConsoleColor.Green;
            /*int[] Mass = new int[] { 1,2,3,4,5,6 };
            int Count_1 = 0;
            int Count_2 = 0;
            for (int i = 0; i<Mass.Length; i++)
            {
                if (Mass[i]%2==0)
                {
                    Count_1 ++;
                    
                }
                if (Mass[i]%2!=0)
                {
                    Count_2++;
                   
                }
            }
            Console.WriteLine("Количество четных числе" + Count_1);
            Console.WriteLine("Количество не четных числе" + Count_2);*/


            //2
            /*int[] Mass = new int[] { 3, 5, 26, 8, 3, 63 };
            Console.Write("Введите число = ");
            int A = int.Parse(Console.ReadLine());
            int Count = 0;
            for (int i = 0; i<Mass.Length; i++)
            {
                if (Mass[i]<A)
                {
                    Count++;
                }
            }
            Console.WriteLine("Кол-во элиментов которые меньше числа корого ввели = "+Count);*/


            //3
            int[] Mass = new int[15];
            Random R = new Random();
            for (int i = 0; i<Mass.Length; i++)
            {
                Mass[i] = R.Next(0, 20);
                Console.Write("{0,4}", Mass[i]);

            }
            Console.WriteLine();
            Console.WriteLine("Введите три числа");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int Count_1 = 0;
            int Count_2 = 0;
            int Count_3 = 0;
            for (int i = 0; i < Mass.Length; i++)
            {
                if (A == Mass[i])
                {
                    Count_1++;
                }
          
                if (B == Mass[i])
                {
                    Count_2++;
                }
                
                if (C==Mass[i])
                {
                    Count_3++;
                }
                
            }
            Console.WriteLine("Кол-во элиментов первого числа = "+Count_1);
            Console.WriteLine("Кол-во элиментов второго числа = " + Count_2);
            Console.WriteLine("Кол-во элиментов третьего числа = " + Count_3);
        }
    }
}
