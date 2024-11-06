using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace SpecFlowProject3
{
    [Binding]
    public sealed class SpecflowHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Debug.WriteLine(nameof(BeforeTestRun));
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Debug.WriteLine(nameof(AfterTestRun));
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Debug.WriteLine($"Before Feature: Title: {featureContext.FeatureInfo.Title} Desc:{featureContext.FeatureInfo.Description}");
        }

        [AfterFeature]
        public static void AfterFeature(FeatureContext featureContext)
        {
            Debug.WriteLine($"After Feature: Title: {featureContext.FeatureInfo.Title} Desc:{featureContext.FeatureInfo.Description}");
        }

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            Debug.WriteLine($"Before Scenario: Title: {scenarioContext.ScenarioInfo.Title}");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Debug.WriteLine(nameof(AfterScenario));
        }

        [BeforeScenarioBlock]
        public void BeforeScenarioBlock()
        {
            Debug.WriteLine(nameof(BeforeScenarioBlock));
        }

        [AfterScenarioBlock]
        public void AfterScenarioBlock()
        {
            Debug.WriteLine(nameof(AfterScenarioBlock));
        }

        [BeforeStep]
        public void BeforeStep()
        {
            Debug.WriteLine(nameof(BeforeStep));
        }

        [AfterStep]
        public void AfterStep()
        {
            Debug.WriteLine(nameof(AfterStep));
        }
    }
}
