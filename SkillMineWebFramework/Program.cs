using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillMineDotNetFramework.Collection;
using SkillMineDotNetFramework.Collection.Generic_Collection;
using SkillMineDotNetFramework.Collection.Generic_Collection.Stack1;
using SkillMineDotNetFramework.OOPS;
using Employee = SkillMineDotNetFramework.Collection.Generic_Collection.Employee;

namespace SkillMineDotNetFramework
{
    class Program
    {
        static void AcceptNames(params string[] names)
        {
            Console.WriteLine("Values to print " + names.Length);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;   // b-> a
            b = temp;
        }
        static void Calculate(int a,int b,out int sum,out int sub,out int multiply)
        {
            sum = a + b;
            sub = a - b;
            multiply = a * b;
        }
        /* static void Main(string[] args)
         {
             *//*            Book b = new Book();
                         b.Id = 1214;
                         b.Name = "Mahabharat";
                         b.Author = "Chetan Bhagat";
                         b.Price = 1000;
                         Console.WriteLine(b);*/
        /*            Employee emp = new Employee( "Emp1", 23000.55);
                    emp.CalculateSalary();
                    Console.WriteLine(emp);
                    Employee emp1 = new Employee("Emp2", 25000);
                    emp1.CalculateSalary();
                    Console.WriteLine(emp1);
                    Employee emp2 = new Employee("Emp3", 30000);
                    emp2.CalculateSalary();
                    Console.WriteLine(emp2);*/



        /*            int a = 10, b = 20, sum, sub, mul;
                        Console.WriteLine($"Before call the method a={a} , b={b}");
                        Swap(ref a, ref b); // referecne  / address
                        Console.WriteLine($"after call the method a={a} , b={b}");

                    Calculate(a,b,out sum,out sub,out mul);
                    Console.WriteLine($"sum ={sum }\nsub ={ sub}\nmul ={ mul}");


                    AcceptNames("Amol", "kishor");
                    AcceptNames("Amol", "Kishor", "Ajay");
                    AcceptNames("Amol", "Kishor", "Suraj", "Rohan","121");*//*


        SalesManager s = new SalesManager("Kishor", 40000, 2000, 1000);
        s.CalculateSalary();
        Console.WriteLine(s);

        Employee1 e = new SalesManager("Rahul", 30000, 1000, 150);
        e.CalculateSalary();
        Console.WriteLine(e);

    }*/
        /*        static void Main(string[] args)
                {
                    Person s = new Person("Choudhary"," Dinesh","Kishor");
                    Console.WriteLine(s);
                }*/
        /*        static void Main(string[] args)
                {
                    Circle c = new Circle(10);
                    c.CalculateArea();
                    Console.WriteLine(c);


                    Rectangle r = new Rectangle(5,4);
                    r.CalculateArea();
                    Console.WriteLine(r);
                }*/
        /*        static void Main(string[] args)
                {
                    Test1 t = new Test1();

                    Console.WriteLine(t.Add(5, 2));
                    Console.WriteLine(t.Sub(5, 2));
                    Console.WriteLine(t.Mul(5, 2));
                    Console.WriteLine(t.Div( 10, 5));
                }*/
        /*        static void Main(string[] args)
                {
                    *//*            Emp[] details= new Emp[] { 
                                new Emp{empid=100,empname="Mukesh",empsalary=10000 } ,
                                new Emp{empid=101,empname="Rohit",empsalary=15000 },
                                new Emp{empid=102,empname="Hitesh",empsalary=20000 }
                                };
                                foreach  (Emp item in details)
                                {
                                    Console.WriteLine($"{item.empid} {item.empsalary} {item.empsalary}");
                                }
                                Stud[] list = new Stud[]
                                {
                                    new Stud(10,"Rohit",85),
                                    new Stud(11,"Suresh",75),
                                    new Stud(12,"Kishor",55)
                                };
                                foreach (Stud l in list)
                                {
                                    Console.WriteLine(l);
                                }*/
        /*            int[,] a = { { 1, 2, 3 }, { 1, 4, 5 }, { 4, 1, 5 }, { 7, 5, 8 } };
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            Console.Write(a[i, j]+" ");
                        }
                        Console.WriteLine();
                    }*//*
        string str1 = "Hello to all ";
        Console.WriteLine(str1.Length);
        string str2 = "welcome to C#";
        //str1.Concat(str2);
        string str = String.Concat(str1, str2);
        Console.WriteLine(str);
        Console.WriteLine(str2);
        bool result = str1.StartsWith("Hello");
        Console.WriteLine(result);
        bool res = str1.EndsWith("everyone");

        bool r = str1.Contains("to");
        Console.WriteLine(r);
        Console.WriteLine(str1.ToUpper());
        Console.WriteLine(str1.ToLower());

        char[] ch = str1.ToCharArray();
        foreach (var item in ch)
        {
            Console.WriteLine(item);
        }
        StringBuilder sb = new StringBuilder("Hello to all");
        double price = 45000;
        sb.AppendFormat(" price is {0:C}", price);
        Console.WriteLine(sb);
        //Console.WriteLine(str1.Trim());

    }*/
        /*        static void Main(string[] args)
                {
                    Department dep = new Department();
                    foreach (Employee d in dep)
                    {
                        Console.WriteLine(d);

                    }
                    Employee e1 = new Employee("Rohit", 45000);
                    Employee e2= new Employee("Mohit", 50000);
                    Employee e3= new Employee("Yogesh", 30000);
                    Employee e4= new Employee("Hitesh", 25000);
                    Employee e5= new Employee("Rahul", 35000);
                    int result = e1.CompareTo(e4);
                }*/
        static void Main(string[] args)
        {
            HashSet<int> list = new HashSet<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            //list.Add(30);

            list.Remove(50);
            // list.Clear();
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

        }
    }

}
