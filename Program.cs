// https://www.youtube.com/watch?v=cNKi0Pl5wbc

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace scraping_tutorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            // Launch the ToolsQA website
            driver.Url = "http://www.demoqa.com";

            // Storing the Title name in a string variable
            String Title = driver.Title;

            // Storing the Title length in Int variable
            int TitleLength = driver.Title.Length;

            // Printing Title name on console
            Console.WriteLine("Title of the page is : " + Title);

            // Printing Title length on console
            Console.WriteLine("Lenght of the Title is : " + TitleLength);

            // Storing URL in String variable
            String PageUrl = driver.Url;

            // Storing URL length in Int variable
            int URLLength = PageUrl.Length;

            // Printing URL on console
            Console.WriteLine("URL of the page is : " + PageUrl);

            // Printing URL length on console
            Console.WriteLine("Length of the URL is : " + URLLength);

            // Storing Page Source in String variable
            String PageSource = driver.PageSource;

            // Storing Page Source length in Int variable
            int PageSourceLength = driver.PageSource.Length;

            // // Printing Page Source on console
            // Console.WriteLine("Page source of the page is : " + PageSource);

            // Printing Page Source length on console
            Console.WriteLine("Length of the Page Source is : " + PageSourceLength);

            // Closing browser
            driver.Quit();
        }
    }
}