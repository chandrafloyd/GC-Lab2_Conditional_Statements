using System;

namespace Lab2_ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Exercise 1) Print numbers bet 1 and 10 inclusive

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadLine();

            //// 2) Print numbrs bet 1 and some user input

            //int Max = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= Max; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadLine();


            //// 3) Print even numbers between 1 and 200 using a for loop
            //for (int i = 1; i <= 200; i++)
            //{
            //    if (i % 2 == 0) //even.  % modulus checks for the remainder. if no remainder, the number is even
            //        Console.WriteLine(i);
            //}

            //Console.ReadLine();



            //// 4) Print numbers between 100 and 1 

            //for (int i = 1; i <= 200; i++)
            //{
            //    if (i % 2 == 0) //even.  % modulus checks for the remainder. if no remainder, the number is even
            //        Console.WriteLine(i);
            //}

            //Console.ReadLine();



            //// 5) print even numbers bet 1 and 200 

            //for (int i = 1; i <= 200; i++)
            //{
            //    if (i % 2 != 0) //odd.  
            //        continue;
            //    Console.WriteLine(i);
            //}
            ////Console.ReadLine();}



            //WELCOME
                Console.WriteLine("Hi! What's your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Hi, " + name + "!");
                

            bool ContinueProgram = true;
           

            while (ContinueProgram)
            {
                //INPUT
                Console.WriteLine("");
                Console.WriteLine("Enter a number between 1 and 100: ");
                int Input = int.Parse(Console.ReadLine());


                //PROCESS
   
                if (Input % 2 != 0 && Input >= 0) //if number is odd and positive
                    {
                        Console.WriteLine("");
                        Console.WriteLine(Input + " is odd");
                        Console.WriteLine("");
                    }

                else //if it's not odd, it must be even 
                    {
                        if (Input >= 2 && Input <= 25)  //if it's even and between these #s, do this
                        {
                            Console.WriteLine("");
                            Console.WriteLine(Input + " is even and less than 25");
                        }

                        else if (Input >= 26 && Input <= 60)  //if it's even and has this other criteria, do this instead

                        {
                            Console.WriteLine("");
                            Console.WriteLine(Input + " is even (and between 26 & 60)");
                        }

                        else if (Input > 60)  //if it's even and none of those other things, do this

                        {
                            Console.WriteLine("");
                            Console.WriteLine(Input + " is even (and more than 60)");
                        }
                    }

                //REPEAT?
                Console.WriteLine("Continue? Y/N");
                string Continue = Console.ReadLine();
             
                if (Continue == "Y") //|| "y")
                    {
                      ContinueProgram = true;  //when the number is odd and hit y to continue, it just repeats "# is odd; continue". How to make it ask for a new number?
                    }

                else
                    {
                      ContinueProgram = false;
                      Console.WriteLine("Goodbye!");
                    }

                }
                        
            }

           
        }


    }

