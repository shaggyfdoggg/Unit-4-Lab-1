using Circle_Objects;
    
    Console.WriteLine("Welcome to the Circle Tester");

//create circle
    Console.WriteLine("Enter radius");
double r = -1;

while (double.TryParse(Console.ReadLine(), out r) == false || r <= 0)
{
    Console.WriteLine("Please enter a valid positive number");
}

//create circle
Circle c = new Circle(r);

//Loop
bool runMethods = true;
while (runMethods)
{
    //Call methods
    Console.WriteLine($"Diameter : {c.CalculateDiameter()}");
    Console.WriteLine($"Circumference : {c.CalculateCircumference()}");
    Console.WriteLine($"Area : {c.CalculateArea()}");

    //Ask to grow(keep loop going)
    Console.WriteLine("Would you like the circle to grow? y/n");
    while (true)
    {
        string choice = Console.ReadLine().ToLower().Trim();
        if(choice == "y")
        {
            c.Grow();
            break;
        }
        else if(choice == "n")
        {
            Console.WriteLine($"Goodbye! The circle radius is {c.GetRadius()}");
            runMethods = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid. Try again");
        }
    }
}


//old code
//bool runProgram = true;
//while (true)
//{ 
//try
//{
//    //double r = double.Parse(Console.ReadLine().Trim().ToLower());
//    Circle myRadius = new Circle(r);
//    Console.WriteLine(myRadius.CalculateDiameter()); //Could not figure out how to properly display the method with the string text. Tried interpolation and couldn't get it to work. 
//    Console.WriteLine(myRadius.CalculateCircumference());
//    Console.WriteLine(myRadius.CalculateArea());
//    while (runProgram == true)
//    {
//        Console.WriteLine("Should the circle grow? (y/n)");
//        string input2 = Console.ReadLine().Trim().ToLower();
//        if (input2 == "y")
//        {
//            Console.WriteLine("The circle is magically growing");
//            myRadius.Grow();
//            myRadius.GetRadius();
//            Console.WriteLine(myRadius.CalculateDiameter());
//            Console.WriteLine(myRadius.CalculateCircumference());
//            Console.WriteLine(myRadius.CalculateArea());
//        }
//        else if (input2 == "n")
//        {
//            Console.WriteLine($"Goodbye. The circle's final radius is {myRadius.GetRadius()}");
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Not a valid input. Please try again");
//        }
//    }
//}
//catch (Exception)
//{
//    Console.WriteLine("Not a valid number. Please try again");
//}
//}
//}