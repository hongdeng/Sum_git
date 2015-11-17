using HH_Sum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_HH_Sum
{
    
    
    /// <summary>
    ///This is a test class for SumTest and is intended
    ///to contain all SumTest Unit Tests
    ///</summary>
    [TestClass()]
    public class HH_SumTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Main
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Sum.dll")]
        public void MainTest()
        {
            int args1 = 1; // TODO: Initialize to an appropriate value
            int args2 = 1; // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            HH_add my_Main = new HH_add();

            actual = my_Main.Main(args1, args2);

            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("TEST.");
        }
    }
}
