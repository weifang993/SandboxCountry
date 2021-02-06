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
            var ctryManager = new CountryManager();

            // act
            var country = ctryManager.GetCountry("CA");

            // assert
            Assert.AreEqual("Canada", country.Name);
        }
    }
}
