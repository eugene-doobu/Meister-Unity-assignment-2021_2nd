using System;
using System.Collections.Generic;

namespace _2480
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            Listint numbers = new Listint();
            int c2 = 0;  Count=2 전용 변수
            foreach (var str in input)
            {
                int num = int.Parse(str);
                 중복검사
                if (!numbers.Contains(num))
                    numbers.Add(num);
                else
                    c2 = num;
            }
            numbers.Sort();

            if(numbers.Count == 1)
                Console.WriteLine(10000 + numbers[0]  1000);
            else if (numbers.Count == 2)
                Console.WriteLine(1000 + c2  100);
            else
                Console.WriteLine(numbers[2]  100);
        }
    }
}