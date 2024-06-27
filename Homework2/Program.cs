using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // Mission A
        // Task 1
        int[] arrayA1 = new int[8];
        arrayA1[0] = 0;
        arrayA1[1] = 1;
        for (int i = 2; i < arrayA1.Length; i++)
        {
            arrayA1[i] = arrayA1[i - 1] + arrayA1[i - 2];
        }

        Console.WriteLine("Fibonacci arrayA1:");
        for (int i = 0; i < arrayA1.Length; i++)
        {
            Console.WriteLine(arrayA1[i]);
        }

        // Task 2
        string[] arrayA2 = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        Console.WriteLine("\nMonth arrayA2:");
        for (int i = 0; i < arrayA2.Length; i++)
        {
            Console.WriteLine(arrayA2[i]);
        }

        // Task 3
        double[,] arrayA3 = new double[3, 3];

        arrayA3[0, 0] = 2;
        arrayA3[0, 1] = 3;
        arrayA3[0, 2] = 4;

        for (int i = 1; i < arrayA3.GetLength(0); i++)
        {
            for (int j = 0; j < arrayA3.GetLength(1); j++)
            {                
                arrayA3[i, j] = Math.Pow(arrayA3[0, j], i + 1);
            }
        }

        Console.WriteLine("\n2D Array arrayA3:");
        for (int i = 0; i < arrayA3.GetLength(0); i++)
        {
            for (int j = 0; j < arrayA3.GetLength(1); j++)
            {
                Console.WriteLine(arrayA3[i,j]);
            }
        }

        // Task 4
        double[][] arrayA4 = new double[3][]
        {
            new double[5] {1, 2, 3, 4, 5},
            new double[2] {Math.E, Math.PI},
            new double[4] {Math.Log(1), Math.Log(10), Math.Log(100), Math.Log(1000)}
        };

        Console.WriteLine("\nMatrix arrayA4:");
        for (int i = 0; i < arrayA4.GetLength(0); i++)
        {
            Console.WriteLine("Line " + i);
            for (int j = 0; j < arrayA4[i].Length; j++)
            {
                Console.WriteLine(arrayA4[i][j]);
            }
        }

        // Mission B
        int[] arrayB_1 = new int[] { 1, 2, 3, 4, 5 };
        int[] arrayB_2 = new int[] { 7, 8, 9, 10, 11, 12, 13 };
        
        Array.Copy(arrayB_1, arrayB_2, 3);

        Console.WriteLine("\nMission B arrayB_2 after copying:");
        for (int i = 0; i < arrayB_2.Length; i++)
        {
            Console.WriteLine(arrayB_2[i]);
        }

        // Task 6
        Console.WriteLine("\nMission B arrayB_1 before resizing:");
        for (int i = 0; i < arrayB_1.Length; i++)
        {
            Console.WriteLine(arrayB_1[i]);
        }

        Array.Resize(ref arrayB_1, arrayB_1.Length * 2);

        Console.WriteLine("Mission B arrayB_1 after resizing:");
        for (int i = 0; i < arrayB_1.Length; i++)
        {
            Console.WriteLine(arrayB_1[i]);
        }
    }
}