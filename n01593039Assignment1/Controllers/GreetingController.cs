using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01593039Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        //POST http://localhost/api/Greeting
        //Returns the string “Hello World!”
        /// <summary>
        /// This method receives a post and provides a message
        /// </summary>
        /// <returns>Hello World!</returns>
        /// POST api/greeting  - > Hello World!

        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// This method exxecutes a GET method and provide a message 
        /// which is a greeting with the interger input number of people
        /// </summary>
        /// <param name="id">the interger input represented the number of people</param>
        /// <returns> Greeting plus the input number of people</returns>
        /// POST api/greeting/5 - > Greeting 5 people!
        public string Get(int id)
        {
            int number = id;
            return "Greeting" + " " + number + " " + "people!";
        }
    }
}

