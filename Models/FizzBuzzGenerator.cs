﻿using FizzBuzz.Interface;

namespace FizzBuzz.Models;

public class FizzBuzzGenerator : IFizzBuzzGenerator
{
    public bool IsInput(int number)
    { 
        return (number % 3)== 0 && (number % 5)==0; 
    }
    public string Execute()
    {
        return "";
    }
}