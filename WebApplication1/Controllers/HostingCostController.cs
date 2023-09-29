using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class HostingCostController : ApiController
    {


        public String[] Get(int id) {
            //variables
            double fortnightRate = 5.50;
            double taxRate = 13;

            //calculate the number of fortnights
            double fortnights = (id / 14) + 1;
            //calculate amount of per fortnights
            double amount = Math.Round(fortnights * fortnightRate,2);

            //calculate tax amount of per fortnights
            double taxamount = amount * (taxRate / 100);
            //calculate the final total
            double finalTotal = Math.Round(amount + taxamount,2);

            string data1 = fortnights + " fortnights at $" +fortnightRate.ToString("0.00") + "/FN = $" + amount.ToString("0.00") +" CAD";
            string data2 = "HST "+ taxRate+"% = $" + Math.Round(taxamount,2);
            string data3 = "Total = $" + finalTotal;

            return new string[] {data1,data2,data3};

        }
    }
}
