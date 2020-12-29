using System;

namespace project_euler_problem_6_sum_square_difference.cs
{
    /*The sum of the squares of the first ten natural numbers is, 1^2 + 2^2...10^2 = 385
     *The square of the sum of the first ten natural numbers is, (1+2+....10)^2 = 55^2 = 3025
     *Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 
     *3025-385=2640.
     *Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
     */
    class Program
    {

        static void Main(string[] args)
        {
            int squareOfSum = 0;
            int sumOfSquare = 0;
            int difference = 0;
            
            const int R = 100;

                squareOfSum = R * (R+1) / 2;
            sumOfSquare = (R * (R + 1) * (2 * R + 1)) / 6;
            difference = squareOfSum * squareOfSum - sumOfSquare;
            Console.WriteLine(difference);
        }
    }
}
