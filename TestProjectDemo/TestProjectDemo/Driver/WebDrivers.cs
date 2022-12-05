﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDemo.Driver
{
    public class WebDrivers
    {

        public static IWebDriver? Instance { get; set; }

        public static void Initialize()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            Instance.Navigate().GoToUrl("https://example.testproject.io/web/");
        }

        public static void CleanUp()
        {
            Instance?.Quit();
        }
    }
}

