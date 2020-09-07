using OpenQA.Selenium;
using System;
using WebdriverFramework.Framework.WebDriver;
using WebdriverFramework.Framework.WebDriver.Elements;

namespace WebdriverFramework.Forms
{
    public class MainForm : BaseForm
    {
        private const String MAIN_LOCATOR = "//div[contains(@id, 'index_login')]";

        public MainForm() : base(By.XPath(MAIN_LOCATOR), "VK main page") { }
        
        private TextBox txbPhoneOrEmail = new TextBox(By.XPath("//input[contains(@id, 'index_email')]"), "Phone or email");
        private TextBox txbPassword = new TextBox(By.XPath("//input[contains(@id, 'index_pass')]"), "Password");

        private Button btnLogin = new Button(By.XPath("//button[contains(@id, 'index_login_button')]"), "Login");

        public void InputPhoneOrEmail(String phoneOrEmail) {
            txbPhoneOrEmail.SetText(phoneOrEmail);
        }

        public void InputPassword(String password)
        {
            txbPassword.SetText(password);
        }

        public void ClickLogin() {
            btnLogin.Click();
        }
    }
}
