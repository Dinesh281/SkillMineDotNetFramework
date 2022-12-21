using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFramework
{
    class Employee1
    {
        protected static int empid;
        protected string empname;
        protected double basic, hra, da, pf, gross;
        public Employee1(string empname, double basic)
        {
            empid++;
            // this refers to the data member
            this.empname = empname;
            this.basic = basic;
            this.CalculateSalary();
        }
        public virtual void CalculateSalary()
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
    class SalesManager:Employee1
    {
        private int bonus;
        private int comm;
        public SalesManager(string empname,double basic,int bonus,int comm):base(empname,basic)
        {
            this.bonus=bonus;
            this.comm=comm;
        }
        public override void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da + bonus + comm ) - pf;
        }
/*        public new void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da + bonus + comm) - pf;
        }*/
        // ToString() --> string representation of an object
        public override string ToString()
        {
            return $"Employee id {empid}, emp name {empname} & gross salary of emp {gross}";
        }
    }
}
