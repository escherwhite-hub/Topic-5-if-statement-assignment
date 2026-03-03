namespace Topic__5_if_statement_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            Console.WriteLine("Chose a program to run.");
            Console.WriteLine("1. Fighting weight checker");
            Console.WriteLine("2. Simple calculator");
            Console.WriteLine("3. Quiz");
            Int32.TryParse(Console.ReadLine(), out menu);
            Console.Clear();
            if (menu == 1)
            {
                program1();
              
            }

            else if (menu == 2)
            {
                program2();
               
            }

            else if (menu == 3)
            {
                program3();
               
            }

            else
            {
                Console.WriteLine("That program doesnt exist try a number between 1 and 3");
                Int32.TryParse(Console.ReadLine(), out menu);
            }
           

        }

        public static void program1()
        {
            double weight;
            int planet;
            Console.WriteLine("what is your weight on Earth in pounds?");
            Double.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("What planet do you want to fight on?");
            Console.WriteLine("1. Venus");
            Console.WriteLine("2. Mars");
            Console.WriteLine("3. Jupiter");
            Console.WriteLine("4. Saturn");
            Console.WriteLine("5. Uranus");
            Console.WriteLine("6. Neptune");
            Int32.TryParse(Console.ReadLine(),out planet);
            Console.Clear();

            if (planet == 1)
            {
                Console.WriteLine("You would weigh " + (weight * 0.78) + " lbs on venus.");
            }

            else if (planet == 2)
            {
                Console.WriteLine("You would weigh " + (weight * 0.39) + "lbs on mars.");
            }

            else if (planet == 3)
            {
                Console.WriteLine("You would weigh " + (weight * 2.65) + " lbs on jupiter.");
            }

            else if (planet == 4)
            {
                Console.WriteLine("You would weigh " + (weight * 1.17) + " lbs on saturn.");
            }

            else if (planet == 5)
            {
                Console.WriteLine("You would weigh " + (weight * 1.05) + " lbs on uranus.");
            }

            else if (planet == 6)
            {
                Console.WriteLine("You would weigh " + (weight * 1.23) + " lbs on neptune.");
            }

            else
            {
                Console.WriteLine("That planet doesnt exist try using a number between 1 and 6");
                Console.WriteLine();
                program1();
            }
            

        }
        public static void program2()
        {
            string mathOp;
            double num1, num2;
            Console.WriteLine("input a mathematical operator for your equation (+,-,*,/,sqrt).");
            mathOp = Console.ReadLine();
            Console.Clear();


            if (mathOp == "+")
            {
                Console.WriteLine("give a number you want to add");
                Double.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("Give another number");
                Double.TryParse(Console.ReadLine(), out num2);
                Console.WriteLine("your numbers added together are:");
                Console.WriteLine(Math.Round(num1 + num2, 2));
            }

            else if (mathOp == "-")
            {
                Console.WriteLine("give a number you want to subtract from");
                Double.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("Give a number you want to subract");
                Double.TryParse(Console.ReadLine(), out num2);
                Console.WriteLine("your numbers subtracted are:");
                Console.WriteLine(Math.Round(num1 - num2, 2));
            }

            else if (mathOp == "*")
            {
                Console.WriteLine("give a number you want to multiply");
                Double.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("Give another number");
                Double.TryParse(Console.ReadLine(), out num2);
                Console.WriteLine("your numbers multiplied are:");
                Console.WriteLine(Math.Round(num1 * num2, 2));
            }

            else if (mathOp == "/")
            {
                Console.WriteLine("give a number you want to divide from");
                Double.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("Give a number you want to divide by");
                Double.TryParse(Console.ReadLine(), out num2);
                Console.WriteLine("your numbers divided  are:");
                Console.WriteLine(Math.Round(num1 / num2,2));
            }

            else if (mathOp == "sqrt")
            {
                Console.WriteLine("give a number you want to square root");
                Double.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("your number square rooted is:");
                Console.WriteLine(Math.Round(Math.Sqrt(num1),2));
            }

            else
            {
                Console.WriteLine("That Mathematical operator doesnt exist");
                Console.WriteLine();
                program2();
            }
        }
        public static void program3()
        {
            string ans1, ans2, ans3, ans4, ans5;
            double correctAns = 0;
            double incorrectAns = 0;


            Console.WriteLine("welcome the the quiz. Press enter to continue:");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("question 1: What country is the Great Pyramid of Giza in?");
            ans1 = Console.ReadLine();

            if (ans1.ToLower() == "egypt")
            {
                Console.WriteLine("correct!");
                correctAns += 1;
            }

            else
            {
                Console.WriteLine("Incorrect!");
                incorrectAns += 1;
            }

            Console.WriteLine("Press enter for the next question!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("question 2: What is 5 × 6 ? ");
            ans2 = Console.ReadLine();

            if (ans2 == "thirty" || ans2 == "30")
            {
                Console.WriteLine("Correct!");
                correctAns += 1;
            }

            else
            {
                Console.WriteLine("incorrect");
                incorrectAns += 1;
            }

            Console.WriteLine("Press enter for the next question!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("question 3: True or false, We live on planet earth ");
            ans3 = Console.ReadLine();

            if (ans3.ToLower() == "true")
            {
                Console.WriteLine("Correct!");
                correctAns += 1;
            }

            else
            {
                Console.WriteLine("incorrect");
                incorrectAns += 1;
            }
            
            Console.WriteLine("Press enter for the next question!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("question 4: What sound does a cow make? ");
            Console.WriteLine("A. Baa");
            Console.WriteLine("B. Moo");
            Console.WriteLine("C. Bark");
            Console.WriteLine("D. Meow");
            ans4 = Console.ReadLine();

            if (ans4.ToLower() == "moo" || ans4.ToLower() == "b")
            {
                Console.WriteLine("Correct!");
                correctAns += 1;
            }

            else
            {
                Console.WriteLine("incorrect, how did you not know that");
                incorrectAns += 1;
            }

            Console.WriteLine("Press enter for the next question!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("question 5: What color do you get when you mix red and blue? ");
            ans5 = Console.ReadLine();

            if (ans5.ToLower() == "purple")
            {
                Console.WriteLine("Correct!");
                correctAns += 1;
            }

            else
            {
                Console.WriteLine("incorrect");
                incorrectAns += 1;
            }

            Console.WriteLine("Press enter for your score!");
            Console.ReadLine();
            Console.Clear();
            double percent = correctAns / 5 * 100;

            Console.WriteLine($"You got {percent}% on this quiz" );
            if (percent == 0)
            {
                Console.WriteLine("Wow you managed to get no questions right! you should go back to kindergarten");
            }
            else if (percent == 100)
            {
                Console.WriteLine("Congratulations you got perfect! you're so smart");
            }

          
        }


        
    }
}
