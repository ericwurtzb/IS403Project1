using IS403Project1.Models;
using MissionProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS403Project1.Controllers
{
    public class MissionsOldController : Controller
    {
        public static List<Mission> lstMissions = new List<Mission>()
        {
        new Mission {MissionID = 1, MissionName = "Russia Moscow", PresidentName = "Garry E. Borders",
            Address = "Muravskaya St1 D, Floor 3 Moscow Moscow 125310 Russia", Language ="Russian",
            Climate = "60°/45°", DominantReligion = "Russian Eastern Orthodox",
            Flag = "/Content/Images/Brazil.png"},
        new Mission {MissionID = 2, MissionName = "Brazil Brasilia", PresidentName = "Mark C. Lundgren",
            Address = "SHIN CA 05 LOTE B1 Salas 304 / 307, Brasilia 71503 - 505 DF, CEP – DF Brazil", Language ="Portuguese",
            Climate = "74°/23°", DominantReligion = "Catholicism",
            Flag = "/Content/Images/Canada.png"},
        new Mission {MissionID = 3, MissionName = "Canada Halifax", PresidentName = "Brian D. Leavitt",
            Address = "202 Brownlow Ave Unit F Bldg F Dartmouth NS B3B 1T5 Canada", Language ="English",
            Climate = "27°/-3°", DominantReligion = "Catholicism",
            Flag = "/Content/Images/Russia.jpg"}
        };


        // GET: Missions
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult DisplayMission(string id)
        {
            int idNum = Convert.ToInt32(id);

            //ViewBag.Question1 = lstQuestions[0].question_Name;

            return View(lstMissions.Find(x => x.MissionID == idNum));
        }
    }
}