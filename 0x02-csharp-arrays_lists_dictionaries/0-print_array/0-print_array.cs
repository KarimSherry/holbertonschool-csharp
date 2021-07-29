using System;

namespace _0_print_array
{
    class Array
    {
        static void Main(string[] args)
    {
             public static int[] CreatePrint(int size)
             {
                 if (size < 0)
                 {
                     Console.WriteLine("Size cannot be negative");
                     return null;
                 }
                 else if (size == 0)
                 Console.WriteLine(" ");
                 else
                 {
                    int[] array = new int[size];
                    for(int i=0;i<size;i++)
                    {
                        array[i] = i;
                        Console.Write($"{i} ");
                        Console.WriteLine(" ");
                        Console.WriteLine("Array Length =" + size);
                    }
                    return array;
        
            }
        }
    }
    }
}
