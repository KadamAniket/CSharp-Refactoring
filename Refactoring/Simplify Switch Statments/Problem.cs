using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring.Simplify_Switch_Statments
{
    class Problem
    {
        int CodeProblem(int value)
        {
            int result = 0;

            switch (value)
            {
                case 1:
                    result = result + value;
                    break;

                case 2:
                    result = result - value;
                    break;

                case 3:
                    result = result * value;
                    break;

                case 4:
                    result = result + value;
                    break;

                case 5:
                    result = result + value;
                    break;

                case 6:
                    result = result - value;
                    break;
            }

            return result;
        }
    }
}
