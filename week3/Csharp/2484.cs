using System;
using System.Collections.Generic;

namespace _2484
{
    class Program
    {
        static int Dice()
        {
            var input = Console.ReadLine().Split(' ');
            List<int> numbers = new List<int>();
            List<int> set = new List<int>();
            foreach (var str in input)
            {
                int num = int.Parse(str);
                if (!numbers.Contains(num))
                    set.Add(num);
                numbers.Add(num);
            }
            numbers.Sort();

            if (set.Count == 1)
                return (50000 + numbers[0] * 5000);
            if (set.Count == 2)
            {
                if(numbers[1] == numbers[2])
                    return 10000 + numbers[1] * 1000;
                else
                    return 2000 + (numbers[1] + numbers[2]) * 500;
            }
            for(int i=0; i<3; ++i)
            {
                if (numbers[i] == numbers[i + 1])
                    return 1000 + numbers[i] * 100;
            }
            return numbers[numbers.Count - 1] * 100;
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            List<int> lst = new List<int>();
            for (int i = 0; i < n; ++i)
                lst.Add(Dice());
            lst.Sort();
            Console.WriteLine(lst[lst.Count - 1]);
        }
    }
}