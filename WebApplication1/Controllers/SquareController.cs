using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// this method takes input from URL and return square
        /// GET /api/square
        /// </summary>
        /// <param name="id">number</param>
        /// <returns>
        /// http://localhost:50987/api/square/2  <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">4</int>
        /// http://localhost:50987/api/square/-2 <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">4</int>
        /// </returns>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
