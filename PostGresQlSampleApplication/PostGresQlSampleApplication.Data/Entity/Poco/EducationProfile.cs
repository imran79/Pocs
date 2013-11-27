using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostGresQlSampleApplication.Data
{
    public class EducationProfile 
    {
        public virtual int Id { get; set; }       

        public virtual string College { get; set; }

        public virtual string Degree { get; set; }

        public virtual float percentage { get; set; }

        public virtual DateTime? StartDate { get; set; }

        public virtual DateTime? EndDate { get; set; }

        public virtual Candidate Candidate { get; set; }

    }
}
