using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCopy
{
    class Test
    {
        public string Name;
        public Test CloneMe(Test t)
        {
            return (Test)this.MemberwiseClone();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test obj1 = new Test();
            obj1.Name = "FirstObject";
            Test obj2 = obj1;
            //Test obj3 = obj1.CloneMe(obj1);
            obj2.Name = "SecondObject";
            Console.WriteLine(obj1.Name);
            //Console.WriteLine(obj3.Name);
            Console.ReadLine();
        }
    }

}
