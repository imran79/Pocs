using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;
using PostGresQlSampleApplication.Data;
using PostGresQlSampleApplication.Data.Repository;
using System.Web;
//using Moq;
using PostGresQlSampleApplication.Data.Infrstructure;
using PostGresQlSampleApplication.Test.MockTestHelper;

namespace PostGresQlSampleApplication.Test.DataLayerTest
{
    [SetUpFixture]
    public class DatalayerTest
    {

        public DatalayerTest()
        {

        }

        [SetUp]
        public void SetUp()
        {
            HttpContext.Current = new HttpContext(
         new HttpRequest(null, "http://tempuri.org", null),
         new HttpResponse(null));

        }


        [Test]
        public void AddCandidateToRepositoryTest()
        {
            // HttpContextBase httpContextBase = MoqMvcMockHelpers.FakeHttpContext("~/");

            HttpContext.Current = new HttpContext(
        new HttpRequest(null, "http://localhost:3475/", null),
        new HttpResponse(null));
            Candidate candidate = new Candidate();
            candidate.Name = "Imran";
            candidate.IsMale = true;
            candidate.DateOFBirth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            candidate.CandidateType = CandidateType.fromPortal;
            candidate.CurrentCompany = "HirePro Consulting Private Limited";
            candidate.CurrentCTC = 1.2;
            candidate.EducationProfileCollection = new List<EducationProfile>();
            EducationProfile educationProfile = new EducationProfile();
            educationProfile.College = "Shri Ram Swaroop Memorial college of engineering and management";
            educationProfile.Degree = "MCA";
            educationProfile.percentage = 73;
            educationProfile.StartDate = new DateTime(2003, 7, 1);
            educationProfile.EndDate = new DateTime(2006, 7, 1);
            educationProfile.Candidate = candidate;
            candidate.EducationProfileCollection.Add(educationProfile);

            candidate.WorkProfileCollection = new List<WorkProfile>();
            WorkProfile workProfile = new WorkProfile();
            workProfile.Designation = "Team Lead";
            workProfile.Employer = "HirePro Consulting Private Limited";
            workProfile.ReasonForLeaving = "";
            workProfile.WorkStartDate = new DateTime(2007, 6, 1);
            workProfile.WorkEndDate = new DateTime(2012, 10, 1);
            workProfile.Candidate = candidate;
            candidate.WorkProfileCollection.Add(workProfile);

            CandidateRepository repository = new CandidateRepository();
            repository.Create(candidate);

            Candidate fetchCandidate = repository.GetById(1);

            Assert.IsNotNull(fetchCandidate);


        }

        [TearDown]
        public void TearDown()
        {
            HttpContext.Current = null;

        }


    }




}
