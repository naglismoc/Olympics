using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Olympics.Models;
using Olympics.Services;
using System.Collections.Generic;

namespace Olympics.Controllers
{
    public class CountryController : Controller
    {

        private CountryDBService _countryDBS;

        public CountryController(CountryDBService countryDBS)
        {
            _countryDBS = countryDBS;
        }


        // GET: AthleteController
        public ActionResult Index()
        {

            return View(_countryDBS.All()); // List<Athlete>, List<Country>, List<Sport>, 
        }

        // GET: AthleteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AthleteController/Create
        public ActionResult Create() // List<Athlete>[0], List<Country>, List<Sport>, 
        {
            return View();
        }

        // POST: AthleteController/Create
        [HttpPost]
        public ActionResult Create(CountryModel country)
        {
            _countryDBS.Save(country);

            return RedirectToAction("Index");
        }

        // GET: AthleteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AthleteController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CountryModel country)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AthleteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AthleteController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, CountryModel country)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
