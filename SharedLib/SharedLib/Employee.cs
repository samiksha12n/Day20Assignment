using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib
{
    public class Employee
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public void AddEmp()
        {
            
            Console.WriteLine("Enter Employee Id");
            Id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Employee Name");
            Name=Console.ReadLine();
            Console.WriteLine("Enter the Salary of the Employee");
            Salary=double.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Id of Employee:\t"+Id);
            Console.WriteLine("Name of Employee:\t"+Name);
           Console.WriteLine("Salary:\t"+Salary);
            
        }
    }
}
