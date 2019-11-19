using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace IS403Project1.Models
{
    public class Question
    {
        [DisplayName("Question Code")]
        public int question_Code { get; set; }
        [DisplayName("Question Name")]
        public string question_Name { get; set; }
    }
}