using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
       
        while (n != 0)
        {
            int count = 0;
            Char[] Case = Console.ReadLine().ToCharArray();
            foreach (char a in Case)
            {
                if (a == 'B') count += 2;
                if (a == 'A' || a == 'D' || a == 'O' || a == 'P' || a == 'R')
                    count++;
            }
            Console.WriteLine(count);
            n--;
        }
        

    }
}


