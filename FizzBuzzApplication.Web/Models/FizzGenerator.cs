using FizzBuzzApplication.Web.Interface;

namespace FizzBuzzApplication.Web.Models;

public class FizzGenerator : IFizzBuzzGenerator
{
    public bool IsInput(int number)
    {
        return (number % 3) == 0;
    }
    public string Execute()
    {
        return "Fiss";
    }
}