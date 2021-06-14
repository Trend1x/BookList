using BookList.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.Data.Services
{
    public class MemoryBookData : IBookData
    {
        List<Book> books;

        public MemoryBookData()
        {
            books = new List<Book>();
            Add(new Book() { Title = "Eloquent JavaScript, Second Edition", ISBN = "9781593275846" });
            Add(new Book() { Title = "Learning JavaScript Design Patterns", ISBN = "9781449331818" });
            Add(new Book() { Title = "Speaking JavaScript", ISBN = "9781449365035" });
            Add(new Book() { Title = "Programming JavaScript Applications", ISBN = "9781491950296" });
            Add(new Book() { Title = "Understanding ECMAScript 6", ISBN = "9781593277574" });
            Add(new Book() { Title = "You Don't Know JS", ISBN = "9781491904244" }); 
            Add(new Book() { Title = "Git Pocket Guide", ISBN = "9781449325862" });
            Add(new Book() { Title = "Designing Evolvable Web APIs with ASP.NET", ISBN = "9781449337711" });

        }

        public void Add(Book book)
        {
            if (book.IsValidISBN())
            {
                books.Add(book);
                book.Id = books.Max(b => b.Id) + 1;
                book.DateAdded = DateTime.Now;
            }
        }

        public void Delete(int id)
        {
            var book = Get(id);
            if (book != null)
            {
                books.Remove(book);
            }
        }

        public Book Get(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return books.OrderBy(b => b.Title);
        }

        public void Update(Book book)
        {
            var existing = Get(book.Id);
            if (existing != null)
            {
                existing.Title = book.Title;
                existing.ISBN = book.ISBN;
                existing.DateAdded = book.DateAdded;
            }
        }
    }
}
