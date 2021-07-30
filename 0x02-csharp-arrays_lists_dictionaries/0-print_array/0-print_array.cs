using System;

namespace _0_print_array
{
    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            else
            {
                int[] array = new int[size];
                if (size == 0)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    for(int i=0;i<size;i++)
                    {
                        array[i] = i;
                        Console.Write($"{i} ");  
                    }
                }
                return array;
            }
        }
        
    }
}
