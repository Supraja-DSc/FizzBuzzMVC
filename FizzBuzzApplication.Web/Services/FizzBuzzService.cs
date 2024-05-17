using System.Collections.Generic;
using FizzBuzzApplication.Web.Interface;
using FizzBuzzApplication.Web.Models;
using FizzBuzzApplication.Web.Services.Interface;

namespace FizzBuzzApplication.Web.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly List<IFizzBuzzGenerator> _rules;
        private readonly IDateTimeService _dateTimeService;

        public FizzBuzzService(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
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
                        // Modify "Fizz" to "Wizz" and "Buzz" to "Wuzz" if today is Wednesday
                        if (_dateTimeService.GetCurrentDayOfWeek() == DayOfWeek.Wednesday)
                        {
                            if (rule.GetType() == typeof(FizzGenerator))
                            {
                                result += "Wizz";
                            }
                            else if (rule.GetType() == typeof(BuzzGenerator))
                            {
                                result += "Wuzz";
                            }
                            else
                            {
                                result += rule.Execute();
                            }
                        }
                        else
                        {
                            result += rule.Execute();
                        }
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
}
