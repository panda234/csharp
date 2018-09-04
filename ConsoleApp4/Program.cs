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

        string path = AppDomain.CurrentDomain.BaseDirectory;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver(path);
        }

        [Test]
        public void test()
        {
            driver.Url = "http://www.google.com";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
