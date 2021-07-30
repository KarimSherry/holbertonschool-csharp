using System;

    class Array
    {
        public static int elementAt(int[] array, int index)
        {
            int[] a = new int[i];
            int[] array = a;
            if (index < 0 | index>array.Length)
            {
                Console.WriteLine("index is out of range");
                return -1;
            }
            else
            {
                return array[index];
            }
        }
    }
