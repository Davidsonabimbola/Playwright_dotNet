using Microsoft.Playwright;
// using NUnit.Framework;
// using System.Threading.Tasks;

namespace PlaywrightTests.Models;

public class LoginPage
{

    private IPage _page;
    private readonly ILocator _lnkLogin;
    private readonly ILocator _txtUserName;
    private readonly ILocator _txtPassword;

    private readonly ILocator _btnLogin;
    private readonly ILocator _lnkEmployeeDetails;
    public LoginPage(IPage page) //constructor
    {
        _page = page;
        _lnkLogin = page.Locator("[id='loginLink']");
        _txtUserName = page.Locator("[id='UserName']");
        _txtPassword = page.Locator("[id='Password']");
        _btnLogin = page.Locator("[class='btn btn-default']");
        _lnkEmployeeDetails = page.Locator("text='Employee Details'");
    }

    public async Task ClickLogin() => await _lnkLogin.ClickAsync();
    public async Task Login(string username, string password)
    {
        await _txtUserName.FillAsync(username);
        await _txtPassword.FillAsync(password);
        await _btnLogin.ClickAsync();

    }

    //public async Task<bool> IsEmployeeDetailsExist() => await _lnkEmployeeDetails.IsVisibleAsync();
    public async Task Check_Employee_Details()
    {
        await _lnkEmployeeDetails.IsVisibleAsync();

    }

}



