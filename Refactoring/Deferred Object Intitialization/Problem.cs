using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring.Deferred_Object_Intitialization
{
    class Problem
    {
        private DataService _dataService;

        public Problem(DataService dataService)
        {
            // Object gets init here only
            _dataService = dataService;
        }

        public List<int> GetData()
        {
            //// Long code

            // Object used here
            return _dataService.GetData();
        }
    }
}
