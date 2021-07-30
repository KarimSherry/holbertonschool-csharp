using System;

    class Program
    {
        public static List<int> CreatePrint(int size)
        {
            if(size<0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            else
            {
                var list = new list<int>(size);
                for(var i=0;i<list.Length;i++)
                {
                    list[i]=i;
                }
                return list;
            }
        }
    }
