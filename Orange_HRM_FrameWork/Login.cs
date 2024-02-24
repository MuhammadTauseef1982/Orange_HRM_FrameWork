using AventStack.ExtentReports;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_HRM_FrameWork
{
    public class Login
    {
        //BaseClass baseclass = new BaseClass();


        public async Task Credentials(IPage Page, string user, string pass)
        {


            await Page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php");
            await ExtentReport.TakeScreenshot(Page, Status.Pass, "Open URL");
            await Page.WaitForLoadStateAsync();
            Thread.Sleep(50000);
            //await Page.PauseAsync();
            await BaseClass.WriteText(Page, "#app > div.orangehrm-login-layout > div > div.orangehrm-login-container > div > div.orangehrm-login-slot > div.orangehrm-login-form > form > div:nth-child(2) > div > div:nth-child(2) > input", user, "Enter UserName");
            await ExtentReport.TakeScreenshot(Page, Status.Pass, "Select the Role");

            await BaseClass.WriteText(Page, "#app > div.orangehrm-login-layout > div > div.orangehrm-login-container > div > div.orangehrm-login-slot > div.orangehrm-login-form > form > div:nth-child(3) > div > div:nth-child(2) > input", pass, "Enter Password");
            Thread.Sleep(3000);
            await BaseClass.ClickButton(Page, "#app > div.orangehrm-login-layout > div > div.orangehrm-login-container > div > div.orangehrm-login-slot > div.orangehrm-login-form > form > div.oxd-form-actions.orangehrm-login-action > button", "Click the Button");


        }
    }
}