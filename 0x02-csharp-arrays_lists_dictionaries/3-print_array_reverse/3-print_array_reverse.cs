using System;

    class Program
    {
        public static void Reverse(int[] array)
        {
            for (var i=array.Length;i>-1;i--)
            Console.WriteLine(array[i]);
        }
    }
