using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01593039Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        //GET http://localhost/api/Square/{id}
        //Returns the square of the integer input {id}.
        /// <summary>
        /// This method executes a GET method and provide a number
        /// which is the square of the interger number
        /// </summary>
        /// <param name="id">the input number squares up</param>
        /// <returns>the square of the interger input number</returns>
        /// GET api/square/10 - > 100
        public int Get(int id)
        {
            int squares = id * id;
            return squares;
        }
    }
}
