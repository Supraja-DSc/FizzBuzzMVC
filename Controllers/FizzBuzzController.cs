using FizzBuzz.Models;
using FizzBuzz.Services.Interface;

namespace FizzBuzz;

public class FizzBuzzController 
{

    // Controller class for handling FizzBuzz logic

    private readonly IFizzBuzzService _fizzBuzzService;

    public FizzBuzzController(IFizzBuzzService fizzBuzzService)
    {
        _fizzBuzzService = fizzBuzzService;
    }

    // Method to generate FizzBuzz numbers based on input
    public FizzBuzzModel GenerateFizzBuzz(int input)
    {
        var fizzBuzzNumbers = _fizzBuzzService.GetFizzBuzzNumbers(input);
        return new FizzBuzzModel { Input = input, FizzBuzzNumbers = fizzBuzzNumbers };
    }

    //public IActionResult Index()
    //{
    //    return View();
    //}
}