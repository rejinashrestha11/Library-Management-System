using CentralLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentralLibrary.Controllers
{
    public class PublicationController : Controller
    {
        public readonly ApplicationDbContext _db;

        public PublicationController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displayData = _db.Publication.ToList();

            return View(displayData);
        }
        [HttpGet]
        public async Task<IActionResult> Index(string PublicationSearch)
        {
            ViewData["GetPublicationDetails"] = PublicationSearch;
            var displayData = from x in _db.Publication select x;
            if (!String.IsNullOrEmpty(PublicationSearch))
            {
                displayData = displayData.Where(x => x.PublicationName.Contains(PublicationSearch));
            }
            return View(await displayData.AsNoTracking().ToListAsync());
        }

        //to create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Publication publication)
        {
            if (ModelState.IsValid)
            {
                _db.Add(publication);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(publication);
        }

        //to edit

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var publicationDetail = await _db.Publication.FindAsync(id);
            return View(publicationDetail);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Publication publication)
        {
            if (ModelState.IsValid)
            {
                _db.Update(publication);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(publication);
        }
        //View  details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var publicationDetails = await _db.Publication.FindAsync(id);
            return View(publicationDetails);
        }

        //to delete

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {

            var publicationDetails = _db.Publication.Where(x => x.Publication_id == id).First();
            _db.Remove(publicationDetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");


        }
    }
}