using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPSExample_ParameterizedCostructor
{
    internal class Program
    {
        static void Main(string[] args)
        {//For parameterized constructor you must pass the values from object creation time.otherwise it will throw error ata compiletime like please pass the values to paramerterized constructor.
            employee emp1 = new employee(121, "rama", 1000);//data assigned to parameterized constructor.
            emp1.displayempinfo();

            Console.WriteLine("emp no is:" + emp1.eno);
            Console.WriteLine("emp name is:" + emp1.ename);
            Console.WriteLine("salry is:" + emp1.esal);
            int objectcodeemp1= emp1.GetHashCode();//for every object new hashcode will geneate
            Console.WriteLine("object hashcode address is"+objectcodeemp1);
            employee emp2 = new employee(122, "raju", 2000);
            emp2.displayempinfo();
            int objectcodeemp2 = emp2.GetHashCode();//for every object new hashcode will geneate
            Console.WriteLine("object hashcode address is" + objectcodeemp2);
            Console.ReadLine();
        }
    }
}
