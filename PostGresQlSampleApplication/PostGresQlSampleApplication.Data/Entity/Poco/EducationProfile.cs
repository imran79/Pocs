using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostGresQlSampleApplication.Data
{
    public class EducationProfile 
    {
        public virtual int Id { get; set; }

        public int CandidateId { get; set; }

        public string College { get; set; }

        public string Degree { get; set; }

        public float percentage { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

    }
}
