using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring.Composing_Methods
{
    class Solution
    {
        // Split the common logic inside to its own separate method
        // Required fields can be added as parameters
        public void CodeSolution()
        {
            double outstanding = 100;

            PrintBanner();

            List<int> orderAmountList = new List<int>();
            int total = calculateTotal(orderAmountList);


            PrintDetails(total, outstanding);
        }



        private void PrintBanner()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("***** Customer Total ******");
            Console.WriteLine("**************************");
        }

        private int calculateTotal(List<int> orderAmountList)
        {
            int total = 0;
            // calculate total
            foreach (var orderAmount in orderAmountList)
            {
                total += orderAmount;
            }

            return total;
        }

        private void PrintDetails(int total, double outstanding)
        {
            Console.WriteLine("************DETAILS**************");
            Console.WriteLine("TOTAL:{0}", total);
            Console.WriteLine("OUTSTANDING:{0}", outstanding);
            Console.WriteLine("**************************");
        }
    }
}
