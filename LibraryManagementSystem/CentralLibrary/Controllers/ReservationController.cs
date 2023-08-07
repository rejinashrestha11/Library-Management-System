using CentralLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentralLibrary.Controllers
{
    public class ReservationController : Controller
    {
        public readonly ApplicationDbContext _db;

        public ReservationController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displayData = _db.Reservation.ToList();

            return View(displayData);
        }


        //to create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Reservation res)
        {
            if (ModelState.IsValid)
            {
                _db.Add(res);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(res);
        }

        //to edit

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var resDetail = await _db.Reservation.FindAsync(id);
            return View(resDetail);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Reservation res)
        {
            if (ModelState.IsValid)
            {
                _db.Update(res);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(res);
        }
        //View book details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var resDetails = await _db.Reservation.FindAsync(id);
            return View(resDetails);
        }

        //to delete

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {

            var resDetails = _db.Reservation.Where(x => x.Reservation_id == id).First();
            _db.Remove(resDetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");


        }
    }
}
