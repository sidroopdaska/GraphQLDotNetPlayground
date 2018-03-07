using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Models
{
    public class Publisher
    {
        public Publisher()
        {
            Books = new Book[] { };
            Authors = new Author[] { };
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Book[] Books { get; set; }

        public Author[] Authors { get; set; }
    }
}
