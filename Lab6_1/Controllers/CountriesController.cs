using Lab6_1.Models;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Lab6_1.Controllers
{
    public class CountriesController : Controller
    {
        DBModel db = new DBModel();
        // GET: Countries
        public ActionResult Index()
        {
            return View(db.countries.ToList());
        }

        // GET: Countries/Details/5
        public ActionResult Details(int? id)
        {
            return View(db.countries.Where(x => x.country_id == id).FirstOrDefault());
        }

        // GET: Countries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Countries/Create
        [HttpPost]
        public ActionResult Create(countries countr)
        {
            try
            {
                // TODO: Add insert logic here
                db.countries.Add(countr);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Countries/Edit/5
        public ActionResult Edit(int? id)
        {
            return View(db.countries.Where(x => x.country_id == id).FirstOrDefault());
        }

        // POST: Countries/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, countries countr)
        {
            try
            {
                // TODO: Add update logic here
                db.Entry(countr).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Countries/Delete/5
        public ActionResult Delete(int? id)
        {
            return View(db.countries.Where(x => x.country_id == id).FirstOrDefault());
        }

        // POST: Countries/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, countries countr)
        {
            try
            {
                // TODO: Add delete logic here
                countr = db.countries.Where(x => x.country_id == id).FirstOrDefault();
                db.countries.Remove(countr);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
