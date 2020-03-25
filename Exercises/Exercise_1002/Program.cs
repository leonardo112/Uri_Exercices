using System;

namespace Exercise_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            //Qusetion - https://www.urionlinejudge.com.br/judge/en/problems/view/1002
            //The formula to calculate the area of a circumference is defined as A = π.R2.Considering to this problem that π = 3.14159:

            //Calculate the area using the formula given in the problem description.

            //Input
            //The input contains a value of floating point(double precision), that is the variable R.

            //Present the message "A=" followed by the value of the variable, as in the example bellow, with four places after the decimal point. Use all double precision variables.Like all the problems, don't forget to print the end of line after the result, otherwise you will receive "Presentation Error".
            //Output

            //code that the URI encourages
            double A1, n, R1, R2;
            n = 3.14159;
            R1 = double.Parse(Console.ReadLine());
            R2 = R1 * R1;
            A1 = n * R2;
            Console.WriteLine("A=" + A1.ToString("F4"));

            //short code
            double R , π = 3.14159, A ;
            R = double.Parse(Console.ReadLine());
            A = π * (R * 2);
            Console.WriteLine("A= " + A.ToString("F4"));

            //ToString ("F4") is for formatting four decimal places after the comma
        }
    }
}
