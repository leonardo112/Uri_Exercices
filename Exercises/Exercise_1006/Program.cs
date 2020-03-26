using System;

namespace Exercise_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question https://www.urionlinejudge.com.br/judge/en/problems/view/1006
            //Read three values(variables A, B and C), which are the three student's grades. Then, calculate the average, considering that grade A has weight 2, grade B has weight 3 and the grade C has weight 5. Consider that each grade can go from 0 to 10.0, always with one decimal place.

            //Input
            //The input file contains 3 values of floating points with one digit after the decimal point.

            //Output
            //Print MEDIA(average in Portuguese) according to the following example, with a blank space before and after the equal signal.

            double A, B, C, Average;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            Average = (A * 2) + (B * 3) + (C * 5);
            Average = Average / 10;
            Console.WriteLine("MEDIA = " + Average.ToString("F1"));
           
        }
    }
}
