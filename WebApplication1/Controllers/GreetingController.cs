using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// this method takes input from URL and greets id user.
        ///  GET /api/greetingcontroller
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// http://localhost:50987/api/greeting/12  <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">Greetings to 12 people</string>
        /// http://localhost:50987/api/greeting/1   <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">Greetings to 1 people</string>
        /// </returns>
        public string Get(int id)
        {
            
            return "Greetings to "+id+" people";
        }

        public string Post()
        {
            return "Hello World!";
        }
    }
}
