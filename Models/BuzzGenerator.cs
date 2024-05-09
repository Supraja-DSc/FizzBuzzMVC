using FizzBuzz.Interface;

namespace FizzBuzz.Models;
public class BuzzGenerator : IFizzBuzzGenerator
{
    public bool IsInput(int number)
    {
        return (number % 5) == 0;
    }
    public string Execute()
    {
        return "Buzz";
    }
}