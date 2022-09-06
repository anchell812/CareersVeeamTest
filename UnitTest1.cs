using CareersVeeamTest.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V102.DOM;

namespace CareersVeeamTest
{ 
public class Tests
{
    private IWebDriver driver;

        [SetUp]
    public void Setup()
    {
        driver = new OpenQA.Selenium.Chrome.ChromeDriver();
       
        driver.Navigate().GoToUrl(TestData.startUrl);
           
        driver.Manage().Window.Maximize();
    }

    [Test]
    public void Test1()
    {

            var vacanciesPage = new VacanciesPage(driver);
            vacanciesPage.ActivateDepartmentList();
            vacanciesPage.ChooseDepartment();
            vacanciesPage.ChooseLanguage(TestData.language);
         
            int countJobs = vacanciesPage.CountVacancies();

            Assert.That(countJobs, Is.EqualTo(TestData.quantityOfResearchJobs), "Vacancies are counted incorrectly");
     
    }

    [TearDown]
    public void TearDown()
    {
        //driver.Quit();
    }
}
}