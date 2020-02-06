using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeModel.Models;
using EmployeeModel.Repositories;

namespace EmployeeModel.Repositories
{
    public class EmployeeRepository
    {
        public static List<Employee> elist = new List<Employee>()
        {
            new Employee()
            {
                Eid="21",
                Name = "Sai",
                Degination = "Manager",
                P_Name="EmployeeManagement",
                Pwd = "98765"
            }
        };
        public EmployeeRepository()
        {

        }
        public void Add(Employee item)
        {
            elist.Add(item);
        }
        public Employee Validate(string eid, string pwd)
        {
            foreach (var item in elist)
            {
                if (item.Eid == eid && item.Pwd == pwd)
                {
                    return item;
                }
            }
            return null;

        }
    }
}
