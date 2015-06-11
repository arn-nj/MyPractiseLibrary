using System;

    class Program
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split(' ');           
            int count =0;
            for(int i = int.Parse(inputs[0]); i>0;i--)
             if(int.Parse(Console.ReadLine()) % int.Parse(inputs[1]) ==0) count++;
            Console.WriteLine(count);
        }
    }

