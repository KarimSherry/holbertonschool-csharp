﻿using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i=0; i<99; i++)
            Console.Write("{0}, ", i.ToString("00"));
            Console.Write("99 \n");
        }
    }
}
