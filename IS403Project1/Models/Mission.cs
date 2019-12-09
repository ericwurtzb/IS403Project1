﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MissionProject.Models
{
    [Table("Missions")]
    public class Mission
    {
        [Key]
        public int MissionID { get; set; }

        [DisplayName("Name of Mission")]
        public string MissionName { get; set; }

        [DisplayName("Mission President")]
        public string PresidentName { get; set; }

        [DisplayName("Mission Address")]
        public string Address { get; set; }

        [DisplayName("Mission Language")]
        [StringLength(20, ErrorMessage = "Entry must be under 20 characters")]
        public string Language { get; set; }

        [DisplayName("General Climate")]
        public string Climate { get; set; }

        [DisplayName("Dominant Religion")]
        public string DominantReligion { get; set; }

        [DisplayName("Flag")]
        public string Flag { get; set; }

    }
}