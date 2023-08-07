using CentralLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentralLibrary.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var displayData = _db.Category.ToList();

            return View(displayData);
            
        }
        [HttpGet]
        public async Task<IActionResult> Index(string CategorySearch)
        {
            ViewData["GetCategoryDetails"] = CategorySearch;
            var displayData = from x in _db.Category select x;
            if (!String.IsNullOrEmpty(CategorySearch))
            {
                displayData = displayData.Where(x => x.CategoryName.Contains(CategorySearch));
            }
            return View(await displayData.AsNoTracking().ToListAsync());
        }


        //to create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Add(category);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(category);
        }


        //to edit

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var categoryDetail = await _db.Category.FindAsync(id);
            return View(categoryDetail);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Update(category);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(category);
        }
        //View book details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var categoryDetails = await _db.Category.FindAsync(id);
            return View(categoryDetails);
        }

        //to delete

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {

            var categoryDetails = _db.Category.Where(x => x.Category_id == id).First();
            _db.Remove(categoryDetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");


        }
    }
}
