using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AnalaizerClassLibrary;

namespace AnalaizerUnitTests
{
    [TestClass()]
    public class AnalaizerClassTests_2
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"C:\Users\Lenovo\Desktop\Lab_1\Calculator\AnalaizerUnitTests\TestData_1.xml", "Test", DataAccessMethod.Sequential)]
        
        [TestMethod()]
        public void IsOperatorTests()
        {
            ///Arrange
            string incomingData = Convert.ToString(TestContext.DataRow["incomingData"]);
            bool expected = Convert.ToBoolean(TestContext.DataRow["expected"]);
            ///Actual
            bool actual = AnalaizerClass.IsOperator(incomingData);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
