using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Book
    {
        //properties

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }

        public string GetName()
        {
            return $"{Name}";
        }

        public string GetPrice()
        {
            return $"£{Price}";
        }

        public string GetAuthor()
        {
            return $"{Author}";
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
