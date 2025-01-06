using System;
using System.Diagnostics.CodeAnalysis;

class Test
{
    public static void Main (string[] args){

        int num1,num2,num3,sum;
        double average;
        Console.WriteLine("Enter First number: ");
        num1 =Convert.ToInt32( Console.ReadLine());

        Console.WriteLine("Enter Second number: ");
        num2 = Convert.ToInt32( Console.ReadLine());

        Console.WriteLine("Enter Third number: ");
        num3 = Convert.ToInt32( Console.ReadLine());

        sum = num1 + num2 + num3;
        Console.WriteLine($"sum = {sum}");

        average = sum/3;
        Console.WriteLine($"average = {average}");
        

}
}


