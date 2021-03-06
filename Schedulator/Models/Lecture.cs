﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schedulator.Models
{
    public class Lecture
    {
        public int LectureID { get; set; }
        public string LectureLetter { get; set; }
        public string Teacher { get; set; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }
        public string FirstDay { get; set; }
        public string SecondDay { get; set; }
        public string ClassRoomNumber { get; set; }

        public virtual Semester Semester { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<Tutorial> Tutorials { get; set; }
        public virtual ICollection<Lab> Labs { get; set; }
    }
}