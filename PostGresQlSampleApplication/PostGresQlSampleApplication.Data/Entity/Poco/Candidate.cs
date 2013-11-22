using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostGresQlSampleApplication.Data
{
    public class Candidate
    {

        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Address { get; set; }

        public virtual DateTime? DateOFBirth { get; set; }

        public virtual double? CurrentCTC { get; set; }

        public virtual string CurrentCompany { get; set; }

        public virtual bool IsMale { get; set; }

        public virtual CandidateType CandidateType { get; set; }

        public virtual ICollection<EducationProfile> EducationProfileCollection { get; set; }

        public virtual ICollection<WorkProfile> WorkProfileCollection { get; set; }

        public Candidate()
        {
            EducationProfileCollection = new HashSet<EducationProfile>();
            WorkProfileCollection = new HashSet<WorkProfile>();
        }

    }

    public enum CandidateType
    {
        selfRegistered = 0,
        fromPortal =1,
        referral =2
    }


}
