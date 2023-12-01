using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLib;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operation");
            Console.WriteLine("1.Add Employee 2.Add Project");
            int op=int.Parse(Console.ReadLine());
            Employee obj=new Employee();
            Manager manager=new Manager();
            switch(op)
            {
                case 1:
                    {
                        obj.AddEmp();
                        obj.Display();
                        break;
                    }
                case 2:
                    {
                        manager.AddProject();
                        manager.DiplayProject();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Choice!!!");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
