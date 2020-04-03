using System;

namespace Exercise_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question - https://www.urionlinejudge.com.br/judge/en/problems/view/1008
            //Write a program that reads an employee's number, his/her worked hours number in a month and the amount he received per hour. Print the employee's number and salary that he/ she will receive at end of the month, with two decimal places.

            //Don’t forget to print the line's end after the result, otherwise you will receive “Presentation Error”.
            //Don’t forget the space before and after the equal signal and after the U$.
            //Input
            //The input file contains 2 integer numbers and 1 value of floating point, representing the number, worked hours amount and the amount the employee receives per worked hour.
            
            //Output
            //Print the number and the employee's salary, according to the given example, with a blank space before and after the equal signal.
            int number_employee, number_hours;
            double value, salary;
            number_employee = int.Parse(Console.ReadLine());
            number_hours = int.Parse(Console.ReadLine());
            value = double.Parse(Console.ReadLine());
            salary = value * number_hours;
            Console.WriteLine("NUMBER = " + number_employee);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2"));
            Console.ReadLine();
        }
    }
}
