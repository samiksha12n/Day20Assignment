using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class Manager
    {
        public int Id { get; private set; }
        public string Title { get; set; }

        public void AddProject()
        {
            Console.WriteLine("Enter the Id");
            Id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Project Title");
            Title=Console.ReadLine();
        }
        public void DiplayProject()
        {
            Console.WriteLine("Project Id:\t" + Id);
            Console.WriteLine("Project Name:\t"+Title);
        }
    }
}
