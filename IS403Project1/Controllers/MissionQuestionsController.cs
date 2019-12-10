using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using IS403Project1.DAL;
using IS403Project1.Models;

namespace IS403Project1.Controllers
{
    public class MissionQuestionsController : Controller
    {
        private MissionDatabaseContext db = new MissionDatabaseContext();

        // GET: MissionQuestions
        [Authorize]
        public ActionResult Index(int id)
        {
            ViewData["id"] = id;
            return View(db.MissionQuestions.Where(x => x.MissionID == id));
        }

        // GET: MissionQuestions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissionQuestion missionQuestion = db.MissionQuestions.Find(id);
            if (missionQuestion == null)
            {
                return HttpNotFound();
            }
            return View(missionQuestion);
        }

        // GET: MissionQuestions/Create
        public ActionResult Create(int id)
        {
            string cookieName = FormsAuthentication.FormsCookieName; //Find cookie name
            HttpCookie authCookie = HttpContext.Request.Cookies[cookieName]; //Get the cookie by it's name
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value); //Decrypt it
            string username = ticket.Name; //Username is here!
            ViewData["id"] = id;

            IEnumerable<User> currentUser =
                 db.Database.SqlQuery<User>(
             "Select * " +
             "FROM [Users] " +
             "WHERE UserEmail = '" + username + "'"
            );


            ViewData["id"] = id;
            ViewData["userid"] = currentUser.First().UserID;
            return View();
        }

        // POST: MissionQuestions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MissionQuestionID,MissionID,UserID,Question,Answer")] MissionQuestion missionQuestion)
        {
            if (ModelState.IsValid)
            {
                db.MissionQuestions.Add(missionQuestion);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = missionQuestion.MissionID });
            }

            return View(missionQuestion);
        }

        // GET: MissionQuestions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissionQuestion missionQuestion = db.MissionQuestions.Find(id);
            if (missionQuestion == null)
            {
                return HttpNotFound();
            }
            return View(missionQuestion);
        }

        // POST: MissionQuestions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MissionQuestionID,MissionID,UserID,Question,Answer")] MissionQuestion missionQuestion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(missionQuestion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", new { id = missionQuestion.MissionID });
            }
            return View(missionQuestion);
        }

        // GET: MissionQuestions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissionQuestion missionQuestion = db.MissionQuestions.Find(id);
            if (missionQuestion == null)
            {
                return HttpNotFound();
            }
            return View(missionQuestion);
        }

        // POST: MissionQuestions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MissionQuestion missionQuestion = db.MissionQuestions.Find(id);
            db.MissionQuestions.Remove(missionQuestion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
