using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int p = 100;
                int* ptr;
                ptr = &p;
                Console.WriteLine("I m in the unsafe code block ");
                Console.WriteLine("The value of p= " + *ptr);
            
            }
            Employee emp = new Employee();
            emp.Empid = 1023;
            Console.WriteLine(emp.Empid);


            Console.ReadLine();

            //normal code
        }
    }

    class Employee
    {
        public int Empid { get; set; }
    }
}
