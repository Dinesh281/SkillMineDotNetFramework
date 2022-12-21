using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFramework.OOPS
{
    public class Test1
    {

        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a,int b)
        {
            return a - b;
        }
    }
    public static class ExtensionClass
    {
        public static int Mul(this Test1 t1,int a,int b) // extension method
        {
            return a * b;
        }
        public static int Div(this Test1 t1,int a,int b) // extension method
        {
            return (a / b);
        }
    }


}
