using System;

namespace Exercise_1007
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question https://www.urionlinejudge.com.br/judge/en/problems/view/1007
            //Read four integer values named A, B, C and D. Calculate and print the difference of product A and B by the product of C and D(A * B - C * D).

            //ut
            //input file contains 4 integer values.

            //put
            //nt DIFERENCA(DIFFERENCE in Portuguese) with all the capital letters, according to the following example, with a blank space before and after the equal signal.
            int A, B, C, D,Result;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            Result = (A * B) - (C * D);
            Console.WriteLine("DIFERENCA = " + Result);
        }
    }
}
