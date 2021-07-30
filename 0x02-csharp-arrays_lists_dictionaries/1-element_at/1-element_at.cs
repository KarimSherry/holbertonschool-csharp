using System;

    class Array
    {
        public static int elementAt(int[] array, int index)
        {
            if (index < 0)
            {
                Console.WriteLine("index is out of range");
                return -1;
            }
            else
            {
                int[] a = new int[index];
                return a[index];
            }
        }
    }
