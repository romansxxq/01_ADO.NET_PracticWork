using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ADO.NET_PracticWork
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public override string ToString()
        {
            return $"Full name: {Name}";
        }

    }
    public class Sellers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set;}
    }
}
