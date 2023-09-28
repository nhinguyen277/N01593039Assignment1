using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01593039Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This method executes a GET method and provide a number
        /// with four mathemetical operations to it.
        /// </summary>
        /// <param name="id"> the input number to execute mathematical operaations(+,-,*,/)</param>
        /// <returns> 4 mathematical operations of the input number with 5</returns>
        /// GET api/numbermachine/10 - >  10 + 5 =  15
        ///                               10 - 5 =  5
        ///                               10 * 5 =  50
        ///                               10 / 5 =  2
        public IEnumerable<string> Get(int id)
        {
            return new string[] { id + " "+ "+ 5 = "+(id + 5), id + " "+ "- 5 = " + (id - 5),
                id + " "+ " * 5 = " + id * 5,id + " "+" / 5 = " + id / 5};
        }
    }
}
