using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]

        public string Menu(int burger, int drink, int side, int dessert)
        //J1 Problem - (adapted) The New CCC
        ///<summary>
        /// This function calculates the total calories of a meal based on the food items selected from each category - burger, drink, side, dessert.
        ///</summary>
        ///<returns>
        /// "Your calorie count is" + the total amount of calories
        ///</returns>
        ///<param name="burger"> choice of 1,2,3, or 4 -> each has different calorie count (burgercal) </param>
        ///<param name="drink"> choice of 1,2,3, or 4 -> each has different calorie count (drinkcal) </param>
        ///<param name="side"> choice of 1,2,3, or 4 -> each has different calorie count (sidecal)</param>
        ///<param name="dessert"> choice of 1,2,3, or 4 -> each has different calorie count (dessertcal)</param>
        ///<example>
        ///GET localhost/api/J1/Menu/4/4/4/4 -> "Your total calorie count is 0"
        ///GET localhost/api/J1/Menu/1/2/3/4 -> "Your total calorie count is 691"
        ///</example>

        {
            int burgercal;
            int drinkcal;
            int sidecal;
            int dessertcal;

            if(burger == 1)
            {
                burgercal = 461;

            } else if(burger == 2)
            {
                burgercal = 431;

            } else if(burger == 3)
            {
                burgercal = 420;

            } else 
            {
                burgercal = 0;
            }

            if(drink == 1)
            {
                drinkcal = 130;

            } else if (drink == 2)
            {
                drinkcal = 160;

            } else if (drink == 3)
            {
                drinkcal = 118;

            } else
            {
                drinkcal = 0;
            }

            if(side == 1)
            {
                sidecal = 100;

            } else if (side == 2)
            {
                sidecal = 57;

            } else if (side == 3)
            {
                sidecal = 70;

            } else
            {
                sidecal = 0;
            }

            if(dessert == 1)
            {
                dessertcal = 167;

            } else if (dessert == 2)
            {
                dessertcal = 266;

            } else if (dessert == 3)
            {
                dessertcal = 75;

            } else
            {
                dessertcal = 0;
            }

            int totalcal = burgercal + drinkcal + sidecal + dessertcal;
            string message = "Your total calorie count is ";
            string output = message + totalcal;

            return output;

        }
    }
}
