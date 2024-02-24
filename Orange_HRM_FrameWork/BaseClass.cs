using AventStack.ExtentReports;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_HRM_FrameWork
{
    public static class BaseClass
    {
        public static async Task WriteText(IPage Page, string locator, string data, string detail)
        {
            await Page.Locator(locator).TypeAsync(data);
            await ExtentReport.TakeScreenshot(Page, Status.Pass, detail);
        }
        public static async Task ClickButton(IPage Page, string locator, string detail)
        {
            await Page.Locator(locator).ClickAsync();
            await ExtentReport.TakeScreenshot(Page, Status.Pass, detail);
        }
        public static async Task PressKey(IPage Page, string locator, string data, string detail)
        {
            await Page.Locator(locator).PressAsync(data);
            await ExtentReport.TakeScreenshot(Page, Status.Pass, detail);
        }
    }
}
