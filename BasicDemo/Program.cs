using System;  //  FCL

namespace BasicDemo  // as container - assembly  project
{
    // is a collection of Types  ( class, struct, enum, delegate, interfaces....)
    class Program
    {
        // members of class / struct / interface
        // variable(data member), methods, constructor,events , properties
        static void Main(string[] args) // entry point of program
        {

            // create object of Department class
            Department dept = new Department();
            int i1=dept.GetDeptId();
            Console.WriteLine(dept.GetData());

            Department dept2 = new Department(2, "HR", "Mumbai");
            Console.WriteLine(dept2.GetDeptId());
            Console.WriteLine(dept2.GetData());

            Department d = new Department();
        }


    }


}
