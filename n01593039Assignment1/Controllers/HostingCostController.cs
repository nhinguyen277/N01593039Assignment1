using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01593039Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This method will receive an input id like elapsed days which is equivalent to added fortnights
        /// and output price, tax and total for extra fortnights
        /// </summary>
        /// <param name="id">the input id (representing days format)</param>
        /// <returns>
        /// Get api/hosting/0 -> “1 fortnights at $5.50/FN = $5.50 CAD”
        ///                       “HST 13% = $0.72 CAD” 
        ///                       “Total = $6.22 CAD
        ///                       
        /// Get api/hosting/14 -> “2 fortnights at $5.50/FN = $11.00 CAD” 
        ///                       “HST 13% = $1.43 CAD” 
        ///                       “Total = $12.43 CAD”
        /// </returns>
        public IEnumerable<string> Get(int id)
        {
            // create valuables, using double to get the decimal numbers.
            double price = 5.50;
            double tax;
            double total;
            double addDay;
            double finalPrice;
            // if id less than 14 addDay = 1 , changing the number to curency type use String.Format,
            // round up to 2 decimal places for tax and total so using Math.Round

            if (id < 14)
            {
                addDay = 1;
                tax = price * 13 / 100;
                total = price + tax;
                return new string[] { addDay + " fortnights at $5.50/FN = "  + "$"+String.Format("{0:0.00}", price) + " CAD",
                " HST 13% = "+"$"+ Math.Round(tax,2) + " CAD", "Total = " +"$"+ Math.Round(total,2 ) + " CAD"};
            }
            //On the contrary, the elapsed date must be equal to the id divided 14 and take the interger number,
            //after that plussing 1 to increase a new fortnight.
            else
            {
                addDay = id / 14;
                finalPrice = price * (addDay + 1);
                tax = finalPrice * 13 / 100;
                total = finalPrice + tax;

                return new string[] {(addDay+1) + " fortnights at $5.50/FN = " +"$"+ String.Format("{0:0.00}", finalPrice) + " CAD",
                " HST 13% = "+ "$"+Math.Round(tax,2)+ " CAD", "Total = " +"$"+ Math.Round(total,2) + " CAD"};
            }
        }
    }
}
