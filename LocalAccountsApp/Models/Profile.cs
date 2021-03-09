using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Profiler.Models
{
    public class Profile
    {
        public int DoctorID { get; set; }
        public Nullable<int> HPCSANo { get; set; }
        public Nullable<int> IDNo { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Discipline { get; set; }
        public string Province { get; set; }
        public string Region { get; set; }
    }
}