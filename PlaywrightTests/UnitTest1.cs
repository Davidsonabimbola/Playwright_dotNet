







using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using Microsoft.VisualBasic;
using NUnit.Framework;
using PlaywrightTests.Models;
using System.Threading.Tasks;

namespace PlaywrightTests
{
    public class UnitTest1
    {
        private IBrowser _browser;
        private IPage _page;
        private BrowserTypeLaunchOptions _browserOptions;

        [SetUp]
        public async Task Setup()
        {
            var playwright = await Playwright.CreateAsync();
            _browserOptions = new BrowserTypeLaunchOptions { Headless = false }; // Set Headless to true for CI/CD pipelines
            _browser = await playwright.Chromium.LaunchAsync(_browserOptions);
            _page = await _browser.NewPageAsync();
        }


        [Test]
        public async Task TestLoginFunctionality()
        {
            var loginPage = new LoginPage(_page);
            await _page.GotoAsync("http://www.eaapp.somee.com");
            await loginPage.ClickLogin();
            await loginPage.Login("your_username", "your_password");

            // bool isEmployeeDetailsExist = await loginPage.IsEmployeeDetailsExist();
            // Assert.IsTrue(isEmployeeDetailsExist, "Employee Details link should be visible after logging in.");
        }
    }
}



// namespace PlaywrightTests;

// public class NUnitPlaywright : PageTest
// {
//     [SetUp]
//     public async Task Setup()
//     {
//         await Page.GotoAsync("http://www.eaapp.somee.com"
//         // ,
//         // new PageGotoOptions
//         // {
//         //     WaitUntil = WaitUntilState.DOMContentLoaded
//         // }
//         );
//     }

//     [Test]
//     public async Task Test1()
//     {


//         //var Login_Button = Page.GetByText("Login");
//         //await Login_Button.ClickAsync();
//         //await Page.ClickAsync("text=Login");
//         await Page.Locator("[id='loginLink']").ClickAsync();

//         await Page.FillAsync("#UserName", "admin");
//         await Page.FillAsync("#Password", "password");
//         await Page.ClickAsync("text=Log in");
//         await Expect(Page.Locator("text='Employee Details'")).ToBeVisibleAsync();
//         //await Expect(Page.GetByText("Employee Details")).ToBeVisibleAsync();
//         //Page.GetByTestId("UserName");
//     }
// }


