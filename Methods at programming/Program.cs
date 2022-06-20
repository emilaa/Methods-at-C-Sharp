using System;

namespace Methods_at_programming
{
    class Program
    {
        static void Main(string[] args)
        {
           /*1.*/Number(21);
           /*2.*/EvenNumbersSum(2, 4);
           /*3.*/OddNumbersSum(10, 20);
           /*4.*/int[] number = { 2, 5, 6, 3, 7, 1 };
            ArrOddNumbersSum(number);
            /*5.*/int[] numbers = { 8, 12, 33, 14, 6, 1 };
            ArrEvenNumbersCount(numbers);
            /*6.*/ComplexPrime(3);
        }

        //1.Whether the number N is divisible by 3 and 7.

        static void Number(int n)
        {
            if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine("Divided");
            }
            else
                Console.WriteLine("Not Divided");

        }

        //2.If the numbers N and M are both pairs, the sum of the numners N and M.

        static void EvenNumbersSum(int n, int m)
        {
            if (n % 2 == 0 && m % 2 == 0)
            {
                Console.WriteLine(n + m);
            }
        }

        //3.The sum of odd numbers between N and M.

        static void OddNumbersSum(int n, int m)
        {
            int sum = 0;

            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

        //4.The sum of the odd numbers in the Array.

        static void ArrOddNumbersSum(int[] number)
        {
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 1)
                {
                    sum += number[i];
                }
            }
            Console.WriteLine(sum);
        }

        //5.The count of even numbers in the Array.

        static void ArrEvenNumbersCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        //6.Whether the numbers N and M are prime or complex.

        static void ComplexPrime(int n)
        {
            int count = 0;

            if (count <= 1)
            {
                Console.WriteLine("Add correct number");
            }
            else
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }
                    else
                    {
                        if (count > 2)
                        {
                            Console.WriteLine("Complex");
                        }
                        else
                            Console.WriteLine("Prime");
                    }
                }
        }




    }
}
