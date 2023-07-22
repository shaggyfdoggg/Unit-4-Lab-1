using Circle_Objects;


    bool runProgram = true;
    Console.WriteLine("Welcome to the Circle Tester");
    Console.WriteLine("Enter radius");
while (true)
{
    try
    {
        double input = double.Parse(Console.ReadLine().Trim().ToLower());
        Circle myRadius = new Circle(input);
        Console.WriteLine(myRadius.CalculateDiameter(input));
        Console.WriteLine(myRadius.CalculateCircumference(input));
        Console.WriteLine(myRadius.CalculateArea(input));
        while (runProgram = true)
        {
            Console.WriteLine("Should the circle grow? (y/n)");
            string input2 = Console.ReadLine().Trim().ToLower();
            if (input2 == "y")
            {
                Console.WriteLine("The circle is magically growing");
                myRadius.Grow();
                myRadius.GetRadius();
                Console.WriteLine(myRadius.CalculateDiameter(input));
                Console.WriteLine(myRadius.CalculateCircumference(input));
                Console.WriteLine(myRadius.CalculateArea(input));
            }
            else if (input2 == "n")
            {
                Console.WriteLine($"Goodbye. The circle's final radius is {myRadius.GetRadius()}");
                runProgram = false;
                break;
            }
            else
            {
                Console.WriteLine("Not a valid input. Please try again");
            }
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Not a valid number. Please try again");
    }
    }