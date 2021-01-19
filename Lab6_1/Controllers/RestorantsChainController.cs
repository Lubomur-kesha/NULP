using Lab6_1.Models;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Lab6_1.Controllers
{
    public class RestorantsChainController : Controller
    {
        DBModel db = new DBModel();

        // GET: RestorantsCahin
        public ActionResult Index()
        {
            return View(db.Restorants_chain.ToList());
        }

        // GET: RestorantsCahin/Details/5
        public ActionResult Details(int? id)
        {
            return View(db.Restorants_chain.Where(x => x.restorant_chain_id == id).FirstOrDefault());
        }

        // GET: RestorantsCahin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RestorantsCahin/Create
        [HttpPost]
        public ActionResult Create(Restorants_chain restorants_Chain)
        {
            try
            {
                // TODO: Add insert logic here
                db.Restorants_chain.Add(restorants_Chain);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RestorantsCahin/Edit/5
        public ActionResult Edit(int? id)
        {
            return View(db.Restorants_chain.Where(x => x.restorant_chain_id == id).FirstOrDefault());
        }

        // POST: RestorantsCahin/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, Restorants_chain restorants_Chain)
        {
            try
            {
                // TODO: Add update logic here
                db.Entry(restorants_Chain).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RestorantsCahin/Delete/5
        public ActionResult Delete(int? id)
        {
            return View(db.Restorants_chain.Where(x => x.restorant_chain_id == id).FirstOrDefault());
        }

        // POST: RestorantsCahin/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, Restorants_chain restorants_Chain)
        {
            try
            {
                // TODO: Add delete logic here
                restorants_Chain = db.Restorants_chain.Where(x => x.restorant_chain_id == id).FirstOrDefault();
                db.Restorants_chain.Remove(restorants_Chain);
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
