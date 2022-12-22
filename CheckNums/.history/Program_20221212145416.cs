using System;

using System.IO; // defining the System package

class Program2 {

    public static void Main() //defining the main method

    {

       // declaring variables

        int price; 

        string name;

        int icecreams;

        int total;        

        Console.WriteLine("Enter price of each ice-cream: ");

        price = Convert.ToInt32(Console.ReadLine()); // Converting string to int

        Console.WriteLine("Enter the customer's name: ");

        name = Console.ReadLine(); //reading input         

        Console.WriteLine("Enter the number of icecreams that "+name+" has ordered");

        icecreams = Convert.ToInt32(Console.ReadLine()); // Converting string to int      

        total = icecreams * price; // calculating total price        

        // printing the final output

        Console.WriteLine(name+" has ordered "+icecreams+

        " ice-creams. The total amount to be paid is "+total); 

    }

}

