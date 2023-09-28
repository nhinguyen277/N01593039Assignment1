using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01593039Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        // GET http://localhost/api/AddTen/{id}
        //Returns 10 more than the integer input {id}.
        /// <summary>
        /// This method executes a GET method and provide a number 
        /// which is 10 more than the interger input {id}
        /// </summary>
        /// <param name="id">the input number to plus</param>
        /// <returns>the interger input number plus 10</returns>
        /// GET api/addten/10  - > 20
        public int Get(int id)
        {
            int result = id + 10;
            return result;
        }
    }
}
