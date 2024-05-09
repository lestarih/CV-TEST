using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        // POST: CV/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CV cv)
        {
            if (ModelState.IsValid)
            {
                // Save CV details to database or perform any other actions
                // For demonstration purposes, we'll just redirect to ShowCV action
                return RedirectToAction("ShowCV", cv);
            }

            return View(cv);
        }

        // GET: CV/ShowCV
        public ActionResult ShowCV(CV cv)
        {
            // Display CV details on ShowCV page
            return View(cv);
        }
    }
}