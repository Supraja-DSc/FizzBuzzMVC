namespace FizzBuzz.Services.Interface;
public interface IFizzBuzzService
{
    IList<string> GetFizzBuzzNumbers(int input);
}