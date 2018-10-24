using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class DemoController : ApiController
    {
        /// <summary>
        /// My super fun demo get the whole world
        /// </summary>
        /// <remarks>
        /// Get a super fun message
        /// </remarks>
        /// <returns>
        /// Returns a super fun welcome message
        /// </returns>
        /// <returns></returns>
       public string Get()
        {
            return "Welcome To Web API";
        }

        /// <summary>
        /// Another super fun demo get by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>
        /// Returns a random list of fun
        /// </returns>
        public List<string> Get(int Id)
        {
            return new List<string>
            {
                "Data1",
                "Data2"
            };
        }
    }
}
