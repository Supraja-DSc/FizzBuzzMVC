using FizzBuzzApplication.Web.Services.Interface;

namespace FizzBuzzApplication.Web.Services;
public class DateTimeService : IDateTimeService
{
    public DayOfWeek GetCurrentDayOfWeek()
    { 
        return DateTime.Today.DayOfWeek;
    }
}