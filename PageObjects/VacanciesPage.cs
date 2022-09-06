using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareersVeeamTest.PageObjects
{
    class VacanciesPage
    {
        private IWebDriver driver;

        private readonly By _departmentDropDown = By.XPath("//button[@id='sl']");
        private readonly By _researchDevelopments = By.XPath("//a[contains(text(), 'Research')]");
        private readonly By _languagesDropDown = By.XPath("//button[contains(text(), 'languages')]");
        private readonly By _languageCheckbox = By.XPath("//label[@class='custom-control-label']");
        private readonly By _vacancies = By.XPath("//a[contains(@class,'card-sm')]");


        public VacanciesPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public void ActivateDepartmentList()
        {
            driver.FindElement(_departmentDropDown).Click();
        }

        public void ChooseDepartment()
        {
            driver.FindElement(_researchDevelopments).Click();
        }

        public void ChooseLanguage(string language)
        {
            driver.FindElement(_languagesDropDown).Click();
            var choosenLanguage = driver.FindElements(_languageCheckbox).First(x => x.Text == language);
            choosenLanguage.Click();

        }

        public int CountVacancies()
        {
            int countVacancies = driver.FindElements(_vacancies).Count();
            return countVacancies;
        }
    }

}
