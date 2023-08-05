using GroceryWeb.Data;
using GroceryWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryWeb.Controllers
{
    public class ListController : Controller
    {
        private readonly ApplicationDbContext db;

        public ListController(ApplicationDbContext appDb)
        {
                db = appDb;
        }

        public IActionResult Index()
        {
            IEnumerable<List> listObj = db.Lists;
            return View(listObj);
        }
        public IActionResult Create( )
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Create(List lst)
        {
            if (ModelState.IsValid)
            {
                db.Lists.Add(lst);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lst);
        }
        public IActionResult Edit(int? id)
        {
            var EditDb = db.Lists.Find(id);
            return View(EditDb);
        }
        [HttpPost]
        public IActionResult Edit(List lst)
        {
            if (ModelState.IsValid)
            {
                db.Lists.Update(lst);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lst);
        }
        public IActionResult Delete(int? id)
        {
            var DeleteDb = db.Lists.Find(id);
            return View(DeleteDb);

        }
        [HttpPost]
        
        public IActionResult DeletePost(int? id)
        {
            var Dlte = db.Lists.Find(id);
            db.Lists.Remove(Dlte);
            db.SaveChanges();
            return RedirectToAction("Index");    
        }
    }
}
