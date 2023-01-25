/* Author: Sydney Marshall
 * Date: 01/22/2023
 * Description: C# Console Application for calculating letter grades
 */

using System;

namespace Deliverable_2_;
class Program
{
    static void Main(string[] args)
    {
       
    

        try {

            Console.WriteLine("Enter a numeric grade");

            int grade = int.Parse(Console.ReadLine());

            string letter;

            if (grade >= 90)
        {
            letter = "A";
                Console.WriteLine("Your expected letter grade for ISM 4300 is:" + letter);

            }

        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
                Console.WriteLine("Your expected letter grade for ISM 4300 is:" + letter);
            }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
                Console.WriteLine("Your expected letter grade for ISM 4300 is:" + letter);
            }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
                Console.WriteLine("Your expected letter grade for ISM 4300 is:" + letter);
            }
        else if (grade <= 50)
        {
            letter = "F";
                Console.WriteLine("Your expected letter grade for ISM 4300 is:" + letter);
            }

    }
        catch
        {
            Console.WriteLine("Please enter a numeric value from 0 to 100");
        
    }
    }
}

