using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_HRM_FrameWork
{
    public class SearchUser
    {
        public async Task SearchingofUser(IPage Page, string Username)
        {
            //SEARCH THE NEW USER
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Search the User");

            await BaseClass.ClickButton(Page, "#app > div.oxd-layout > div.oxd-layout-navigation > aside > nav > div.oxd-sidepanel-body > ul > li:nth-child(1) > a", "Click the Admin");
            // Page.ClickAsync("#app > div.oxd-layout > div.oxd-layout-navigation > aside > nav > div.oxd-sidepanel-body > ul > li:nth-child(1) > a");
            Thread.Sleep(5000);

            await BaseClass.WriteText(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-row > div > div:nth-child(1) > div > div:nth-child(2) > input", Username, "Enter User Name");

            await BaseClass.WriteText(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-row > div > div:nth-child(2) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "a", "Press A");
            Thread.Sleep(3000);
            await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-row > div > div:nth-child(2) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "Enter", "");
            await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-row > div > div:nth-child(2) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "Tab", "");



            await BaseClass.WriteText(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-row > div > div:nth-child(3) > div > div:nth-child(2) > div > div > input", "O", "Enter Employee Name");
            Thread.Sleep(10000);
            await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-row > div > div:nth-child(3) > div > div:nth-child(2) > div > div > input", "ArrowDown", "");
            await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-row > div > div:nth-child(3) > div > div:nth-child(2) > div > div > input", "Enter", "");
            await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-row > div > div:nth-child(3) > div > div:nth-child(2) > div > div > input", "Tab", "");

            Thread.Sleep(5000);

            await BaseClass.WriteText(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-row > div > div:nth-child(4) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "e", "Employee status");
            Thread.Sleep(2000);
            await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-row > div > div:nth-child(4) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "Enter", "");
            // await BaseClass.PressKey(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-row > div > div:nth-child(4) > div > div:nth-child(2) > div > div", "Tab", "Enter Employee status");


            Thread.Sleep(3000);
            await BaseClass.ClickButton(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-actions > button.oxd-button.oxd-button--medium.oxd-button--secondary.orangehrm-left-space", "Search the Employee");



        }
    }
}
