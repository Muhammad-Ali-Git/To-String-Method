using System;
using System.Dynamic;

class Ali
{
    public static void Main()
    {
        Console.WriteLine("This program prints full name of the user overriding ToString() and Convert.ToString() Methods.");
        
        START:
        Console.WriteLine("\n----------------------------------------------------------\n");

        Console.WriteLine("Please! Enter your first name: ");
        string FN = Console.ReadLine();

        Console.WriteLine("Please! Enter your last name: ");
        string LN = Console.ReadLine();

        if (FN == "" || LN == "")
        {
            Console.WriteLine("\n----------------------------------------------------------\n");
            Console.WriteLine("Namespace cannot be a null value! Please try again!");

            goto START;
        }

        Costumer C = new Costumer();
        C.FirstName = FN;
        C.LastName = LN;

        Console.WriteLine("Using ToString() Method: ");
        Console.WriteLine("Your full name is: {0}", C.ToString());

        Console.WriteLine("\n----------------------------------------------------------\n");

        Console.WriteLine("Using Convert.ToString() Method: ");
        Console.WriteLine("Your full name is: {0}", Convert.ToString(C));
    }
}

public class Costumer
{
    public string FirstName {get; set;}
    public string LastName {get; set;}

    public override string ToString()
    {
        return this.LastName + ", " + this.FirstName;
    }
}