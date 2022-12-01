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


// Polymorphism and Overriding Methods

class Animal // Base class (parent)
{
    public void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal // Derived class (child)
{
    public void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal
{
    public void animalSound() // Derived class (child)
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




