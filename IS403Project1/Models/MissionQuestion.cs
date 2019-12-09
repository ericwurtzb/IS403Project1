using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IS403Project1.Models
{
    [Table("MissionQuestions")]
    public class MissionQuestion
    {
        [Key]
        public int MissionQuestionID { get; set; }
        public int MissionID { get; set; }
        public int UserID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}