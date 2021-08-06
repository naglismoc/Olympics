using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Olympics.Models;
using Olympics.Services;
using System.Collections.Generic;

namespace Olympics.Controllers
{
    public class AthleteController : Controller
    {
        private ParticipantsService _participants;


        public AthleteController(ParticipantsService participants)
        {
            _participants = participants;
        }



        // GET: AthleteController

        public ActionResult Index()
        {

            return View(_participants.All()); // List<Athlete>, List<Country>, List<Sport>, 
        }




        // GET: AthleteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AthleteController/Create
        public ActionResult Create() // List<Athlete>[0], List<Country>, List<Sport>, 
        {
            return View(_participants.New());
        }

        // POST: AthleteController/Create
        [HttpPost]
        public ActionResult Create(ParticipantsModel participants)
        {
            _participants.SaveAthlete(participants);

            return RedirectToAction("Index");
        }

        // GET: AthleteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AthleteController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
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
        public ActionResult Delete(int id, IFormCollection collection)
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
