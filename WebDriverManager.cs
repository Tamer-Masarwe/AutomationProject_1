using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Text.Json;

namespace AutomationProject
{
    public class WebDriverManager
    {
        private static IWebDriver _driver;

        public static void InitDriver()
        {
            _driver = new ChromeDriver();
            string jsonString = File.ReadAllText(@"C:\GitHub\LumaWebsiteAutomation\AutomationProject\JsonFiles\WebSettings.json");
            JsonElement root = JsonSerializer.Deserialize<JsonElement>(jsonString);
            string url = root.GetProperty("WebSiteURL").GetString();
            _driver.Navigate().GoToUrl(url);
        }

        public static IWebDriver GetDriver()
        {
            return _driver;
        }

        public static void Quit()
        {
            _driver.Quit();
        }
    }
}