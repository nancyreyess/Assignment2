using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        [Route("api/J2/FishFinder/{a}/{b}/{c}/{d}")]
        [HttpGet]

        //J2 Problem - "Sounds Fishy!" from CCC 2012
        ///<summary>
        ///Function let's us know if a fish is found by using four depth readings
        /// </summary>
        /// <returns>
        /// If the four consecutive depth readings form an increasing sequence -> "Fish Rising"
        /// If the four consecutive depth readings form a decreasing sequence -> "Fish Diving"
        /// If the four consecutive depth readings are identical -> "Fish At Constant Depth"
        /// Any other sequence considered random noise or debris -> "No Fish"
        /// </returns>
        /// <param name="a"> first depth reading </param>
        /// <param name="b"> second depth reading </param>
        /// <param name="c"> third depth reading </param>
        /// <param name="d"> fourth depth reading </param>
        /// <example>
        /// GET localhost/api/J2/FishFinder/30/10/20/20 -> "No Fish"
        /// GET localhost/api/J2/FishFinder/1/10/12/13 -> "Fish Rising"
        /// GET localhost/api/J2/FishFinder/3/3/3/3 -> "Fish At Constand Depth"
        /// GET localhost/api/J2/FishFinder/10/9/8/7 -> "Fish Diving"
        /// </example>
        public string FishFinder(int a, int b, int c, int d)
        {
            if(a<b && b <c && c < d)
            {
                return "Fish Rising";

            } else if (a>b && b>c && c > d)
            {
                return "Fish Diving";

            } else if (a==b && b==c && c == d)
            {
                return "Fish At Constant Depth";

            } else
            {
                return "No Fish";
            }
        }
    }
}
