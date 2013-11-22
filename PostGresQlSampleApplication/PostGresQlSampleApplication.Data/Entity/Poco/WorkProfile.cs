using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostGresQlSampleApplication.Data
{
   public class WorkProfile 
    {

       public virtual int Id { get; set; }

       public int CandidateId { get; set; }

       public string Employer { get; set; }

       public DateTime? WorkStartDate { get; set; }

       public DateTime? WorkEndDate { get; set; }

       public double Salary { get; set; }

       public string Designation { get; set; }

       public string ReasonForLeaving { get; set; }

    }
}
