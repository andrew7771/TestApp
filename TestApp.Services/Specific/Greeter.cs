using TestApp.Services.Abstract;

namespace TestApp.Services.Specific
{
    public class Greeter : IGreeter
    {
        public string SaySomething(string message)
        {
            return message;
        }
    }
}
