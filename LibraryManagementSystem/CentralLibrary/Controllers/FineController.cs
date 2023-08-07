using CentralLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentralLibrary.Controllers
{
    public class FineController : Controller
    {
        public readonly ApplicationDbContext _db;

        public FineController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displayData = _db.Fine.ToList();

            return View(displayData);
        }


        //to create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Fine fine)
        {
            if (ModelState.IsValid)
            {
                _db.Add(fine);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(fine);
        }

        //to edit

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var fineDetail = await _db.Fine.FindAsync(id);
            return View(fineDetail);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Fine fine)
        {
            if (ModelState.IsValid)
            {
                _db.Update(fine);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(fine);
        }
        //View book details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var fineDetails = await _db.Fine.FindAsync(id);
            return View(fineDetails);
        }

        //to delete

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {

            var fineDetails = _db.Fine.Where(x => x.Fine_id == id).First();
            _db.Remove(fineDetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");


        }
    }
}
