using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign2_n01494583.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Determines how many ways two dice can roll the value of 10
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns>Number of ways two dice can roll the value of 10</returns>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

        public string DiceGame(int m,int n)
        {
            int counter = 0;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        counter = counter + 1;
                    }
                }

            }

            string messege = "There are " + counter +" total ways to get the sum 10" ;


            return messege;

        }

    }
}
