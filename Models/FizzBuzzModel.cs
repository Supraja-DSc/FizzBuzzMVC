using System.ComponentModel.DataAnnotations;

namespace FizzBuzz.Models;

public class FizzBuzzModel
{
    [Range(1, 1000,ErrorMessage ="Values should be between 1 to 1000")]
    public int Input { get; set; }

    public IList<string> FizzBuzzNumbers { get; set; }
}