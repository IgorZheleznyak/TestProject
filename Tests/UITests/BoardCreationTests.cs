using Core.Helpers;
using OpenQA.Selenium;

namespace Tests.UITests
{
    public class BoardCreationTests : BaseUITest
    {

        [Test]
        public void BoardCreationUI()
        {
            string boardName = RandomGenerator.GenerateString(8);
            driverManager.Navigate("https://trello.com/login");
            IWebElement name = driverManager.FindElement(By.Id("user"));
            name.SendKeys(user.Email);
            IWebElement submit = driverManager.FindElement(By.Id("login"));
            submit.Submit();
            IWebElement password = driverManager.FindElement(By.Id("password"));
            password.SendKeys(user.Password);
            IWebElement loginSubmit = driverManager.FindElement(By.Id("login-submit"));
            loginSubmit.Submit();

            IWebElement createBoard = driverManager.FindElement(By.XPath("//ul/li/div/p"));
            createBoard.Click();

            IWebElement title = driverManager.FindElement(By.XPath("//form/div[1]/label/input"));
            title.SendKeys(boardName);

            IWebElement createBoard2 = driverManager.FindElement(By.XPath("//form/button"));
            createBoard2.Click();

            IWebElement checkTitle = driverManager.FindElement(By.XPath("//h1[contains(text(),'"+boardName+"')]"));

            Assert.That(checkTitle.Text, Is.EqualTo(boardName));
        }
    }
}