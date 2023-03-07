using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring.Deferred_Object_Intitialization
{
    class Solution
    {
        private Lazy<DataService> _dataService;

        public Solution(Lazy<DataService> dataService)
        {
            _dataService = dataService;
        }

        public List<int> GetData()
        {
            //// Long code

            // Object used here
            // Object gets init here only when its first used
            return _dataService.Value.GetData();
        }
    }
}
