using System;

using System.IO; // defining the System package 

public class Program1 {  

       public static void Main(string[] args) // defining the main function  

        {  

           string feeling; //declaring variable feeling           

           Console.WriteLine("Hey, how do you feel today?");            

           feeling = Console.ReadLine(); // takes the input from the user           

           Console.WriteLine("Hello there! I am feeling "+ feeling + "!"); // print the output  

        }  

    }