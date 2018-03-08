using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestClass]
    public class Editar
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        private static string baseURL;
        private bool acceptNextAlert = true;
        
        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
        }
        
        [ClassCleanup]
        public static void CleanupClass()
        {
            try
            {
                //driver.Quit();// quit does not close the window
                driver.Close();
                driver.Dispose();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
        
        [TestInitialize]
        public void InitializeTest()
        {
            verificationErrors = new StringBuilder();
        }
        
        [TestCleanup]
        public void CleanupTest()
        {
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [TestMethod]
        public void TheEditarTest()
        {
            driver.Navigate().GoToUrl("http://localhost:44373/");
            driver.FindElement(By.XPath("(//button[@type='submit'])[2]")).Click();
            driver.FindElement(By.Id("inputEmail")).Click();
            driver.FindElement(By.Id("inputEmail")).Clear();
            driver.FindElement(By.Id("inputEmail")).SendKeys("atualizado@gmail");
            driver.FindElement(By.Id("inputName")).Click();
            driver.FindElement(By.Id("inputName")).Clear();
            driver.FindElement(By.Id("inputName")).SendKeys("Vini Atualizado");
            driver.FindElement(By.Id("inputSkype")).Click();
            driver.FindElement(By.Id("inputSkype")).Clear();
            driver.FindElement(By.Id("inputSkype")).SendKeys("Atualizado");
            driver.FindElement(By.Id("inputPhone")).Click();
            driver.FindElement(By.Id("inputPhone")).Clear();
            driver.FindElement(By.Id("inputPhone")).SendKeys("57 3495-4956");
            driver.FindElement(By.Id("inputLinkedin")).Click();
            driver.FindElement(By.Id("inputLinkedin")).Click();
            driver.FindElement(By.Id("inputLinkedin")).Clear();
            driver.FindElement(By.Id("inputLinkedin")).SendKeys("Link2");
            driver.FindElement(By.Id("inputCity")).Click();
            driver.FindElement(By.Id("inputCity")).Clear();
            driver.FindElement(By.Id("inputCity")).SendKeys("Curitiba");
            driver.FindElement(By.XPath("//input[@id='inputState']")).Click();
            driver.FindElement(By.XPath("//input[@id='inputState']")).Clear();
            driver.FindElement(By.XPath("//input[@id='inputState']")).SendKeys("PR");
            driver.FindElement(By.Id("inputPortfolio")).Click();
            driver.FindElement(By.Id("inputPortfolio")).Clear();
            driver.FindElement(By.Id("inputPortfolio")).SendKeys("link4");
            driver.FindElement(By.Id("optionsRadiosDisponibility")).Click();
            driver.FindElement(By.Id("optionsRadios1")).Click();
            driver.FindElement(By.Id("inputSalary")).Click();
            driver.FindElement(By.Id("inputSalary")).Clear();
            driver.FindElement(By.Id("inputSalary")).SendKeys("2");
            driver.FindElement(By.Id("inputBankInformation")).Click();
            driver.FindElement(By.Id("inputBankInformation")).Clear();
            driver.FindElement(By.Id("inputBankInformation")).SendKeys("banco2");
            driver.FindElement(By.Id("inputBankNameAccount")).Click();
            driver.FindElement(By.Id("inputBankNameAccount")).Clear();
            driver.FindElement(By.Id("inputBankNameAccount")).SendKeys("teste");
            driver.FindElement(By.Id("inputCpf")).Click();
            driver.FindElement(By.Id("inputCpf")).Clear();
            driver.FindElement(By.Id("inputCpf")).SendKeys("123123");
            driver.FindElement(By.Id("inputBankName")).Click();
            driver.FindElement(By.Id("inputBankName")).Clear();
            driver.FindElement(By.Id("inputBankName")).SendKeys("Brasil");
            driver.FindElement(By.Id("inputAgency")).Click();
            driver.FindElement(By.Id("inputAgency")).Click();
            driver.FindElement(By.Id("inputAgency")).Clear();
            driver.FindElement(By.Id("inputAgency")).SendKeys("111111");
            driver.FindElement(By.XPath("(//input[@value='1'])[3]")).Click();
            driver.FindElement(By.XPath("(//input[@value='1'])[4]")).Click();
            driver.FindElement(By.Id("inputAccount")).Click();
            driver.FindElement(By.Id("inputAccount")).Clear();
            driver.FindElement(By.Id("inputAccount")).SendKeys("222222");
            driver.FindElement(By.Id("inlineRadioIonic3")).Click();
            driver.FindElement(By.Id("inlineIOS3")).Click();
            driver.FindElement(By.Id("inlineAndroid3")).Click();
            driver.FindElement(By.Id("inlineHTML3")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[6]/td[2]/label[3]")).Click();
            driver.FindElement(By.Id("inlineBootstrap3")).Click();
            driver.FindElement(By.Id("inlineJquery4")).Click();
            driver.FindElement(By.Id("inlineAngularJs4")).Click();
            driver.FindElement(By.Id("inlineJava4")).Click();
            driver.FindElement(By.Id("inlineAsp3")).Click();
            driver.FindElement(By.Id("inlineC3")).Click();
            driver.FindElement(By.Id("inlineCPlusPlus3")).Click();
            driver.FindElement(By.Id("inlineCake3")).Click();
            driver.FindElement(By.Id("inlineDjango1")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[16]/td[2]/label")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[17]/td[2]/label")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[18]/td[2]/label")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[20]/td[2]/label")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[19]/td[2]/label")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[21]/td[2]/label")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[22]/td[2]/label")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[23]/td[2]/label")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[24]/td[2]/label")).Click();
            driver.FindElement(By.Id("inlinePhotoshop1")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[26]/td[2]/label")).Click();
            driver.FindElement(By.Id("inlineSEO1")).Click();
            driver.FindElement(By.Id("inputCrud")).Click();
            driver.FindElement(By.Id("inputCrud")).Clear();
            driver.FindElement(By.Id("inputCrud")).SendKeys("Link7");
            driver.FindElement(By.Id("btnSave")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
