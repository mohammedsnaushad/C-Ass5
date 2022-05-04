using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSal { get; set; }
        public string EmpLoc { get; set; }


    }

    internal class ArrayListSample
    {
        static void Main(string[] args)
        {
            //object initilizer or collection initilizer
            //ArrayList e = new ArrayList();//non generic

            ArrayList e = new ArrayList()
            {
                    new Employee{EmpId=111,EmpName="Ramesh",EmpSal=25000,EmpLoc="Coch"},
                    new Employee{EmpId=112,EmpName="Suresh",EmpSal=30000,EmpLoc="Triv"},
                    new Employee{EmpId=113,EmpName="Christy",EmpSal=29000,EmpLoc="Bangl"},
                    new Employee{EmpId=114,EmpName="Saranya",EmpSal=40000,EmpLoc="Bangl"},
                    new Employee{ EmpId=115, EmpName="Asif"},
            };
            foreach (Employee i in e)
            {
                Console.WriteLine(i.EmpId + " " + i.EmpName + " " + i.EmpSal + " " + i.EmpLoc);
            }
            Console.ReadKey();
        }
    }
}