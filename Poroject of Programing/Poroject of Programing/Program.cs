using System;

class Program
{
    static void Main(string[] args)
    {
        // تعریف آرایه نمونه
        int[] array = { 1, 2, 3, 4, 5, 6, 7 };

        // چاپ آرایه اولیه
        Console.WriteLine("first array:");
        PrintArray(array);

        // دریافت ورودی از کاربر
        Console.Write("rotating (left or right): ");
        string direction = Console.ReadLine().ToLower();

        Console.Write("number of rotating: ");
        int rotations = int.Parse(Console.ReadLine());

        // چرخش آرایه
        if (direction == "left")
        {
            RotateLeft(array, rotations);
        }
        else if (direction == "right")
        {
            RotateRight(array, rotations);
        }
        else
        {
            Console.WriteLine("invalid input!");
            return;
        }

        // چاپ آرایه چرخیده
        Console.WriteLine("array after rotating:");
        PrintArray(array);
    }

    static void RotateLeft(int[] array, int rotations)
    {
        int n = array.Length;
        rotations %= n; // جلوگیری از چرخش اضافی
        ReverseArray(array, 0, rotations - 1);
        ReverseArray(array, rotations, n - 1);
        ReverseArray(array, 0, n - 1);
    }

    static void RotateRight(int[] array, int rotations)
    {
        int n = array.Length;
        rotations %= n; // جلوگیری از چرخش اضافی
        ReverseArray(array, 0, n - rotations - 1);
        ReverseArray(array, n - rotations, n - 1);
        ReverseArray(array, 0, n - 1);
    }

    static void ReverseArray(int[] array, int start, int end)
    {
        while (start < end)
        {
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;
            start++;
            end--;
        }
    }
    
    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}