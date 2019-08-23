using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcareForYou_Iteration_1.Models;
using System.Data;
using System.Data.Entity;
using System.Net;

namespace WelcareForYou_Iteration_1.Controllers
{
    public class QuestionnaireController : Controller
    {
        private Iteration1ModelContainer db = new Iteration1ModelContainer();

        // GET: Questionnaire
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Result(Int32 salary, Int32 numOfPeople, Int32 currentRent)
        {
            var acceptableRent = salary * 0.3;
            List<Housing> housingList = db.Housings.Where(x => x.MediumPrice <= acceptableRent)
                                                .Where(x => x.NumOfRoom >= numOfPeople)
                                                .OrderBy(x => x.MediumPrice).Take(6).ToList();
            ViewBag.item1diff = housingList[0].MediumPrice/ currentRent;
            ViewBag.item2diff = housingList[0].MediumPrice / currentRent;
            ViewBag.item3diff = housingList[0].MediumPrice / currentRent;
            ViewBag.item4diff = housingList[0].MediumPrice / currentRent;
            ViewBag.item5diff = housingList[0].MediumPrice / currentRent;
            ViewBag.item6diff = housingList[0].MediumPrice / currentRent;
            return View(housingList);
        }
    }
}