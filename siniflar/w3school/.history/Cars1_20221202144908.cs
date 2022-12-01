// See https://aka.ms/new-console-template for more information
/*
class Car
{
    public string color; 
    public string model;
    public int maxSpeed; 
    public int year;

    public void Bilgi()
    {
        Console.WriteLine($"Car model is {model}, Car model' year is {year}, Car maxspeed is {maxSpeed}, Car color is {color}");
    
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myObj = new Car();
        myObj.color = "Red";
        myObj.maxSpeed = 200;
        myObj.Bilgi();

        Car Ford = new Car();
        Ford.color = "Black";
        Ford.model = "Mustang";
        Ford.year = 2003;
        Ford.maxSpeed = 250;
        Ford.Bilgi();

        Car Volvo = new Car();
        Volvo.color = "blue";
        Volvo.model = "v40";
        Volvo.year = 2018;
        Volvo.maxSpeed = 210;
        Volvo.Bilgi();

    }
    
}
*/

/*
class Cars
{
    public string model;
    public string color;
    public int year;

    public Cars(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }
    public void disp()
    {
        Console.WriteLine($"Car's model is {model}, color is {color}, year is {year}");
    }
    static void Main(string[] args)
    {
        Cars cupe = new Cars("Mustang","Blue",2012);
        cupe.disp();
    
        Cars cupe2 = new Cars("V40","Grey", 2018);
        cupe2.disp();
    
    }

}
*/

/*
class Person
{
    private string name;

    public string Name
    {
        get;
        set;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person myObj = new Person();
        myObj.Name = "Liam";
        Console.WriteLine(myObj.Name);
    }
}

*/


/*
// What is Inheritance???
class Vehicle // base Class(parent)
{
    public string brand = "Ford"; // Vehicle field
    public void honk()
    {
        Console.WriteLine("Tuutt , tuuuut !!");
    }
}

class Car : Vehicle //derived class(child)
{
    public string modelName = "Mustang"; // Car field
}

class Program
{
    static void Main(string[] args)
    {
        //Create a myCar object
        Car myCar = new Car();
        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.honk();
    
        // Display the value of the brand field and the value of modelName
        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }    

}
*/

/*
// Polymorphism and Overriding Methods

class Animal // Base class (parent)
{
    public virtual void animalSound() //adding virtual keyword to the method inside the base class,and by using the override keyword for each derived class
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal // Derived class (child)
{
    public override void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal
{
    public override void animalSound() // Derived class (child)
    {
        Console.WriteLine("The dog says: hav hav");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal(); // Create animal object
        Pig myPig = new Pig(); // Create Pig object
        Dog myDog = new Dog(); // Create Dog object

        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
    }

}

*/

/*
// Bakmadan yazdigim program (Constractor kullandim)
class Company
{
    public string name;
    public string job;
    public int salary;
    
    public Company(string personName , string personJob, int personSalary)
    {
        name = personName;
        job = personJob;
        salary = personSalary;
    }
    public void disp()
    {
        Console.WriteLine($"{name} is working as {job}. Salary  is {salary}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Company myObj = new Company("Rase","Senior Manager", 90000);
        Company myObj2 = new Company("Samet","Junior Manager", 50000);
        Company myObj3 = new Company("Cem","Senior Director", 150000);
        myObj.disp();
        myObj2.disp();
        myObj3.disp();
    }
}
*/

/*
//Abstract class -- Kod gizlemede kullaniyoruz

abstract class Animal
{
    // Abstract method(does not have a body)
    public abstract void animalSound();
    // Regular method 
    public void Sleep()
    {
        Console.WriteLine("Zzz");
    }
}

//Derived class (inherit from Animal)

class Pig : Animal
{
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig(); // Create a pig object
        myPig.animalSound(); // call the abstract method
        myPig.Sleep(); // call the regular method
    }
}
*/

// Interface -- An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies)

interface Ianimal // Interface genelde basina I harfi getiririz ki herkes anlasin
{
    void animalSound(); // Interface method (does not have a body)
}

// Pig "implements" the IAnimal interface
class Pig : Ianimal
{
    public void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig(); // Create a pig object
        myPig.animalSound();
        
    }
}




