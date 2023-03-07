using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring.Composing_Methods
{
    class Problem
    {
        public void CodeProblem()
        {

            int total = 0;
            double outstanding = 100;
            List<int> orderAmountList = new List<int>();


            // print banner
            Console.WriteLine("**************************");
            Console.WriteLine("***** Customer Total ******");
            Console.WriteLine("**************************");


            // calculate total
            foreach(var orderAmount in orderAmountList)
            {
                total += orderAmount;
            }


            //print details
            Console.WriteLine("************DETAILS**************");
            Console.WriteLine("TOTAL:{0}",total);
            Console.WriteLine("OUTSTANDING:{0}", outstanding);
            Console.WriteLine("**************************");


        }
    }
}
