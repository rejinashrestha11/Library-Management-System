using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CentralLibrary.Models;

namespace CentralLibrary.Controllers
{
    public class LibraryStaffController : Controller
    {
        public readonly ApplicationDbContext _db;

        public LibraryStaffController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displayData = _db.LibraryStaff.ToList();

            return View(displayData);
        }
        [HttpGet]
        public async Task<IActionResult> Index(string LibraryStaffSearch)
        {
            ViewData["GetLibraryStaffDetails"] = LibraryStaffSearch;
            var displayData = from x in _db.LibraryStaff select x;
            if (!String.IsNullOrEmpty(LibraryStaffSearch))
            {
                displayData = displayData.Where(x => x.StaffName.Contains(LibraryStaffSearch));
            }
            return View(await displayData.AsNoTracking().ToListAsync());
        }

        //to create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(LibraryStaff LibraryStaff)
        {
            if (ModelState.IsValid)
            {
                _db.Add(LibraryStaff);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(LibraryStaff);
        }

        //to edit

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var LibraryStaffDetail = await _db.LibraryStaff.FindAsync(id);
            return View(LibraryStaffDetail);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(LibraryStaff LibraryStaff)
        {
            if (ModelState.IsValid)
            {
                _db.Update(LibraryStaff);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(LibraryStaff);
        }
        //View details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var LibraryStaffDetails = await _db.LibraryStaff.FindAsync(id);
            return View(LibraryStaffDetails);
        }

        //to delete

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {

            var LibraryStaffDetails = _db.LibraryStaff.Where(x => x.Staff_id == id).First();
            _db.Remove(LibraryStaffDetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");


        }
    }
}

