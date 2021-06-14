﻿using BookList.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.Data.Services
{
    public interface IBookData
    {
        IEnumerable<Book> GetAll();
        Book Get(int id);
        void Add(Book book);
        void Update(Book book);
        void Delete(int id);
    }
}
