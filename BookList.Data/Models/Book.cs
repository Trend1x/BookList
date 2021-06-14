using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateAdded { get; set; }
        public string ISBN { get; set; }

        public bool IsValidISBN()
        {
            //TODO

            return true;

        }
    }
}
