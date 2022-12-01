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
    }

}