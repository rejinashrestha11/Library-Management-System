using CentralLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentralLibrary.Controllers
{
    public class LibraryCardController : Controller
    {
        public readonly ApplicationDbContext _db;

        public LibraryCardController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displayData = _db.LibraryCard.ToList();

            return View(displayData);
        }
        [HttpGet]
        public async Task<IActionResult> Index(string LibraryCardSearch)
        {
            ViewData["GetLibraryCardDetails"] = LibraryCardSearch;
            var displayData = from x in _db.LibraryCard select x;
            if (!String.IsNullOrEmpty(LibraryCardSearch))
            {
                displayData = displayData.Where(x => x.FullName.Contains(LibraryCardSearch));
            }
            return View(await displayData.AsNoTracking().ToListAsync());
        }

        //to create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(LibraryCard libraryCard)
        {
            if (ModelState.IsValid)
            {
                _db.Add(libraryCard);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(libraryCard);
        }

        //to edit

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var cardDetail = await _db.LibraryCard.FindAsync(id);
            return View(cardDetail);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(LibraryCard libraryCard)
        {
            if (ModelState.IsValid)
            {
                _db.Update(libraryCard);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(libraryCard);
        }
        //View  details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var cardDetails = await _db.LibraryCard.FindAsync(id);
            return View(cardDetails);
        }

        //to delete

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {

            var cardDetails = _db.LibraryCard.Where(x => x.Card_id == id).First();
            _db.Remove(cardDetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");


        }
    }
}