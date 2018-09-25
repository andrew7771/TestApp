using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Services.Abstract;

namespace TestApp.Services.Specific
{
    class Greeter : IGreeter
    {
        public string SaySomething(string message)
        {
            return message;
        }
    }
}
