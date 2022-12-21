using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFramework.OOPS
{
    class Emp
    {
        public int empid { get; set; }
        public string empname { get; set; }
        public double empsalary { get; set; }

    }
    class Stud
    {
          int stdid;
          string stdname;
          int stdmarks;
        public Stud(int id,string name,int marks)
        {
            stdid = id;
            stdname = name;
            stdmarks = marks;
        }
        public override string ToString()
        {
            return $"{stdid} {stdname} {stdmarks}";
        }
    }
}
