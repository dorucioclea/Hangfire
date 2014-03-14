﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HangFire.Tests.Server
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class JobFetcherFeature : Xunit.IUseFixture<JobFetcherFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "JobFetcher.feature"
#line hidden
        
        public JobFetcherFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "JobFetcher", "\r\n  As a user, I expect that my enqueued jobs will be dequeued by the Server.", ProgrammingLanguage.CSharp, new string[] {
                        "redis"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(JobFetcherFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "JobFetcher")]
        [Xunit.TraitAttribute("Description", "Fetcher should return the job payload when it dequeues a job")]
        public virtual void FetcherShouldReturnTheJobPayloadWhenItDequeuesAJob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fetcher should return the job payload when it dequeues a job", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
      testRunner.And("the fetcher listening the queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
     testRunner.When("it dequeues a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
     testRunner.Then("the fetcher should return the payload", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "JobFetcher")]
        [Xunit.TraitAttribute("Description", "Fetcher should remove the dequeued job from the queue and adds it to the dequeued" +
            " list")]
        public virtual void FetcherShouldRemoveTheDequeuedJobFromTheQueueAndAddsItToTheDequeuedList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fetcher should remove the dequeued job from the queue and adds it to the dequeued" +
                    " list", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
      testRunner.And("the fetcher listening the queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
     testRunner.When("it dequeues a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
     testRunner.Then("the queue should not contain the job anymore", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
      testRunner.But("the dequeued jobs list should contain it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "JobFetcher")]
        [Xunit.TraitAttribute("Description", "Fetcher should not return any job when it tries to dequeue a job from an empty qu" +
            "eue")]
        public virtual void FetcherShouldNotReturnAnyJobWhenItTriesToDequeueAJobFromAnEmptyQueue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fetcher should not return any job when it tries to dequeue a job from an empty qu" +
                    "eue", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
    testRunner.Given("an empty queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
      testRunner.And("the fetcher listening the queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
     testRunner.When("it dequeues a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
     testRunner.Then("the fetcher should not return any job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "JobFetcher")]
        [Xunit.TraitAttribute("Description", "Fetcher should dequeue jobs in the FIFO order")]
        public virtual void FetcherShouldDequeueJobsInTheFIFOOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fetcher should dequeue jobs in the FIFO order", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
    testRunner.Given("the \'first\' job in the queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
      testRunner.And("the \'second\' job in the queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
      testRunner.And("the fetcher listening the queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
     testRunner.When("it dequeues a job for the first time", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
     testRunner.Then("the fetcher should return the \'first\' job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
     testRunner.When("it dequeues a job for the second time", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
     testRunner.Then("the fetcher should return the \'second\' job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "JobFetcher")]
        [Xunit.TraitAttribute("Description", "Fetcher should listen only specified queue")]
        public virtual void FetcherShouldListenOnlySpecifiedQueue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fetcher should listen only specified queue", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
    testRunner.Given("a job in the \'another\' queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
     testRunner.And("the fetcher listening the \'default\' queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
     testRunner.When("it dequeues a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
     testRunner.Then("the fetcher should not return any job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "JobFetcher")]
        [Xunit.TraitAttribute("Description", "Fetcher should set the \'fetched\' flag when it dequeues a job")]
        public virtual void FetcherShouldSetTheFetchedFlagWhenItDequeuesAJob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fetcher should set the \'fetched\' flag when it dequeues a job", ((string[])(null)));
#line 40
this.ScenarioSetup(scenarioInfo);
#line 41
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
      testRunner.And("the fetcher listening the queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
     testRunner.When("it dequeues a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
     testRunner.Then("the job should have the \'fetched\' flag set", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                JobFetcherFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                JobFetcherFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
