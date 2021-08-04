using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            List<int> List = new List<int>();
            for (var i = 0; i < size; i++)
            {
                List.Add(i);
                Console.Write(i);
                if (i != size - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            return List;
        }
    }
}
