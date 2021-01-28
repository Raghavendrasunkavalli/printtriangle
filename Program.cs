using System;

namespace printtriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,k;
            Console.Write("Q1 : Enter the number of rows for the traingle:");
            string n = Console.ReadLine();
            int inputNumber = Convert.ToInt32(n);
            for (i=1; i<=inputNumber;i++)
            {
                for (j=(inputNumber-1);j>=i;j--)
                {
                    Console.Write(" ");
                }
                for (k=1; k<= (2*i-1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
                
        }
    }
}
