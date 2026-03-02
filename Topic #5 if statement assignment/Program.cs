namespace Topic__5_if_statement_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            Console.WriteLine("Chose a program to run. (1,2,3)");
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
            Console.WriteLine("3");
        }
    }
}
