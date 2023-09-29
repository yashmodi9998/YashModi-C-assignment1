using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{


    public class AddTenController : ApiController
    {

        /// <summary>
        /// This method takes id from the input and adds 10 in the value
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
