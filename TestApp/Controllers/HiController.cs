using System.Web.Http;
using TestApp.Services.Abstract;

namespace TestApp.Controllers
{
    public class HiController : ApiController
    {
        private readonly IGreeter _greeter;

        public HiController(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public string Get()
        {
            return _greeter.SaySomething("Hi there!");
        }
    }
}
