using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFramework.Collection.Generic_Collection
{
    public class Employees
    {
        public int empid { get; set; }
        public string empname { get; set; }
        public int salary { get; set; }
    }
    public class Department1
    {
        public int depid;
        public string departmenttype;
        public List<Employees> elist = new List<Employees>();
    }
    class Depart
    {
        /*static void Main(string[] args)
        {
            List<Department1> dep = new List<Department1>()
            {
                new Department1
                {
                    depid=1,
                    departmenttype = "HR",
                    elist =
                    {
                        new Employees {empid=101,empname="Rohit",salary=15000},
                        new Employees {empid=102,empname="Rahul",salary=25000},
                        new Employees {empid=103,empname="Mahesh",salary=20000},
                        new Employees {empid=104,empname="Arun",salary=35000}
                    }
                },
                new Department1
                {
                    depid=2,
                    departmenttype = "Developer",
                    elist =
                    {
                        new Employees {empid=105,empname="Summit",salary=15000},
                        new Employees {empid=106,empname="Rahul",salary=25000},
                        new Employees {empid=107,empname="Mahesh",salary=20000}

                    }
                },
                new Department1
                {
                    depid=3,
                    departmenttype = "Testing",
                    elist =
                    {
                        new Employees {empid=108,empname="Rohit",salary=15000},
                        new Employees {empid=109,empname="Rahul",salary=25000},
                        new Employees {empid=110,empname="Mahesh",salary=20000},
                        new Employees {empid=111,empname="Arun",salary=35000}
                    }
                }
            };
            foreach (Department1 d in dep)
            {
                Console.WriteLine($"{d.depid}  {d.departmenttype} ");
                foreach (Employees l in d.elist)
                {
                    Console.WriteLine($"{l.empid}  {l.empname}  {l.salary}");
                }
            }

        }*/
    }
}
