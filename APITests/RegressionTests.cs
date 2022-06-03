using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AutomationAPI.Demo;
using AutomationAPI.DTO;
using AventStack.ExtentReports;

namespace APITests
{
    [TestClass]
    public class RegressionTests
    {
        public TestContext TestContext { get; set; }
        [ClassInitialize]
        public static void setUp(TestContext testContext)
        {
            var dir = testContext.TestRunDirectory;
            Reporter.SetUpExtentReport("API Regression Test", "API Reression Test Report", dir);
        }

        [TestInitialize]
        public void SetupTest()
        {
            Reporter.CreateTest(TestContext.TestName);
        }

        [TestCleanup]
        public void CleanupTest()
        {
            var testStatus = TestContext.CurrentTestOutcome;
            Status logStatus;
            switch(testStatus)
            {
                case UnitTestOutcome.Failed:
                    logStatus = Status.Fail;
                    Reporter.TestStatus(logStatus.ToString());
                    break;
                case UnitTestOutcome.Passed:
                    logStatus = Status.Pass;
                    Reporter.TestStatus(logStatus.ToString());
                    break;
                case UnitTestOutcome.Inconclusive:
                    break;
                case UnitTestOutcome.InProgress:
                    break;
                case UnitTestOutcome.Error:
                    break;
                case UnitTestOutcome.Timeout:
                    break;
                case UnitTestOutcome.Aborted:
                    break;
                case UnitTestOutcome.Unknown:
                    break;
                case UnitTestOutcome.NotRunnable:
                    break;
                default:
                    break;
            }

        }

        [ClassCleanup]
        public static void Cleanup()
        {
            Reporter.FlushReport();
        }
        [TestMethod]
        public void VerifyListofUsers()
        {
            var demo = new Demo<ListOfUsersDTO>();
            var user = demo.getUsers("api/users?page=2");
            
            Assert.AreEqual(2,user.Page);
            Reporter.LogReport(Status.Info, "Page number does not match");
            Assert.AreEqual("Michael", user.Data[0].first_name);
            Reporter.LogReport(Status.Info, "User first name does not match");
        }

        [DeploymentItem("TestData\\TestCase.csv"),DataSource("Microsoft.VisualStudio.TestTools.DataSource.csv","TestCase.csv","TestCase#csv",DataAccessMethod.Sequential)]
        [TestMethod]
        public void CreateNewUser()
        {
            //string payload = @"{
            //                     ""name"": ""Mike"",
            //                     ""job"": ""Team leader""
            //                    }";
            var users = new CreateUserRequestDTO();
            users.Name = TestContext.DataRow["name"].ToString();
            Reporter.LogReport(Status.Info, "Test data for name is:" + users.Name);
            users.Job = TestContext.DataRow["job"].ToString();
            var demo = new Demo<CreateUserDTO>();
            var user = demo.createUser("api/users",users);
            Assert.AreEqual("Mike", user.Name);
            Reporter.LogReport(Status.Pass, "Name is matching");
            Assert.AreEqual("Team leader", user.Job);
            Reporter.LogReport(Status.Pass, "Job is matching");

            var demoone = new Demo<ListOfUsersDTO>();
            var userone = demoone.getUsers("api/users?page=2");
            Assert.AreEqual(2, userone.Page);
            Assert.AreEqual("Michael", userone.Data[0].first_name);

        }


        [DeploymentItem("TestData\\CreateUser.json")]
        [TestMethod]
        public void CreateNewUserUsingJson()
        {
            //string payload = @"{
            //                     ""name"": ""Mike"",
            //                     ""job"": ""Team leader""
            //                    }";
            //var users = new CreateUserRequestDTO();
            //users.Name = TestContext.DataRow["name"].ToString();
            //Reporter.LogReport(Status.Info, "Test data for name is:" + users.Name);
            //users.Job = TestContext.DataRow["job"].ToString();
            var payload = HandleContent.parseJson<CreateUserRequestDTO>("CreateUser.json");
            var demo = new Demo<CreateUserDTO>();
            var user = demo.createUser("api/users", payload);
            Assert.AreEqual("steve", user.Name);
            Reporter.LogReport(Status.Pass, "Name is matching");
            Assert.AreEqual("tester", user.Job);
            Reporter.LogReport(Status.Pass, "Job is matching");

            var demoone = new Demo<ListOfUsersDTO>();
            var userone = demoone.getUsers("api/users?page=2");
            Assert.AreEqual(2, userone.Page);
            Assert.AreEqual("Michael", userone.Data[0].first_name);

        }

    }
}
