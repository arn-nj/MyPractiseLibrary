using System;



class Program
{
    static void Main()
    {
        string withdrawPlustotal = Console.ReadLine();
        var amounts = withdrawPlustotal.Split(' ');
        int a = int.Parse(amounts[0]);
        double b = double.Parse(amounts[1]);

        if ((a % 5 != 0) || (b - a < 0.5))
            Console.WriteLine("{0:F2}", b);
        else
        {
            b = (b - a - 0.5);
            Console.WriteLine("{0:F2}", b);
        }


    }
}

