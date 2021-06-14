using BookList.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.Data.Services
{
    public abstract class AbstrackBook : Book
    {

        public abstract IEnumerable<Book> GetAll();
        public abstract Book Get(int id);
        public abstract void Add(Book book);
        public abstract void Update(Book book);
        public abstract void Delete(int id);



    }
}
