using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        IWebDriver driver;
        readonly string path = AppDomain.CurrentDomain.BaseDirectory;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver(path);
        }

        [Test]
        public void Test()
        {
            driver.Url = "http://www.google.com";
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}
