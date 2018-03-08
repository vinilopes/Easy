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
    public class Cadastro
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
        public void TheCadastroTest()
        {
            driver.Navigate().GoToUrl("http://localhost:44373/");
            driver.FindElement(By.LinkText("Cadastre-se")).Click();
            driver.FindElement(By.Id("inputEmail")).Click();
            driver.FindElement(By.Id("inputEmail")).Clear();
            driver.FindElement(By.Id("inputEmail")).SendKeys("vini");
            driver.FindElement(By.Id("inputEmail")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("inputEmail")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("inputName")).Click();
            driver.FindElement(By.Id("inputName")).Clear();
            driver.FindElement(By.Id("inputName")).SendKeys("Vinicius Lopes");
            driver.FindElement(By.Id("inputSkype")).Click();
            driver.FindElement(By.Id("inputSkype")).Clear();
            driver.FindElement(By.Id("inputSkype")).SendKeys("vinisky");
            driver.FindElement(By.Id("inputPhone")).Click();
            driver.FindElement(By.Id("inputPhone")).Clear();
            driver.FindElement(By.Id("inputPhone")).SendKeys("47 3495-4956");
            driver.FindElement(By.Id("inputLinkedin")).Click();
            driver.FindElement(By.Id("inputLinkedin")).Clear();
            driver.FindElement(By.Id("inputLinkedin")).SendKeys("link");
            driver.FindElement(By.Id("inputCity")).Click();
            driver.FindElement(By.Id("inputCity")).Clear();
            driver.FindElement(By.Id("inputCity")).SendKeys("Joinville");
            driver.FindElement(By.XPath("//input[@id='inputState']")).Click();
            driver.FindElement(By.XPath("//input[@id='inputState']")).Clear();
            driver.FindElement(By.XPath("//input[@id='inputState']")).SendKeys("Santa Catarina");
            driver.FindElement(By.Id("inputPortfolio")).Click();
            driver.FindElement(By.Id("inputPortfolio")).Clear();
            driver.FindElement(By.Id("inputPortfolio")).SendKeys("link");
            driver.FindElement(By.XPath("(//input[@id='optionsRadiosDisponibility'])[3]")).Click();
            driver.FindElement(By.Id("optionsRadios4")).Click();
            driver.FindElement(By.Id("inputSalary")).Click();
            driver.FindElement(By.Id("inputSalary")).Clear();
            driver.FindElement(By.Id("inputSalary")).SendKeys("30");
            driver.FindElement(By.Id("inputBankInformation")).Click();
            driver.FindElement(By.Id("inputBankInformation")).Clear();
            driver.FindElement(By.Id("inputBankInformation")).SendKeys("banco");
            driver.FindElement(By.Id("inputBankNameAccount")).Click();
            driver.FindElement(By.Id("inputBankNameAccount")).Clear();
            driver.FindElement(By.Id("inputBankNameAccount")).SendKeys("vinicius");
            driver.FindElement(By.Id("inputCpf")).Click();
            driver.FindElement(By.Id("inputCpf")).Clear();
            driver.FindElement(By.Id("inputCpf")).SendKeys("067493820342");
            driver.FindElement(By.Id("inputBankName")).Click();
            driver.FindElement(By.Id("inputBankName")).Clear();
            driver.FindElement(By.Id("inputBankName")).SendKeys("Itau");
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div")).Click();
            driver.FindElement(By.Id("inputAgency")).Click();
            driver.FindElement(By.Id("inputAgency")).Clear();
            driver.FindElement(By.Id("inputAgency")).SendKeys("2222111");
            driver.FindElement(By.XPath("(//input[@value='1'])[3]")).Click();
            driver.FindElement(By.XPath("(//input[@value='1'])[4]")).Click();
            driver.FindElement(By.Id("inputAccount")).Click();
            driver.FindElement(By.Id("inputAccount")).Clear();
            driver.FindElement(By.Id("inputAccount")).SendKeys("1233321");
            driver.FindElement(By.Id("inlineRadioIonic1")).Click();
            driver.FindElement(By.Id("inlineAndroid1")).Click();
            driver.FindElement(By.Id("inlineIOS1")).Click();
            driver.FindElement(By.Id("inlineHTML2")).Click();
            driver.FindElement(By.Id("inlinecss2")).Click();
            driver.FindElement(By.Id("inlineBootstrap2")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[8]/td[2]/label[3]")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[9]/td[2]/label[3]")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[10]/td[2]/label[3]")).Click();
            driver.FindElement(By.Id("inlineAsp4")).Click();
            driver.FindElement(By.Id("inlineC4")).Click();
            driver.FindElement(By.Id("inlineCPlusPlus4")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[14]/td[2]/label[5]")).Click();
            driver.FindElement(By.Id("inlineDjango5")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[16]/td[2]/label[5]")).Click();
            driver.FindElement(By.Id("inlinePHP4")).Click();
            driver.FindElement(By.Id("inlineVue4")).Click();
            driver.FindElement(By.Id("inlineWordpress4")).Click();
            driver.FindElement(By.Id("inlinePhyton3")).Click();
            driver.FindElement(By.XPath("//div[@id='ModalTalent']/div/div/div[2]/form/div/table/tbody/tr[21]/td[2]/label[3]")).Click();
            driver.FindElement(By.Id("inlineSqlServer3")).Click();
            driver.FindElement(By.Id("inlineMySql4")).Click();
            driver.FindElement(By.XPath("(//input[@id='inlineSalesforce1'])[2]")).Click();
            driver.FindElement(By.Id("inlinePhotoshop3")).Click();
            driver.FindElement(By.Id("inlineIllustratos4")).Click();
            driver.FindElement(By.Id("inlineSEO5")).Click();
            driver.FindElement(By.Id("inputCrud")).Click();
            driver.FindElement(By.Id("inputCrud")).Clear();
            driver.FindElement(By.Id("inputCrud")).SendKeys("Link");
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
