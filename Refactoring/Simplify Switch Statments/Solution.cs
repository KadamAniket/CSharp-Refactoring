using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring.Simplify_Switch_Statments
{
    class Solution
    {
        public int CodeSolution(int value)
        {
            int result = 0;

            // Common switch cases should be merged together
            switch (value)
            {
                case 1:
                case 4:
                case 5:
                    result = result + value;
                    break;

                case 2:
                case 6:
                    result = result - value;
                    break;

                case 3:
                    result = result * value;
                    break;
              
                    
            }

            return result;
        }
    }
}
