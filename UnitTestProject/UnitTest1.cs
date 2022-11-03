using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShukriWebApplication;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ClassTesting
            ClassTesting classTesting = new ClassTesting();
            string un = "User Name";
            
            string ExpectedResult = "The username: " + un + " is inserted successfully..!";
            string TestResult = classTesting.ApplicationDbContextDATA(un);

            Assert.AreEqual(ExpectedResult, TestResult);


        }
    }
}
