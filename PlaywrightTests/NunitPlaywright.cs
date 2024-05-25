// using Microsoft.Playwright;
// using Microsoft.Playwright.NUnit;
// using NUnit.Framework;

// namespace PlaywrightTests;

// public class NUnitPlaywright : PageTest
// {
//     [SetUp]
//     public async Task Setup()
//     {
//         await Page.GotoAsync("http://www.eaapp.somee.com");
//     }

//     [Test]
//     public async Task Test1()
//     {


//         //await Page.GotoAsync("http://www.eaapp.somee.com");
//         await Page.ClickAsync("text=Login");
//         await Page.FillAsync("#UserName", "admin");
//         await Page.FillAsync("#Password", "password");
//         await Expect(Page.GetByText("Employee Details")).ToBeVisibleAsync();
//         //Page.GetByTestId("UserName");
//     }
// }

//Another way
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