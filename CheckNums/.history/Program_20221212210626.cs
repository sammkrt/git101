﻿using System;

public class MainClass {

  
  public static string CheckNums(int num1, int num2) 
  {
    
    if (num1 == num2)
    {
      return "-1";
    }
    else if (num1 > num2)
    {
      return "false";
    }
    return "true";
  }

  public static void Main(string[] args) 
  {  
    // keep this function call here

    int num1;
    int num2;
    // result = CheckNums(num1,num2);
    num1 = Convert.ToInt32(Console.ReadLine());
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(CheckNums(num1,num2).ToString());
    // Console.WriteLine(MainClass.CheckNums(Console.ReadLine()));
  } 

}
