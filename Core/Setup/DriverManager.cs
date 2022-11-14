using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace Core.Setup
{
    public class DriverManager
    {
        private readonly ChromeDriver baseDriver;
        private readonly EventFiringWebDriver driver;
        private WebDriverWait wait;

        public DriverManager()
        {
            ChromeOptions options = new();
            options.AddArgument("incognito");
            options.AddArgument("start-maximized");
            baseDriver = new ChromeDriver(options);
            driver = new EventFiringWebDriver(baseDriver);
            //driver.ElementClicking += new EventHandler<WebElementEventArgs>(WebDriver_ElementClicking);
            //driver.ElementClicked += new EventHandler<WebElementEventArgs>(WebDriver_ElementClicked);
            //driver.FindingElement += new EventHandler<FindElementEventArgs>(WebDriver_FindingElement);
            //driver.FindElementCompleted += new EventHandler<FindElementEventArgs>(WebDriver_FindElementCompleted);
            //driver.ElementValueChanging += new EventHandler<WebElementValueEventArgs>(WebDriver_ElementValueChanging);
            //driver.ElementValueChanged += new EventHandler<WebElementValueEventArgs>(WebDriver_ElementValueChanged);
            //driver.Navigating += new EventHandler<WebDriverNavigationEventArgs>(WebDriver_Navigating);
            //driver.Navigated += new EventHandler<WebDriverNavigationEventArgs>(WebDriver_Navigated);
            //driver.ScriptExecuting += new EventHandler<WebDriverScriptEventArgs>(WebDriver_ScriptExecuting);
            //driver.ScriptExecuted += new EventHandler<WebDriverScriptEventArgs>(WebDriver_ScriptExecuted);
            //driver.ExceptionThrown += new EventHandler<WebDriverExceptionEventArgs>(WebDriver_ExceptionThrown);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public IWebElement FindElement(By by)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
            return driver.FindElement(by);
            
        }

        public void Navigate(string url)
        {
            driver.Url = url;
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
            return driver.FindElements(by);
        }

        public void StopDriver()
        {
            driver.Quit();
            baseDriver.Quit();
        }

        private void WebDriver_ElementClicking(object? sender, WebElementEventArgs e)
        {
            Console.WriteLine("EVENT ElementClicking");
        }
        private void WebDriver_ElementClicked(object? sender, WebElementEventArgs e)
        {
            Console.WriteLine("EVENT ElementClicked");
        }
        private void WebDriver_FindingElement(object? sender, FindElementEventArgs e)
        {
            Console.WriteLine("EVENTFindingElement");
        }
        private void WebDriver_FindElementCompleted(object? sender, FindElementEventArgs e)
        {
            Console.WriteLine("EVENT FindElementCompleted");
        }
        private void WebDriver_ElementValueChanging(object? sender, WebElementValueEventArgs e)
        {
            Console.WriteLine("EVENT ElementValueChanging");
        }
        private void WebDriver_ElementValueChanged(object? sender, WebElementValueEventArgs e)
        {
            Console.WriteLine("EVENT ElementValueChanged");
        }
        private void WebDriver_Navigating(object? sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("EVENT Navigating");
        }
        private void WebDriver_Navigated(object? sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("EVENT Navigated");
        }
        private void WebDriver_ScriptExecuting(object? sender, WebDriverScriptEventArgs e)
        {
            Console.WriteLine("EVENT ScriptExecuting");
        }
        private void WebDriver_ScriptExecuted(object? sender, WebDriverScriptEventArgs e)
        {
            Console.WriteLine("EVENT ScriptExecuted");
        }
        private void WebDriver_ExceptionThrown(object? sender, WebDriverExceptionEventArgs e)
        {
            Console.WriteLine("EVENT ExceptionThrown");
        }
    }
}
