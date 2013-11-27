using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostGresQlSampleApplication.Data
{
   public class WorkProfile 
    {

       public virtual int Id { get; set; }      

       public virtual string Employer { get; set; }

       public virtual DateTime? WorkStartDate { get; set; }

       public virtual DateTime? WorkEndDate { get; set; }

       public virtual double Salary { get; set; }

       public virtual string Designation { get; set; }

       public virtual string ReasonForLeaving { get; set; }

       public virtual Candidate Candidate { get; set; }

    }
}
