using IS403Project1.Models;
using MissionProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS403Project1.Controllers
{
    public class MissionsController : Controller
    {
        public static List<Mission> lstMissions = new List<Mission>()
        {
        new Mission {MissionID = 1, MissionName = "Russia Moscow", PresidentName = "Garry E. Borders",
            Address = "Muravskaya St1 D, Floor 3 Moscow Moscow 125310 Russia", Language ="Russian",
            Climate = "60°/45°", DominantReligion = "Russian Eastern Orthodox",
            FlagURL = "~/Content/Images/russianflag.png"},
        new Mission {MissionID = 2, MissionName = "Brazil Brasilia", PresidentName = "Mark C. Lundgren",
            Address = "SHIN CA 05 LOTE B1 Salas 304 / 307, Brasilia 71503 - 505 DF, CEP – DF Brazil", Language ="Portuguese",
            Climate = "74°/23°", DominantReligion = "Catholicism",
            FlagURL = "~/Content/Images/mapOfTheWorld.png"},
        new Mission {MissionID = 3, MissionName = "Canada Halifax", PresidentName = "Brian D. Leavitt",
            Address = "202 Brownlow Ave Unit F Bldg F Dartmouth NS B3B 1T5 Canada", Language ="English",
            Climate = "27°/-3°", DominantReligion = "Catholicism",
            FlagURL = "~/Content/Images/LIST_FlagfactsFeb15_Gallery.jpg"}
        };

        public static List<Question> lstQuestions = new List<Question>()
        {
            new Question {question_Code = 1, question_Name = "What our the people like bro?"},
            new Question {question_Code = 2, question_Name = "What should I bring with me to my mission?"},
            new Question {question_Code = 3, question_Name = "How I successfully share the gospel in my mission?"},
            new Question {question_Code = 4, question_Name = "What is the president the current president like?"},
            new Question {question_Code = 5, question_Name = "Which foods should I try to avoid?"}
        };

        // GET: Missions
        public ActionResult Index()
        {
            return View();
        }
    }
}