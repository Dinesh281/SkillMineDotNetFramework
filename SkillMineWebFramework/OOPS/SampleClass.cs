using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFramework.OOPS
{
    public class Person
    {
        private string last;
        private string first;
        private string middle;

        public Person(string lastName, string firstName)
        {
            last = lastName;
            first = firstName;
        }
        public Person(string lastName,string firstName,string middleName):this(lastName,firstName)
        {
            middle = middleName;
        }
        public override string ToString()
        {
            return $"{first}   {middle}   {last}  "; 
        }
        // Remaining implementation of Person class.
    }
    public class Adult : Person
    {
        private static int minimumAge;

        public Adult(string lastName, string firstName) : base(lastName, firstName)
        { }

        /*        static Adult()
                {
                    minimumAge = 18;
                }*/
        static Adult() => minimumAge = 18;

        // Remaining implementation of Adult class.
    }
    public class Child : Person
    {
        private static int maximumAge;

        public Child(string lastName, string firstName) : base(lastName, firstName)
        { }

        static Child() => maximumAge = 18;

        // Remaining implementation of Child class.
    }
    abstract class SampleClass
    {
    }
}
