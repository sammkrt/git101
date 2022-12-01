// See https://aka.ms/new-console-template for more information
class Car
{
    string color; 
    string model;
    int maxSpeed; 
    int year;

    public void Bilgi()
    {
        Console.WriteLine($"Car model is {model}, Car model' year is {year}, Car maxspeed is {maxSpeed}, Car color is {color}");
    
    }

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
