using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TechTalk.SpecFlow;

namespace TestProject2.Hooks
{

    [Binding]
    class Hook
    {
        static AventStack.ExtentReports.ExtentReports extent;

        static AventStack.ExtentReports.ExtentTest feature;
        AventStack.ExtentReports.ExtentTest step;
        AventStack.ExtentReports.ExtentTest scenario;
        static string reportPath = System.IO.Directory.GetParent(@"../../../").FullName
            + Path.DirectorySeparatorChar + "Result"
            + Path.DirectorySeparatorChar + "Result_" + DateTime.Now.ToString("ddMMyyy");

        [BeforeTestRun]

        public static void BeforeTestRun()
        {

            ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(reportPath);
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlReport);
        }

        [BeforeFeature]

        public static void BeforeFeature(FeatureContext context)
        {


            feature = extent.CreateTest(context.FeatureInfo.Title);
            
        }

        [BeforeScenario]

        public  void BeforeScenario(ScenarioContext context)
        {

            scenario = feature.CreateNode(context.ScenarioInfo.Title);

        }

        [BeforeStep]

        public void BeforeStep()
        {

            step = scenario;

        }

        [AfterStep]

        public  void Afterstep( ScenarioContext context)
        {

            if (context.TestError == null)
            {
                
                step.Log(AventStack.ExtentReports.Status.Pass, context.StepContext.StepInfo.Text);

            }
            else if (context.TestError != null)
            {

                step.Log(AventStack.ExtentReports.Status.Fail, context.StepContext.StepInfo.Text);

            }

        }
        [AfterFeature]

        public static void AfterFeature()
        {
            extent.Flush();
        }



    }
}
