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
