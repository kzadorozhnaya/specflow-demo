using NUnit.Framework;
using SpecFlowAutomation.Base;
using SpecFlowAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowAutomation.Steps
{
    [Binding]
    public sealed class MainMenuSteps
    {
       // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext context;

        public MainMenuSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"I open official SpecFlow web site")]
        public void OpenOfficialSpecFlowWebSite()
        {
            HomePage.Instance.OpenSpecFlowHomePage();
        }

        [When(@"I hover the '(.*)' menu item from the main menu")]
        public void HoverTheMenuItemFromTheMainMenu(string menuItem)
        {
            Thread.Sleep(2000);
            HomePage.Instance.HoverMainMenuItem(menuItem);
        }

        [When(@"I click '(.*)' option from the main menu")]
        public void ClickOptionFromTheMainMenu(string option)
        {
            HomePage.Instance.ClickSubMenuItem(option);
        }

        [Then(@"Page with '(.*)' title should be opened")]
        public void PageWithTitleShouldBeOpened(string title)
        {
            Assert.IsTrue(BasePage.Instance.IsPageTitleDisplayed(title), "Page title for the page is not displayed");
        }

        [AfterScenario]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }

    }
}
