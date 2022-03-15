using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDemo // project 1
{
    public class Department
    {
        private int id;
        private string name, location;
        public Department()
        {
            id = 1;
            name = "Admin";
            location = "Pune";
        }
        public Department(int did,string dname,string loc)
        {
            id = did;
            name = dname;
            location = loc;
        }
       public int  GetDeptId()
        {
            return id;
        }
        //public void AssignData()
        //{
        //    id = 1;
        //    name = "Admin";
        //    location = "Pune";
        //}
        public string GetData()
        {
            return "Dept Id " + id + "Dept name " + name + " location " + location;
           
        }
    }
  
}
