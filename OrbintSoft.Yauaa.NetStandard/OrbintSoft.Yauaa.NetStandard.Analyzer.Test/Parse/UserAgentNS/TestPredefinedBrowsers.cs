﻿/*
 * Yet Another UserAgent Analyzer .NET Standard
 * Porting realized by Balzarotti Stefano, Copyright (C) OrbintSoft
 * 
 * Original Author and License:
 * 
 * Yet Another UserAgent Analyzer
 * Copyright (C) 2013-2018 Niels Basjes
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * All rights should be reserved to the original author Niels Basjes
 */

using FluentAssertions;
using log4net;
using OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS.Debug;
using OrbintSoft.Yauaa.Analyzer.Test.Fixtures;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OrbintSoft.Yauaa.Analyzer.Test.Parse.UserAgentNS
{
    public class TestPredefinedBrowsers : IClassFixture<LogFixture>
    {
        private static readonly ILog LOG = LogManager.GetLogger(typeof(TestPredefinedBrowsers));

        [Fact]
        public void ValidateAllPredefinedBrowsers()
        {
            UserAgentAnalyzerTester uaa;
            uaa = UserAgentAnalyzerTester
                .NewBuilder()
                .ImmediateInitialization()                
                .Build() as UserAgentAnalyzerTester;
            LOG.Info("==============================================================");
            LOG.Info("Validating when getting all fields");
            LOG.Info("--------------------------------------------------------------");
            uaa.RunTests(false, true, null, false, true).Should().BeTrue();
        }

        private void ValidateAllPredefinedBrowsersMultipleFields(ICollection<string> fields)
        {
            LOG.Info("==============================================================");
            LOG.Info(string.Format("Validating when ONLY asking for {0}", fields.ToString()));
            LOG.Info("--------------------------------------------------------------");
            UserAgentAnalyzerTester userAgentAnalyzer =
                UserAgentAnalyzerTester
                    .NewBuilder()
                    .WithoutCache()
                    .WithFields(fields)
                    .HideMatcherLoadStats()
                    .Build() as UserAgentAnalyzerTester;

            userAgentAnalyzer.Should().NotBeNull();
            userAgentAnalyzer.RunTests(false, true, fields, false, false).Should().BeTrue();
        }

        [Fact]
        public void Validate_DeviceClass_AgentNameVersionMajor()
        {
            HashSet<string> fields = new HashSet<string>
            {
                "DeviceClass",
                "AgentNameVersionMajor"
            };
            ValidateAllPredefinedBrowsersMultipleFields(fields);
        }

        [Fact]
        public void Validate_DeviceClass_AgentNameVersionMajor_OperatingSystemVersionBuild()
        {
            HashSet<string> fields = new HashSet<string>
            {
                "DeviceClass",
                "AgentNameVersionMajor",
                "OperatingSystemVersionBuild"
            };
            ValidateAllPredefinedBrowsersMultipleFields(fields);
        }

        [Fact]
        public void MakeSureWeDoNotHaveDuplicateTests()
        {
            UserAgentAnalyzerTester uaa = UserAgentAnalyzerTester.NewBuilder().Build() as UserAgentAnalyzerTester;

            Dictionary<string, List<string>> allTestInputs = new Dictionary<string, List<string>>(2000);
            HashSet<string> duplicates = new HashSet<string>();
            foreach (Dictionary<string, Dictionary<string, string>> testCase in uaa.GetAllTestCases())
            {
                string input = testCase["input"]["user_agent_string"];
                string location = testCase["metaData"]["filename"] + ":" + testCase["metaData"]["fileline"];
                List<string> locations;
                if (allTestInputs.ContainsKey(input))
                {
                    locations = allTestInputs[input];
                }
                else
                { 
                    locations = new List<string>();
                }
                locations.Add(location);

                if (locations.Count > 1)
                {
                    duplicates.Add(input);
                }
                allTestInputs[input] = locations;
            }

            duplicates.Count.Should().Be(0);
            if (duplicates.Count > 0)
            {
                StringBuilder sb = new StringBuilder(1024);
                foreach (string duplicate in duplicates)
                {
                    sb.Append("======================================================\n")
                        .Append("Testcase > ").Append(duplicate).Append("\n");
                    int count = 0;
                    foreach (string location in allTestInputs[duplicate])
                    {
                        sb.Append(">Location ").Append(++count).Append(".(").Append(location).Append(")\n");
                    }
                }
                LOG.Info("Found " + duplicates.Count + " testcases multiple times: \n" + sb.ToString());
            }
        }
    }
}
