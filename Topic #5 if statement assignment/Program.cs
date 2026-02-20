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

            if (planet == 1)
            { 
             Console.WriteLine("You would weigh " + (weight * 0.78) + " lbs.");
            }
            
        }
        public static void program2()
        {
            Console.WriteLine("bye");
        }
        public static void program3()
        {
            Console.WriteLine("3");
        }
    }
}
