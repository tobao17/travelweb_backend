using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doan_cnpm.Models.DATA;
namespace doan_cnpm.Controllers
{
   
    public class USERController : Controller
    {
        TRAVELCONTEXT db = new TRAVELCONTEXT();
        // GET: USER
        public ActionResult Index()
        {
            return View(db.USER.ToList());
        }

        // GET: USER/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: USER/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: USER/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: USER/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: USER/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: USER/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: USER/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
