//Programmer: Brian Lee
//Date: 04/28/2024

//Title:CSI 120 Lecture Notes 6

using System.Text.RegularExpressions;

namespace CSI_120_Lecture_Notes_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WhileLoopExample();
            ValidateInput();
            DoWhileExample();
            PasswordValidation();
            ForLoopExample();
            SumAndAverageNumber();
        }
        public static void WhileLoopExample()
        {
            int count = 0;
            while (count <= 10)
            {
                Console.WriteLine($"The count is {count}");
                count = count + 1;
            }
        }
        public static void ValidateInput()
        {
            string input;
            int number;
            bool isValid = false;
            while(isValid == false)
            {
                Console.WriteLine("Please enter a number");
                if(!Regex.IsMatch(input = Console.ReadLine(), @"^[a-zA-Z]+$")){
                    number = int.Parse(input);
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public static void DoWhileExample()
        {
            int count = 11;
            do
            {
                Console.WriteLine($"The Count is {count}");
            } while (count <= 10);
            Console.WriteLine("this is after our while loop");
        }
        public static void PasswordValidation()
        {
            string password;
            bool isValidPassword = false;
            do
            {
                Console.WriteLine("Enter a password");
                password = Console.ReadLine();
                if(password == "password")
                {
                    isValidPassword = true;
                }
                else
                {
                    Console.WriteLine("Invalid Password");
                }
            } while (isValidPassword == false);
        }
        public static void ForLoopExample()
        {
            for (int i = 450; i > -25; i -= 5)
            {
                Console.WriteLine($"Current value of 'i':  {i}");
            }
        }
        public static void SumAndAverageNumber()
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < 300; i += 4)
            {
                sum += i;
                count++;
            }

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Count: {count}");

            double average = (double)sum / count;
            Console.WriteLine($"Average: {average}");
        }//end of SumAndAverageNumber
    }//end of class
}//end of namespace
