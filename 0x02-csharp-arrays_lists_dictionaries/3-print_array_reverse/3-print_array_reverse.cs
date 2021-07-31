using System;

    class Array
    {
        public static void Reverse(int[] array)
        {
            if(array == null)
            {
                Console.WriteLine("");
            }
            else
            {
            for (var i=array.Length-1;i>-1;i--)
            Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
        }
    }
