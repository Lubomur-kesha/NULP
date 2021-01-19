using Lab6_1.Models;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Lab6_1.Controllers
{
    public class CitiesController : Controller
    {
        DBModel db = new DBModel();
        // GET: Cities
        public ActionResult Index()
        {
            return View(db.cities.ToList());
        }

        // GET: Cities/Details/5
        public ActionResult Details(int? id)
        {
            return View(db.cities.Where(x => x.city_id == id).FirstOrDefault());
        }

        // GET: Cities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cities/Create
        [HttpPost]
        public ActionResult Create(cities cit)
        {
            try
            {
                // TODO: Add insert logic here
                db.cities.Add(cit);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cities/Edit/5
        public ActionResult Edit(int? id)
        {
            return View(db.cities.Where(x => x.city_id == id).FirstOrDefault());
        }

        // POST: Cities/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, cities cit)
        {
            try
            {
                // TODO: Add update logic here
                db.Entry(cit).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cities/Delete/5
        public ActionResult Delete(int? id)
        {
            return View(db.cities.Where(x => x.city_id == id).FirstOrDefault());
        }

        // POST: Cities/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, cities cit)
        {
            try
            {
                // TODO: Add delete logic here
                cit = db.cities.Where(x => x.city_id == id).FirstOrDefault();
                db.cities.Remove(cit);
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
