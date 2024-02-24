using AventStack.ExtentReports;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_HRM_FrameWork
{
    public class DeleteUser
    {
        public async Task DeletionofUser(IPage Page)
        {
            //DELETE THE USER
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Delete the User");
            Thread.Sleep(3000);
            await BaseClass.ClickButton(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-actions > button.oxd-button.oxd-button--medium.oxd-button--secondary.orangehrm-left-space", "search user");
            Thread.Sleep(3000);
            await BaseClass.ClickButton(Page, "#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.orangehrm-paper-container > div.orangehrm-container > div > div.oxd-table-body > div > div > div:nth-child(6) > div > button:nth-child(1)", "Deletion");
            Thread.Sleep(3000);
            await BaseClass.ClickButton(Page, "#app > div.oxd-overlay.oxd-overlay--flex.oxd-overlay--flex-centered > div > div > div > div.orangehrm-modal-footer > button.oxd-button.oxd-button--medium.oxd-button--label-danger.orangehrm-button-margin", "Deleted");

        }
    }
}
