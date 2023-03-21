using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.TC
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public void RunSystem()
        {
            WebDriverManager.InitDriver();
        }


        [OneTimeTearDown]
        public void ShutDown()
        {
            WebDriverManager.Quit();
        }
    }
}
