using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary
{
    public class SeniorEmployee:Employee
    {
        static SeniorEmployee() {
            Console.WriteLine("Senior Employee static constructor");
        }
        public SeniorEmployee()//Floor
        {
            Console.WriteLine("Default of Senior");

        }

        public int Deptno { get; set; }
        public SeniorEmployee(int deptno)
        {
            Console.WriteLine("Parameterised of senior...");
            Deptno = deptno;    
        }

        public SeniorEmployee(int empid, string ename, string city, DateTime joiningdate):base(empid,ename,city,joiningdate)
        {
            //base.Empid = empid;
            //base.Ename = ename;
            //base.city = city;
            //base.JoiningDate= joiningdate;
        }

        public new void CalculateSalary(string emprole, int ExpInYears = 1)
        {
            if (emprole == "PM")
            {
                Console.WriteLine("Project Manager is a Technical person");

            }
            else
            {
                Console.WriteLine("Non technical senior employee..");
            }
        
        }

        public int TravellingAllowance { get; set; }

    }
}
