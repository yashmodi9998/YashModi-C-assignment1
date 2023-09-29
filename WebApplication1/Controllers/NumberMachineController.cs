using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// this method takes input from URL and return all four  operations
        /// GET /api/numbermachine
        /// </summary>
        /// <param name="id">number</param>
        /// <returns>
        /// http://localhost:50987/api/numbermachine/5
        /// <ArrayOfstring xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.microsoft.com/2003/10/Serialization/Arrays">
        ///<string> Addition 7</string>
        ///<string> Substraction 3</string>
        ///<string> Multiplication 10</string>
        ///<string> Division 2</string>
        ///</ArrayOfstring>
        /// </returns>
        public String[] Get(int id)
        {
            int add = id + 2;
            int sub = id - 2;
            int mul = id * 2;
            double div = id / 2;

            return new string[] { " Addition " + add, " Substraction " + sub, " Multiplication " + mul, " Division " + div };
        }
         

    }
}
