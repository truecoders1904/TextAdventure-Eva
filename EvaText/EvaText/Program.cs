using System;

namespace EvaText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Text Adventure University !");
            Console.WriteLine("You're about to experience TAU, do you have what it takes?");

            string response1 = Console.ReadLine();

            if (response1 == "Yes")
            {
                Console.WriteLine("First we must stop by the Student Center.");
                Console.WriteLine("Here we have to check your admissions status, and your financial status");
                Console.WriteLine();
                Console.WriteLine("Are you ready to enter The Student Center?");

                string response2 = Console.ReadLine();
                if (response2 == "Yes")
                {
                    //Show Student Hill Center building

                    Console.WriteLine("Admissions is your first stop here at the Student Center");
                    Console.WriteLine("");
                    Console.Clear();
                    Console.WriteLine("To move onto the next destination, you must be able to spell admissions backwards");
                    
                    Console.WriteLine("");
                     
                    Console.WriteLine("Go!");
                    Console.WriteLine(" ");
                    
                    string admissions = Console.ReadLine();
                    if (admissions == "snoissimda")
                    {
                        Console.WriteLine("Congraduations!");
                        Console.Clear();
                        Console.WriteLine("You have been accepted but next we have to see if you can really afford our challenge!");
                        
                        
                        Console.WriteLine("Think of a number and do NOT forget it!");
                        Console.WriteLine("Double Your Number\nThen add ten to your number.\nAFter that Half your number");
                        Console.WriteLine("Last, take away the number you started with from your current number.");
                        Console.WriteLine("What is your answer?");

                        string financialAid = Console.ReadLine();
                        if (financialAid == "5")
                        {
                            Console.WriteLine("You are officially a TAU Student!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("You must first be admitted");
                        Console.WriteLine("Come back when you are ready");
                    }
                   
                }
                else
                {
                    Console.WriteLine("You must first be admitted");
                    Console.WriteLine("Come back when you are ready");
                }

            }
            else if (response1 == "No")
            {
               
                    Console.WriteLine("Thank you for stopping by, maybe next semester");
            }
            

                     
        }
    }
}
