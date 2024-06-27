using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        // Task 1
        int[] array1 = new int[10];

        array1[0] = 0;
        array1[1] = 1;

        for (int i = 2; i < array1.Length; i++)
        {
            array1[i] = array1[i - 1] + array1[i - 2];
        }

        Console.WriteLine("Fibonacci array:");
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine(array1[i]);
        }

        // Task 2        
        int maxIndex = 20;
        int[] array2 = new int[maxIndex];

        for (int i = 0; i < maxIndex; i++)
        {
            array2[i] = i + 1;
        }

        Console.WriteLine("\nEven numbers from Task2 array:");
        for (int i = 0; i < maxIndex; i++)
        {
            if (array2[i] % 2 == 0)
            {
                Console.WriteLine(array2[i]);
            }                
        }

        // Task 3
        int firstNumber = 1;
        int lastNumber = 5;

        Console.WriteLine($"\nMultiplication table from {firstNumber} to {lastNumber}:");
        for (int i = 0; i < lastNumber; i++)
        {
            for (int j = 0; j < lastNumber; j++)
            {
                Console.Write($"{i+1}*{j+1}={(i+1)*(j+1)}   ");
            }
            Console.Write("\n");
        }

        // Task 4
        string userInput;
        string password = "qwerty";

        Console.WriteLine("\nEnter password:");
        do
        {
            userInput = Console.ReadLine();
            if (userInput != password)
            {
                Console.WriteLine("Wrong password. Try again.");
            }
        } while (userInput != password);
        Console.WriteLine("Access granted");
    }
}