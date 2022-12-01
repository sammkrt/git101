// See https://aka.ms/new-console-template for more information
    
    class Program
    {
        private static string greet(string namePassedIn)
        {
        return "Welcome to SALT , " + namePassedIn;
        }


        static void Main(string[] args)
        {
        Console.Write("What is your name? ");
        var name = Console.ReadLine();
        
        Console.Write("When does that course start?");
        var courseDate = Console.ReadLine(); 
        var parsedDate = DateTime.Parse(courseDate);
        var today = DateTime.Now;
        var timeDiff = (parsedDate - today);     
        var greeting = greet(name);

        Console.WriteLine(greeting);
        Console.WriteLine($"Today it is {timeDiff.Days} days left until the course starts");
        }
    }