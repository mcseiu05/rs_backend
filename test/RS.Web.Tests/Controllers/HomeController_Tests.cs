using System.Threading.Tasks;
using RS.Models.TokenAuth;
using RS.Web.Controllers;
using Shouldly;
using Xunit;

namespace RS.Web.Tests.Controllers
{
    public class HomeController_Tests: RSWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}