using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string h;
            for(i=0; i<99; i++)
            {
                h = i.ToString("X");
                Console.Write("{0} = 0x{1} \n", i, h);
            }
        }
    }
}
