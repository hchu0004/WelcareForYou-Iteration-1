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
        public ActionResult Result(String salary, String numOfPeople1, String currentRent1)
        {
            var numOfPeople = int.Parse(numOfPeople1);
            var currentRent = int.Parse(currentRent1);
            var acceptableRent = int.Parse(salary) * 0.3;

            List<Housing> housingList = db.Housings.Where(x => x.MediumPrice <= acceptableRent)
                                                .Where(x => x.NumOfRoom >= numOfPeople)
                                                .OrderByDescending(x => x.MediumPrice).Take(6).ToList();

            List<int> diffList = new List<int>();
            var item1diff = housingList[0].MediumPrice * 100 / currentRent - 100;
            var item2diff = housingList[1].MediumPrice * 100 / currentRent - 100;
            var item3diff = housingList[2].MediumPrice * 100 / currentRent - 100;
            var item4diff = housingList[3].MediumPrice * 100 / currentRent - 100;
            var item5diff = housingList[4].MediumPrice * 100 / currentRent - 100;
            var item6diff = housingList[5].MediumPrice * 100 / currentRent - 100;                       
            diffList.Add(item1diff);
            diffList.Add(item2diff);
            diffList.Add(item3diff);
            diffList.Add(item4diff);
            diffList.Add(item5diff);
            diffList.Add(item6diff);
            ViewData["diff"] = diffList;

            return View(housingList);
        }

        protected override void HandleUnknownAction(string actionName)
        {
            Response.Redirect("~/Home/Index");
            base.HandleUnknownAction(actionName);
        }
    }
}