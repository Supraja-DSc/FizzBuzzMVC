using FizzBuzz.Interface;
using FizzBuzz.Models;
using FizzBuzz.Services.Interface;

namespace FizzBuzz.Services;

public class FizzBuzzService : IFizzBuzzService
{ 
    private readonly List<IFizzBuzzGenerator> _rules;

    public FizzBuzzService()
    {
        _rules = new List<IFizzBuzzGenerator>
        {
            new FizzBuzzGenerator(),
            new FizzGenerator(),
            new BuzzGenerator()
        };
    }

    public IList<string> GetFizzBuzzNumbers(int input)
    {
        var fizzBuzzNumbers = new List<string>();

        for (int i = 1; i <= input; i++)
        {
            string result = string.Empty;

            foreach (var rule in _rules)
            {
                if (rule.IsInput(i))
                {
                    result += rule.Execute();
                }
            }

            if (string.IsNullOrEmpty(result))
            {
                result = i.ToString();
            }

            fizzBuzzNumbers.Add(result);
        }

        return fizzBuzzNumbers;
    }
}