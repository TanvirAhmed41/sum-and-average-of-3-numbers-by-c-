using System;
using System.Diagnostics.CodeAnalysis;

class Test
{
    public static void Main (string[] args){

     /*   int num1,num2,num3,sum;
        double average;
        Console.WriteLine("Enter first number: ");
        num1 =Convert.ToInt32( Console.ReadLine());

        Console.WriteLine("Enter Second number: ");
        num2 = Convert.ToInt32( Console.ReadLine());

        Console.WriteLine("Enter Third number: ");
        num3 = Convert.ToInt32( Console.ReadLine());

        sum = num1 + num2 + num3 ;
        Console.WriteLine($"sum = {sum}");

        average = sum/3;
        Console.WriteLine($"average = {average}");
        */

        double radius;
        double circleArea;

        Console.WriteLine ("Circle Area Calculator");

        Console.Write("Enter the value of Radius: ");
        radius =Convert.ToDouble(Console.ReadLine());

        circleArea = 3.1416 * (radius * radius);
        Console.WriteLine($"circleArea = {circleArea.ToString("F2")}");

}
}


