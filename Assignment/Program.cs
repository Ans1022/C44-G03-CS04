using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            // Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region Q2
            //Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive. 
            //Console.WriteLine("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            // Console.WriteLine("positive");
            //}
            #endregion

            #region Q3
            // Write a program that takes 3 integers from the user then prints the max element and the min element
            //Console.WriteLine("Enter first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter third number: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int max = num1;
            //int min = num1;

            //if (num2 > max) max = num2;

            //if (num3 > max) max = num3;

            //if (num2 < min) min = num2;

            //if (num3 < min) min = num3;

            //Console.WriteLine("max element = " + max);
            //Console.WriteLine("min element = " + min);
            #endregion

            #region Q4
            //Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}
            #endregion

            #region Q5
            // Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant). 
            //Console.Write("Enter a character: ");
            //char ch = Convert.ToChar(Console.ReadLine().ToLower());

            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}
            //في بوينت غلط
            #endregion

            #region Q6
            // Write a program that allows the user to insert an integer then print all numbers between 1 to that number. 

            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write(i);

            //    if (i < num)
            //        Console.Write(", ");
            //} 
            #endregion

            #region Q7
            //Write a program that allows the user to insert an integer then  print a multiplication table up to 12.
            //
            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(num * i + " ");
            //}
            #endregion

            #region Q8
            // Write a program that allows to user to insert number then print all even numbers between 1 to this number     Example:     Input: 15  Output: 2 4 6 8 10 12 14 

            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.Write(i + " ");
            //}
            #endregion

            #region Q9
            // Write a program that takes two integers then prints the power.
            // 
            //Console.Write("Enter base number: ");
            //int baseNum = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter exponent: ");
            //int exponent = Convert.ToInt32(Console.ReadLine());

            //int result = 1;

            //for (int i = 1; i <= exponent; i++)
            //{
            //    result = result * baseNum;
            //}

            //Console.WriteLine(result);
            #endregion

            #region Q10
            //Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Console.WriteLine("Enter marks of five subjects:");

            //int total = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    total += Convert.ToInt32(Console.ReadLine());
            //}

            //int average = total / 5;
            //int percentage = average;

            //Console.WriteLine("Total marks = " + total);
            //Console.WriteLine("Average Marks = " + average);
            //Console.WriteLine("Percentage = " + percentage);
            #endregion

            #region Q11
            // Write a program to input the month number and print the number of days in that month.

            //Console.Write("Enter Month Number: ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            //    Console.WriteLine("Days in Month: 31");
            //else if (month == 4 || month == 6 || month == 9 || month == 11)
            //    Console.WriteLine("Days in Month: 30");
            //else if (month == 2)
            //    Console.WriteLine("Days in Month: 29");
            //else
            //    Console.WriteLine("Invalid Month Number");
            #endregion

            #region Q12
            // Write a program to create a Simple Calculator.
            // 
            //Console.Write("Enter first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter operator (+, -, *, /): ");
            //char op = Convert.ToChar(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //double result = 0;

            //if (op == '+')
            //    result = num1 + num2;
            //else if (op == '-')
            //    result = num1 - num2;
            //else if (op == '*')
            //    result = num1 * num2;
            //else if (op == '/')
            //{
            //    if (num2 != 0)
            //        result = num1 / num2;
            //    else
            //    {
            //        Console.WriteLine("Error: Division by zero");
            //        return;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operator");
            //    return;
            //}

            //Console.WriteLine("Result = " + result);

            #endregion

            #region Q13
            // Write a program to allow the user to enter a string and print the REVERSE of it. 

            //Console.Write("Enter a string: ");
            //string text = Console.ReadLine();

            //string reversed = "";

            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    reversed += text[i];
            //}

            //Console.WriteLine("reversed string: " + reversed);
            #endregion

            #region Q14
            // Write a program to allow the user to enter int and print the REVERSED of it.
            // 
            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int reverse = 0;

            //while (num != 0)
            //{
            //    int digit = num % 10;
            //    reverse = reverse * 10 + digit;
            //    num = num / 10;
            //}

            //Console.WriteLine("Reversed number: " + reverse);
            #endregion

            #region Q15
            //rite a program in C# Sharp to find prime numbers within a range of numbers

            //    Console.Write("Input starting number of range: ");
            //    int start = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Input ending number of range: ");
            //    int end = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);

            //    for (int num = start; num <= end; num++)
            //    {
            //        if (IsPrime(num))
            //            Console.Write(num + " ");
            //    }
            //}

            //static bool IsPrime(int number)
            //{
            //    if (number < 2)
            //        return false;

            //    for (int i = 2; i <= number / 2; i++)
            //    {
            //        if (number % i == 0)
            //            return false;
            //    }

            //    return true;
            #endregion

            #region Q16
            //Create a program that asks the user to input three points

            //Console.Write("Enter x1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //double y1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter x2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter x3: ");
            //double x3 = Convert.ToDouble(Console.ReadLine());
            //double y3 = Convert.ToDouble(Console.ReadLine());

            //double area = (x1 * (y2 - y3)) + (x2 * (y3 - y1)) + (x3 * (y1 - y2));

            //if (area == 0)
            //    Console.WriteLine("Same line");
            //else
            //    Console.WriteLine("Not same line");
            #endregion


            #region Q17
            //Within a company, the efficiency of workers is evaluated based on the 

            //Console.Write("Enter time taken to complete the task (in hours): ");
            //double time = Convert.ToDouble(Console.ReadLine());

            //if (time >= 2 && time <= 3)
            //    Console.WriteLine("Highly efficient");
            //else if (time > 3 && time <= 4)
            //    Console.WriteLine("Increase your speed");
            //else if (time > 4 && time <= 5)
            //    Console.WriteLine("Training required to improve speed");
            //else if (time > 5)
            //    Console.WriteLine("Leave the company");
            //else
            //    Console.WriteLine("Invalid time entered");
            #endregion

        }
    }
}




            

      
    
              




    