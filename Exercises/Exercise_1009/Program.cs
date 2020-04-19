using System;

namespace Exercise_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question - https://www.urionlinejudge.com.br/judge/en/problems/view/1009
            //Make a program that reads a seller's name, his/her fixed salary and the sale's total made by himself / herself in the month(in money). Considering that this seller receives 15 % over all products sold, write the final salary(total) of this seller at the end of the month , with two decimal places.

            //-Don’t forget to print the line's end after the result, otherwise you will receive “Presentation Error”.

            //- Don’t forget the blank spaces.

            //Input
            //The input file contains a text(employee's first name), and two double precision values, that are the seller's salary and the total value sold by him / her.

            //Output
            //Print the seller's total salary, according to the given example.

            string name;
            double salary, sales;
            name = Console.ReadLine();
            salary = double.Parse(Console.ReadLine());
            sales = double.Parse(Console.ReadLine());
            double result = salary + (sales * 0.15);
            Console.WriteLine("TOTAL = R$ " + result.ToString("F2"));
            Console.ReadLine();
        }
    }
}
