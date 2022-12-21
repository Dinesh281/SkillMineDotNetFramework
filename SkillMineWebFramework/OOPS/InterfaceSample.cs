using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFramework.OOPS
{
    public interface IPrint
    {
        string print();
    }
    public class Employee1:IPrint
    {
        private static int empid;
        private string empname;
        private double basic, hra, da, pf, gross;
        public void Employee(string empname, double basic)
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

        public string print()
        {
            return $"Employee id {empid}, emp name {empname} & gross salary of emp {gross}";
        }

    }
    public class Area:IPrint
    {
        private int r;
        private double area;
        public void Circle(int r)
        {
            this.r = r;
        }

        public  void CalculateArea()
        {
            area = 3.14 * r * r;
        }

        public string print()
        {
            return $"area of circle is {area}";
        }
    }
    public class Student
    {

    }
}
