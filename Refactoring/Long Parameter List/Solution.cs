using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring.Long_Parameter_List
{
    class Solution
    {
        void Display(Details detail)
        {
            Console.WriteLine("Id:{0}", detail.Id);
            Console.WriteLine("FirstName:{0}", detail.FirstName);
            Console.WriteLine("LastName:{0}", detail.LastName);
            Console.WriteLine("Address:{0}", detail.Address);
        }
    }

    class Details
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

    }
}
