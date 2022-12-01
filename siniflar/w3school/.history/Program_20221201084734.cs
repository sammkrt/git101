// See https://aka.ms/new-console-template for more information
class Mycar
{
    string color; 
    int maxSpeed; 

    public void Bilgi()
    {
        Console.WriteLine($"my car is: {color}");
        Console.WriteLine($"my car's speed is: {maxSpeed}");
    }

    static void Main(string[] args)
    {
        Mycar myObj = new Mycar();
        myObj.color = "Red";
        myObj.maxSpeed = 200;
        myObj.Bilgi();

    }
    
}
