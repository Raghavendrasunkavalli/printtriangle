using System;

namespace printtriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,k;
            Console.Write("Q1 : Enter the number of rows for the traingle:");// User message to input number of rows in a triangle
            string n = Console.ReadLine();// Reading the input from console.
            int inputNumber = Convert.ToInt32(n);// COnverting string format to integer
            for (i=1; i<=inputNumber;i++) // Initializing for loop to create number of rows in a triangle.
            {
                for (j=(inputNumber-1);j>=i;j--) // Initializing for loop to create spaces before the * in a row
                {
                    Console.Write(" "); // Printing white spaces on to the console.
                }
                for (k=1; k<= (2*i-1); k++) // Initializing for loop to print * on to the console.
                {
                    Console.Write("*"); // Printing * on to the console.
                }
                Console.WriteLine();
            }
                
        }
    }
}
