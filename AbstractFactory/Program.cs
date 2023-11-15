using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface ISource
    {
        string GetSourceName();
    }

    public interface ICourse
    {
        string GetCourseName();
        int GetCourseFee();
        string GetCourseDuration();
    }

    public class FrontEndCourse : ICourse
    {
        public string GetCourseName()
        {
            return "HTML";
        }
        public string GetCourseDuration()
        {
            return "6 Months";
        }
        public int GetCourseFee()
        {
            return 2000;
        }
    }
    public class BackEndCourse : ICourse
    {
        public string GetCourseDuration()
        {
            return "6 Months";
        }
        public int GetCourseFee()
        {
            return 1000;
        }
        public string GetCourseName()
        {
            return "C#";
        }
    }
    // The ProductA2 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following Online Product Belongs to the Source product family
    public class Online : ISource
    {
        public string GetSourceName()
        {
            return "Dot Net Tutorials";
        }
    }
    public class Offline : ISource
    {
        public string GetSourceName()
        {
            return "Java Tutorials";
        }
    }
    // The AbstractFactory interface
    // The Abstract Factory interface declares a set of methods that return different abstract products. 
    // These products are called a family. 
    // A family of products may have several variants
    public interface ISourceCourseFactory
    {
        //Abstract Product A
        ISource GetSource();
        //Abstract Product B
        ICourse GetCourse();
    }
    public class OnlineSourceCourseFactory : ISourceCourseFactory
    {
        public ISource GetSource()
        {
            return new Online();
        }
        public ICourse GetCourse()
        {
            return new BackEndCourse();
        }
    }

    public class OfflineSourceCourseFactory : ISourceCourseFactory
    {
        public ISource GetSource()
        {
            return new Offline();
        }
        public ICourse GetCourse()
        {
            return new FrontEndCourse();
        }
    }
    public  class Program
    {

        static void Main(string[] args)
        {
            ISourceCourseFactory offlineSourceCourseFactory = new OfflineSourceCourseFactory();
            //offlineSourceCourseFactory.GetCourse() will create and return FrondEndCourse object
            var course = offlineSourceCourseFactory.GetCourse();
            Console.WriteLine("Front End Course and Source Details");
            Console.WriteLine(course.GetCourseName());
            Console.WriteLine(course.GetCourseFee());
            Console.WriteLine(course.GetCourseDuration());
            //offlineSourceCourseFactory.GetSource() will create and return Offline object
            var source = offlineSourceCourseFactory.GetSource();
            Console.WriteLine(source.GetSourceName());
            //Same steps for Online Course and Source Details
            Console.WriteLine("\n----------------------\n");
            Console.WriteLine("Back End Course and Source Details");
            ISourceCourseFactory onlineSourceCourseFactory = new OnlineSourceCourseFactory();
            course = onlineSourceCourseFactory.GetCourse();
            Console.WriteLine(course.GetCourseName());
            Console.WriteLine(course.GetCourseFee());
            Console.WriteLine(course.GetCourseDuration());
            source = onlineSourceCourseFactory.GetSource();
            Console.WriteLine(source.GetSourceName());
            Console.ReadKey();
        }
    }
}
