using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFramework.OOPS
{
    class Employee
    {
        private static int empid;
        private string empname;
        private double basic, hra, da, pf, gross;
        public Employee( string empname, double basic)
        {
            empid++;
             // this refers to the data member
            this.empname = empname;
            this.basic = basic;
        }
        public void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da) - pf;
        }
        // ToString() --> string representation of an object
        public override string ToString()
        {
            return $"Employee id {empid}, emp name {empname} & gross salary of emp {gross}";
        }

        //public string Print()
        //{
        //    return $"Employee id {empid}, emp name {empname} & gross salary of emp {gross}";
        //}
        public double GetGrossSalary()
        {
            return gross;
        }

    }

}
