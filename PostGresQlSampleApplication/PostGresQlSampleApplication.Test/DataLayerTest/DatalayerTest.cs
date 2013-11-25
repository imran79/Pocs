using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;
using PostGresQlSampleApplication.Data;
using PostGresQlSampleApplication.Data.Repository;
using System.Web;
using Moq;
using PostGresQlSampleApplication.Data.Infrstructure;

namespace PostGresQlSampleApplication.Test.DataLayerTest
{
   [TestFixture]
   public class DatalayerTest
    {
       [Test]
       public void AddCandidateToRepositoryTest()
       {
           Candidate candidate = new Candidate();
           candidate.Name = "Imran";
           candidate.IsMale = true;
           candidate.DateOFBirth = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);
           candidate.CandidateType = CandidateType.fromPortal;
           candidate.CurrentCompany = "HirePro Consulting Private Limited";
           candidate.CurrentCTC = 1.2;
           candidate.EducationProfileCollection = new List<EducationProfile>();
           EducationProfile educationProfile = new EducationProfile();
           educationProfile.College = "Shri Ram Swaroop Memorial college of engineering and management";
           educationProfile.Degree = "MCA";
           educationProfile.percentage = 73;
           educationProfile.StartDate = new DateTime(2003,7,1);
           educationProfile.EndDate = new DateTime(2006, 7, 1);
           candidate.EducationProfileCollection.Add(educationProfile);
           HttpContextFactory.SetCurrentContext(GetMockedHttpContext());
           CandidateRepository repository = new CandidateRepository();
           repository.Create(candidate);


       }



       private HttpContextBase GetMockedHttpContext()
       {
           var context = new Mock<HttpContextBase>();
           //var request = new Mock<HttpRequestBase>();
           //var response = new Mock<HttpResponseBase>();
           //var session = new Mock<HttpSessionStateBase>();
           //var server = new Mock<HttpServerUtilityBase>();
           //var user = new Mock<IPrincipal>();
           //var identity = new Mock<IIdentity>();
           //var urlHelper = new Mock<UrlHelper>();

           //var routes = new RouteCollection();
           //MvcApplication.RegisterRoutes(routes);
           //var requestContext = new Mock<RequestContext>();
           //requestContext.Setup(x => x.HttpContext).Returns(context.Object);
           //context.Setup(ctx => ctx.Request).Returns(request.Object);
           //context.Setup(ctx => ctx.Response).Returns(response.Object);
           //context.Setup(ctx => ctx.Session).Returns(session.Object);
           //context.Setup(ctx => ctx.Server).Returns(server.Object);
           //context.Setup(ctx => ctx.User).Returns(user.Object);
           //user.Setup(ctx => ctx.Identity).Returns(identity.Object);
           //identity.Setup(id => id.IsAuthenticated).Returns(true);
           //identity.Setup(id => id.Name).Returns("test");
           //request.Setup(req => req.Url).Returns(new Uri("http://www.google.com"));
           //request.Setup(req => req.RequestContext).Returns(requestContext.Object);
           //requestContext.Setup(x => x.RouteData).Returns(new RouteData());

           return context.Object;
       }
    }



  
}
