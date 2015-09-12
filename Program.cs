using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Grade: 10/10 Nice job, I like the extra touch
namespace BVail_3_15App
{
    class Program
    {
        static void Main(string[] args)
        {
            //obtain first & last name
            string fName;
            string lName;
            string FirstAndLast;
            int number1;
            int number2;
            int Sum;
            int Difference;
            int Product;
            int quotient;


            Console.Write("Welcome, Please Enter Your First Name: ");
            fName= Convert.ToString(Console.ReadLine());
            Console.Write("...And Your last Name Please: ");
            lName = Convert.ToString(Console.ReadLine());
            FirstAndLast = (fName +" " + lName);
            Console.Write("Thanks {0}, lets do some math! \n Enter an Integer: ", FirstAndLast);
            //Take first Integer
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}, Enter another Integer: ", FirstAndLast);
            //Take Second Integer
            number2 = Convert.ToInt32(Console.ReadLine());
            
            //Operate the arithmatic
            Sum= number1 + number2;
            Difference= number1 - number2;
            Product= number1 * number2;
            quotient= number1 / number2;
            //String together the Operations using the Integers/Variables
            Console.WriteLine("The integers selected are: {0}, and {1}: ",number1, number2);
            Console.WriteLine("{0} + {1} = {2}", number1, number2,Sum);
            Console.WriteLine("{0} - {1} = {2}", number1, number2, Difference);
            Console.WriteLine("{0} * {1} = {2}", number1, number2,Product);
            Console.WriteLine("{0} / {1} = {2}", number1, number2, quotient);
            Console.Read();

        }
    }
}
