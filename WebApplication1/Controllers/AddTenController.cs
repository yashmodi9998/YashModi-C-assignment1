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
        /// GET /api/addten
        /// </summary>
        /// <param name="id">number </param>
        /// <returns>http://localhost:50987/api/addten/21 <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">31</int>
        /// http://localhost:50987/api/addten/0 <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">10</int>
        /// </returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
