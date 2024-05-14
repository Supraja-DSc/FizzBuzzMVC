using FizzBuzzApplication.Web.Models;
using FizzBuzzApplication.Web.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzApplication.Web.Controllers;
public class FizzBuzzController  : Controller 
{

    // Controller class for handling FizzBuzz logic

    private readonly IFizzBuzzService _fizzBuzzService;

    public FizzBuzzController(IFizzBuzzService fizzBuzzService)
    {
        _fizzBuzzService = fizzBuzzService;
    }

    public IActionResult Generate(FizzBuzzModel model)
    {
        const int maxNumber = 1000;
        var fizzBuzzModel = new FizzBuzzModel
        {
            Input = maxNumber,
            FizzBuzzNumbers = _fizzBuzzService.GetFizzBuzzNumbers(maxNumber)
        };
        return View("Result", fizzBuzzModel);
    }
}