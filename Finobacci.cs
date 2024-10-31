using System;

class FibonacciCheck
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int number = int.Parse(Console.ReadLine());

        if (IsFibonacci(number))
        {
            Console.WriteLine($"O número {number} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {number} NÃO pertence à sequência de Fibonacci.");
        }
    }

    static bool IsFibonacci(int number)
    {
        int a = 0, b = 1;

        while (a < number)
        {
            int next = a + b;
            a = b;
            b = next;
        }

        return a == number;
    }
}
