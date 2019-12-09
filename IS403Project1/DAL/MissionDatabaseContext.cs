using IS403Project1.Models;
using MissionProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IS403Project1.DAL
{
    public class MissionDatabaseContext : DbContext
    {
        public MissionDatabaseContext() : base("MissionDatabaseContext")
        {
        }

        public DbSet<Mission> Missions { get; set; }
        public DbSet<MissionQuestion> MissionQuestions { get; set; }
        public DbSet<User> Users { get; set; }

    }
}