using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFramework.Collection.Generic_Collection
{
    public class Employee : IComparable
    {
        private string empname;
        private double empsalary;
        public Employee(string empname,double empsalary)
        {
            this.empname = empname;
            this.empsalary = empsalary;
        }

        public int CompareTo(object obj)
        {
            Employee e4 = (Employee)obj;
            return 1;

        }

        public override string ToString()
        {
            return $"{empname} --> {empsalary}";
        }


    }
    public class Department:IEnumerable
    {
        private Employee[] employees;
        public Department()
        {
            employees = new Employee[5];
            employees[0] = new Employee("Rohit", 45000);
            employees[1] = new Employee("Mohit", 50000);
            employees[2] = new Employee("Yogesh", 30000);
            employees[3] = new Employee("Hitesh", 25000);
            employees[4] = new Employee("Rahul", 35000);

        }

        public IEnumerator GetEnumerator()
        {
            return employees.GetEnumerator();
        }
    }
/*    class Program
    {
        static void Main(string[] args)
        {
            Department dep = new Department();
            foreach (Employee d in dep)
            {
                Console.WriteLine(d);

            }
        }
    }*/
}
