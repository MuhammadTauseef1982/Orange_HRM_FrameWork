using AventStack.ExtentReports;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_HRM_FrameWork
{
    public class AddUser
    {
        public async Task AdditionofUser(IPage Page, string role, string empName, string empstatus, string Username, string UserPassword, string againPassword)
        {
            Thread.Sleep(5000);
            await BaseClass.ClickButton(Page, "#app > div.oxd-layout > div.oxd-layout-navigation > aside > nav > div.oxd-sidepanel-body > ul > li:nth-child(1) > a", "Click the Admin Tab");

            //GO TO ADMIN AND ADD USER
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Add the User");
            Thread.Sleep(5000);
            await BaseClass.ClickButton(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.orangehrm-paper-container > div.orangehrm-header-container > button", "Add User Button");
            await BaseClass.ClickButton(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(1) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "Rights of User");
            await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(1) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "a", "Press A");
            Thread.Sleep(2000);
            await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(1) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "Enter", "");
            await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(1) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "Tab", "");

            await ExtentReport.TakeScreenshot(Page, Status.Pass, "Select the Role");

            await BaseClass.WriteText(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(2) > div > div:nth-child(2) > div > div > input", empName, "Enter Employee Name");
            Thread.Sleep(5000);
            await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(2) > div > div:nth-child(2) > div > div > input", "ArrowDown", "");
            await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(2) > div > div:nth-child(2) > div > div > input", "Enter", "");

            Thread.Sleep(5000);
            await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(2) > div > div:nth-child(2) > div > div > input", "Tab", "");

            await BaseClass.WriteText(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(3) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "e", "Enter Employee status");
            Thread.Sleep(3000);
            await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(3) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "Enter", "");
            await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(3) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "Tab", "");

            //enter new user
            await BaseClass.WriteText(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(4) > div > div:nth-child(2) > input", Username, "Enter New User");
            await BaseClass.WriteText(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-row.user-password-row > div > div.oxd-grid-item.oxd-grid-item--gutters.user-password-cell > div > div:nth-child(2) > input", UserPassword, "Enter Password");
            await BaseClass.WriteText(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-row.user-password-row > div > div:nth-child(2) > div > div:nth-child(2) > input", againPassword, "Enter Re-Enter Password");
            //SAVE THE NEW USER INFO
            await BaseClass.ClickButton(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-actions > button.oxd-button.oxd-button--medium.oxd-button--secondary.orangehrm-left-space", "User Added");



            Thread.Sleep(5000);


        }
    }
}