using FizzBuzz.Models;
using FizzBuzz.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz;
public class FizzBuzzController  : Controller 
{

    // Controller class for handling FizzBuzz logic

    private readonly IFizzBuzzService _fizzBuzzService;

    public FizzBuzzController(IFizzBuzzService fizzBuzzService)
    {
        _fizzBuzzService = fizzBuzzService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Generate(FizzBuzzModel model)
    {
        if (!ModelState.IsValid)
        {
            return View("Index", model);
        }

        var fizzBuzzModel = _fizzBuzzService.GetFizzBuzzNumbers(model.Input);
        return View("Result", fizzBuzzModel);
    }
}