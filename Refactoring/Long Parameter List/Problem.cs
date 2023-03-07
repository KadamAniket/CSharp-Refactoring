using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring.Long_Parameter_List
{
    class Problem
    {
        void Display(int id, string firstName, string lastName, string address)
        {
            Console.WriteLine("Id:{0}",id);
            Console.WriteLine("FirstName:{0}", firstName);
            Console.WriteLine("LastName:{0}", lastName);
            Console.WriteLine("Address:{0}", address);
        }
    }
}
