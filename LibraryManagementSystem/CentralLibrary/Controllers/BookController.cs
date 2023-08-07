using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CentralLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace CentralLibrary.Controllers
{
    public class BookController : Controller
    {

        public readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displayData = _db.BookTable.ToList();

            return View(displayData);
        }
        [HttpGet]
        public async Task<IActionResult> Index(string BookSearch)
        {
            ViewData["GetBookDetails"] = BookSearch;
            var displayData = from x in _db.BookTable select x;
            if (!String.IsNullOrEmpty(BookSearch))
            {
                displayData = displayData.Where(x => x.BookName.Contains(BookSearch));
            }
            return View(await displayData.AsNoTracking().ToListAsync());
        }

        //to create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _db.Add(book);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        //to edit

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var bookDetail = await _db.BookTable.FindAsync(id);
            return View(bookDetail);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _db.Update(book);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(book);
        }
        //View book details
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }
            var bookDetails = await _db.BookTable.FindAsync(id);
            return View(bookDetails);
        }

        //to delete
        
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {

            var bookDetails = _db.BookTable.Where(x => x.Book_id == id).First();
                _db.Remove(bookDetails);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
         
            
        }
    }
}
