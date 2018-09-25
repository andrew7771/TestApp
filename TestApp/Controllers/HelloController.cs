using System.Web.Http;
using TestApp.Services.Abstract;

namespace TestApp.Controllers
{
    public class HelloController : ApiController
    {
        private readonly IGreeter _greeter;

        public HelloController(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public string Get()
        {
            return _greeter.SaySomething("Hi everyone!");
        }
    }
}
