using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_HRM_FrameWork
{
    public class UpdateUser
    {
        public async Task UpdationofUser(IPage Page, string upname)
        {
            //EDIT THE USER
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Edit the User");
            await BaseClass.ClickButton(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.orangehrm-paper-container > div.orangehrm-container > div > div.oxd-table-body > div > div > div:nth-child(6) > div > button:nth-child(2)", "Select to Update");
            await BaseClass.ClickButton(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-row > div > div:nth-child(3) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "using for Tab");
            await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-row > div > div:nth-child(3) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "Tab", "");
            await BaseClass.WriteText(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-row > div > div:nth-child(4) > div > div:nth-child(2) > input", upname, "update user");
            Thread.Sleep(3000);
            await BaseClass.ClickButton(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-actions > button.oxd-button.oxd-button--medium.oxd-button--secondary.orangehrm-left-space", "Save the changes");
            Thread.Sleep(3000);
            await BaseClass.ClickButton(Page, "#app > div.oxd-layout > div.oxd-layout-navigation > aside > nav > div.oxd-sidepanel-body > ul > li:nth-child(1) > a", "Check updated name");
            await BaseClass.WriteText(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-row > div > div:nth-child(1) > div > div:nth-child(2) > input", upname, "Enter changed name");
            await BaseClass.ClickButton(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-actions > button.oxd-button.oxd-button--medium.oxd-button--secondary.orangehrm-left-space", "again search change name");

        }
    }
}