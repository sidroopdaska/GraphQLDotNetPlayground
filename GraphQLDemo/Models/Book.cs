using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Models
{
    public class Book
    {
        public string Isbn { get; set; }

        public string Name { get; set; }

        public Author Author { get; set; }

        public Publisher Publisher { get; set; }
    }
}
