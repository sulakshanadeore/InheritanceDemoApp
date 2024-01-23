using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceLibrary
{
    public class Employee
    {
        //Auto implemented --- automatically implemented--- 
        internal int Empid {  get; set; }
        internal string Ename { get; set; }
        internal DateTime JoiningDate { get; set; }
        internal string city { get; set; }


        static Employee()
        {
            Console.WriteLine("Static of employee");
        }
        public Employee()//base of the building
        {
            Console.WriteLine("Ok.. calling default constructor");

        }
        public Employee(int empid,string ename,string city):this(city)
        {
            Empid = empid;   
            Ename = ename;
        }

        public Employee(DateTime joiningdate) 
        {
        JoiningDate = joiningdate;
            
        }
    public Employee(string city,DateTime joiningdate):this(joiningdate)
        {
        this.city= city;    
        }

        public Employee(string city)
        {
            this.city = city;
        }

        public Employee(int empid,string ename,string city,DateTime joiningdate):this(empid,ename,city)
        {
            //Empid = empid;
            //Ename = ename;
            JoiningDate = joiningdate;
        


        
        }
        public float BasicSalary { get; set; }
        public Employee(int empid,float basicSal)
        {
            this.Empid=empid;
            BasicSalary = basicSal;
        }

        public double CalculateSalary()
        {
          return   BasicSalary + (BasicSalary * .10) + 1000;
        
        
        }


        public virtual void CalculateSalary(string emprole, int ExpInYears=1)
        {
            Console.WriteLine(emprole);
            Console.WriteLine(ExpInYears);


        }

        public void DisplayAllEmpployeeDetails()
        {
            Console.WriteLine(this.Empid);
            Console.WriteLine(this.Ename);
            Console.WriteLine(city);
            Console.WriteLine(JoiningDate);
        }




    }
}
