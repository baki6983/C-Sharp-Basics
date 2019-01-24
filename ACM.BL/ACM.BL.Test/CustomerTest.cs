using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange date to test
            Customer customer = new Customer();
            customer.FirstName = "Suggu";
            customer.LastName = "Baki";

            String expectedResult = "Suggu Baki";

            //Act -- Result from Actual Method
            String actualResult = customer.FullName;

            //Assertion -- TO TEST ExpectedResult and ActualResult
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
