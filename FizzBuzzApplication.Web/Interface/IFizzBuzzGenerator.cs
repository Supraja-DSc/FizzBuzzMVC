namespace FizzBuzzApplication.Web.Interface;
public interface IFizzBuzzGenerator
{
    bool IsInput(int input);

    string Execute();
}