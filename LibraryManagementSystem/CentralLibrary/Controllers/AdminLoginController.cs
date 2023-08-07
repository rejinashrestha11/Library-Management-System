using CentralLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CentralLibrary.Controllers
{
    public class AdminLoginController : Controller
    {
        public readonly ApplicationDbContext _db;

        public AdminLoginController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(AdminLogin login)
        {
            var user = _db.AdminLogin.Where(x => x.Username == login.Username && x.Password == login.Password).FirstOrDefault();
            if (user != null)
            {
                
                return RedirectToAction("Index");
              
            }
            else
            {
                ModelState.AddModelError("", "Invalid Username and Password");
                await _db.SaveChangesAsync();
                return View();

            }
        }
    }
}