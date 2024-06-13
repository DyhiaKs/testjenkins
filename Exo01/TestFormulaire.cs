using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Exo01
{
    [TestFixture]
    public class TestFormulaire
    {
        public IWebDriver Navig; // Déclarer mon driver afin de l'utiliser dans mes méthodes
        IJavaScriptExecutor js; // Déclarer un IJavaScriptExecutor : un objet qui permet d'exécuter du code JavaScript
        ReadData read = new ReadData();
        Client client;

        [SetUp]
        public void SetUp()
        {
            Navig = new ChromeDriver(@"C:\Selenium\chromedriver.exe");
            js = (IJavaScriptExecutor)Navig;
            client = read.ReadDataFromJson();
        }

        [TearDown]
        public void TearDown()
        {
            Navig.Quit();
            Navig.Dispose();
        }

        [Test]
        public void SendFormFemme()
        {
            Navig.Navigate().GoToUrl("https://sendform.nicepage.io/?version=13efcba7-1a49-45a5-9967-c2da8ebdd189&uid=f7bd60f0-34c8-40e3-8e2c-06cc19fcb730");

            // Remplir Formulaire
            // Click Femme
            Navig.FindElement(By.Id("field-aa6c")).Click();

            // Pays de naissance
            SelectElement selectPaysNaiss = new SelectElement(Navig.FindElement(By.Id("select-9648")));
            selectPaysNaiss.SelectByValue("ES");

            // Email
            Navig.FindElement(By.Id("email-c6a3")).SendKeys(client.Email);

            // Name
            Navig.FindElement(By.Id("name-c6a3")).SendKeys(client.Name);

            // Phone
            Navig.FindElement(By.Id("phone-84d9")).SendKeys(client.Phone);

            // Adresse
            Navig.FindElement(By.Id("address-be2d")).SendKeys(client.Adresse);

            // Message
            Navig.FindElement(By.Id("message-c6a3")).SendKeys(client.Message);

            // JavaScript pour le scroll pour atteindre le premier bouton radio No
            js.ExecuteScript("arguments[0].scrollIntoView(true);", Navig.FindElement(By.Id("select-c283")));

            // Product
            SelectElement selectProduct = new SelectElement(Navig.FindElement(By.Id("select-c283")));
            selectProduct.SelectByValue("vel");

            // Click Littérature
            Navig.FindElement(By.Id("checkbox-1848")).Click();

            // Click sur Submit
            Navig.FindElement(By.CssSelector(".u-border-none")).Click();
        }

        [Test]
        public void SendFormHomme()
        {
            Navig.Navigate().GoToUrl("https://sendform.nicepage.io/?version=13efcba7-1a49-45a5-9967-c2da8ebdd189&uid=f7bd60f0-34c8-40e3-8e2c-06cc19fcb730");

            // Remplir Formulaire
            // Click Homme
            Navig.FindElement(By.Id("field-2688")).Click();

            // Pays de naissance
            SelectElement selectPaysNaiss = new SelectElement(Navig.FindElement(By.Id("select-9648")));
            selectPaysNaiss.SelectByValue("FR");

            // Email
            Navig.FindElement(By.Id("email-c6a3")).SendKeys(client.Email);

            // Name
            Navig.FindElement(By.Id("name-c6a3")).SendKeys(client.Name);

            // Phone
            Navig.FindElement(By.Id("phone-84d9")).SendKeys(client.Phone);

            // Adresse
            Navig.FindElement(By.Id("address-be2d")).SendKeys(client.Adresse);

            // Message
            Navig.FindElement(By.Id("message-c6a3")).SendKeys(client.Message);

            // JavaScript pour le scroll pour atteindre le premier bouton radio No
            js.ExecuteScript("arguments[0].scrollIntoView(true);", Navig.FindElement(By.Id("select-c283")));

            // Product
            SelectElement selectProduct = new SelectElement(Navig.FindElement(By.Id("select-c283")));
            selectProduct.SelectByValue("vel");

            // Click Littérature
            Navig.FindElement(By.Id("checkbox-8214")).Click();

            // Click sur Submit
            Navig.FindElement(By.CssSelector(".u-border-none")).Click();
        }
    }
}
