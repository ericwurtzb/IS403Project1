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
        public static List<Mission> lstMissions = new List<Mission>();
    
        // GET: Missions
        public ActionResult Index()
        {
            return View();
        }
    }
}