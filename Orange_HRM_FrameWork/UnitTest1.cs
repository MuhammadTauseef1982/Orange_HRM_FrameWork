using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace Orange_HRM_FrameWork
{
    [TestFixture]
    public class Tests : PageTest
    {
        [SetUp]
        public async Task Setup()
        {
            ContextOptions();

            await Context.Tracing.StartAsync(new()
            {
                Screenshots = true,
                Snapshots = true,
                Sources = true
            });
            ExtentReport.LogReport("Orange HRM.com");
        }

        [TearDown]
        public async Task TearDown()
        {
            // Stop tracing and export it into a zip archive.
            await Context.Tracing.StopAsync(new()
            {
                Path = @"trace/trace" + "_" + DateTime.Now.ToString("yyyyMMddhhmmss").ToString() + ".zip"
                //Path = @"trace/" + TestContext.CurrentContext.Test.MethodName + "_" + DateTime.Now.ToString("yyyymmddhhmmss").ToString() + ".zip"
            });
            ExtentReport.extentReports.Flush();
            await Context.CloseAsync();
            await Browser.CloseAsync();
        }

        [Test]
        public async Task TestExecution()
        {
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest("Basic Extent");

            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Login Page");
            await Page.SetViewportSizeAsync(1300, 650);
            Login login = new Login();
            await login.Credentials(Page, "Admin", "admin123");
            AddUser adduser = new AddUser();
            await adduser.AdditionofUser(Page, "a", "O", "E", "Tauseef02", "abc12345$", "abc12345$");
            SearchUser searchuser = new SearchUser();
            await searchuser.SearchingofUser(Page, "Tauseef02");
            UpdateUser updateuser = new UpdateUser();
            await updateuser.UpdationofUser(Page, "Ali001");
            DeleteUser deleteuser = new DeleteUser();
            await deleteuser.DeletionofUser(Page);
        }
        public override BrowserNewContextOptions ContextOptions()
        {
            return new BrowserNewContextOptions()
            {
                RecordVideoDir = @"videos/" + TestContext.CurrentContext.Test.MethodName + "_" + DateTime.Now.ToString("yyyymmddhhmmss").ToString(),
                //StorageStatePath = @"state\pagetest_state.json",
                ViewportSize = new ViewportSize
                {
                    Height = 650,
                    Width = 1300
                },
                RecordVideoSize = new RecordVideoSize
                {
                    Height = 650,
                    Width = 1300
                }
            };

        }
    }
}