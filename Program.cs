////int[][] array = new int[3][] { new[] { 1, 2, 3, }, new[] {4, 5, 6}, new[] { 7, 8, 9 } };

////array[2][2] = 888;

////Console.WriteLine(array[2][2]);
////Console.WriteLine(array[0]);
//int[] array1 = new[] {33, 122, 22, 75};
//float[] array2 = new[] { 44.2f, 562.89f, 12.9f, 35.2f };

//var result = Array.CreateInstance(typeof(float), 4);
//result.SetValue(array1[0] * array2[0], 0);
//result.SetValue(array1[0] / array2[0], 1);
//Console.WriteLine(result.GetValue(0));
//Console.WriteLine(result.GetValue(1));

class Program
{
    static void Main()
    {
        // Задание 1:
        int[] fibonacci = new int[8];
        fibonacci[0] = 0;
        fibonacci[1] = 1;
        for (int i = 2; i < fibonacci.Length; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        Console.WriteLine("Fibonacci num:");
        foreach (var num in fibonacci)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Задание 2:
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        Console.WriteLine("Months of the year:");
        foreach (var month in months)
        {
            Console.Write(month + " ");
        }
        Console.WriteLine();

        // Задание 3:
        int[,] matrix = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = (int)Math.Pow(2 + j, i + 1);
            }
        }

        Console.WriteLine("3x3 Matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Задание 4:
        double[][] jaggedArray = new double[3][];
        jaggedArray[0] = new double[5] { 1, 2, 3, 4, 5 };
        jaggedArray[1] = new double[2] { Math.E, Math.PI };
        jaggedArray[2] = new double[4] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) };

        Console.WriteLine("Jagged array:");
        foreach (var array3 in jaggedArray)
        {
            foreach (var num in array3)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // Задача Б
        int[] array = { 1, 2, 3, 4, 5 };
        int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

        // Задание 5:
        Array.Copy(array, 0, array2, array2.Length - 3, 3);

        Console.WriteLine("Array2 after copying first 3 elements from Array:");
        foreach (var num in array2)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Задание 6:
        Array.Resize(ref array, array.Length * 2);

        Console.WriteLine("Array after resizing:");
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

