using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookList.Data.Models;
using BookList.Data.Services;

namespace BookList.Web.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookData db;


        public BooksController()
        {
            db = new MemoryBookData();
        }

        // GET: Books
        [HttpGet]
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
    }
}