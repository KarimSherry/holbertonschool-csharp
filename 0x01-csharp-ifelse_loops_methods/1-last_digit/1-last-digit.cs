using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
	    int a = number %10;
        if (a == 0)
            Console.WriteLine("the last digit of {0} is {1} and is 0", number, a);
        else if (a > 5)
            Console.WriteLine("the last digit of {0} is {1} and is greater than 5", number, a);
        else if (a < 6 && a !=0)
            Console.WriteLine("the last digit of {0} is {1} and is less than 6 and not 0", number, a);
    }
}