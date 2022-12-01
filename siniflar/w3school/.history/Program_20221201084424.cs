// See https://aka.ms/new-console-template for more information
class Mycar
{
    string color; 
    int maxSpeed; 

    static void Main(string[] args)
    {
        Mycar myObj = new Mycar();
        myObj.color = "Red";
        myObj.maxSpeed = 200;
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.maxSpeed);

    }
    
}
