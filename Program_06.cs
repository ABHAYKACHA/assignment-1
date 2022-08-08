/*Write a C# Sharp program to print the output of multiplication of three numbers which will be
entered by the user.
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6*/
using System;

class Program_06
{
    static void Main()
    {
        int a, b;
        Console.WriteLine("enter the number 1 : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the number 2 : ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("the multiplication of 3 digits is : {0}",(a*b));
    }
}