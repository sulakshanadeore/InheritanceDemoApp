using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceLibrary;
namespace InheritanceDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.Empid = 123;
            //employee.Ename = "Sarika";
            //employee.JoiningDate = new DateTime(2024, 01, 22);
            //employee.City = "Mumbai";

            //Employee employee = new Employee(123, "Savita", "Bangalore", new DateTime(2024, 01, 23));
            //Employee emp1 = new Employee();
            //Employee emp2 = new Employee(new DateTime(2024, 01, 23), "Pune");
            //Employee emp3 = new Employee(13, "Kruthika");
            //Employee emp4 = new Employee(23, 12000);
            //Console.WriteLine("---------------------");
            //employee.CalculateSalary("Manager");
            //Console.WriteLine("---------------------");


            //SeniorEmployee employee = new SeniorEmployee(12, "Akshada", "Pune", DateTime.Today);
            
            //Console.WriteLine("Printing back...");
            ////Console.WriteLine(employee.Empid);
            //Console.WriteLine(employee.Ename);
            //Console.WriteLine(employee.City);
            //Console.WriteLine(employee.JoiningDate);
            //employee.DisplayAllEmpployeeDetails();
            //emp1.DisplayAllEmpployeeDetails();
            //emp2.DisplayAllEmpployeeDetails();
            //emp3.DisplayAllEmpployeeDetails();
            
            OnlyAdd onlyAdd = new OnlyAdd();    
            int ans=onlyAdd.Subtract(1, 2);
            Console.WriteLine(ans);


            Console.Read();
        }
    }
}
