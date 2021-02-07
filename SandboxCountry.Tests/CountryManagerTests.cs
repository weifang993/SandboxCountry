using Microsoft.VisualStudio.TestTools.UnitTesting;
using SandboxCountry.Models;

namespace SandboxCountry.Tests
{
    [TestClass]
    public class CountryManagerTests
    {
        [TestMethod]
        public void TestGetCountry_CA()
        {
            // arrange
            var ctryManager = new CountryManager("Server=tcp:flasit-sqlserver-01.database.windows.net,1433;Initial Catalog=Denis001;Persist Security Info=False;User ID=sa-flasit1;Password=mH8DNUUfNKDihC;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            // act
            var country = ctryManager.GetCountry("CA");

            // assert
            Assert.AreEqual("Canada", country.CountryName_E);
        }

        [TestMethod]
        public void TestGetCountry_FR()
        {
            // arrange
            var ctryManager = new CountryManager("Server=tcp:flasit-sqlserver-01.database.windows.net,1433;Initial Catalog=Denis001;Persist Security Info=False;User ID=sa-flasit1;Password=mH8DNUUfNKDihC;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            // act
            var country = ctryManager.GetCountry("FR");

            // assert
            Assert.AreEqual("France", country.CountryName_E);
        }

    }
}
