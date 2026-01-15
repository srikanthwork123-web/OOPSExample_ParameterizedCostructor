using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample_ParameterizedCostructor
{
    internal class employee
    {//TO assign the data to instance variables we are creating the parameterized constructor and assign the data.
      public  int eno;
        public string ename;
        public int esal;
//Synatx:accessmodier classname(datatype variablename,datatype variablename,........)
        public employee(int empno, string empname, int empsal)//parameterized constructor
        {//constructor name and class should be same.
            eno = empno;
            ename = empname;
            esal = empsal;
          
        }
        public void displayempinfo()
        {
            Console.WriteLine("emp no is:" + eno);
            Console.WriteLine("emp name is:" + ename);
            Console.WriteLine("salry is:" + esal);
        }
    }
}
