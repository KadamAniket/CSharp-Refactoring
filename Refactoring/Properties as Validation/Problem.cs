using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring.Properties_as_Validation
{
    class Problem
    {
        public int Age { get; set; }

        // Usually the code when user clicks the save/submit button in UI
        public void Submit()
        {
            if(Age < 0 || Age > 100)
            {
                Console.WriteLine("Age is not Valid");
            }
        }
    }
}
