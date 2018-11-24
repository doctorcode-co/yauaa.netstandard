﻿using FluentAssertions;
using OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS;
using OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS.Analyze;
using OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS.Analyze.TreeWalker;
using OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS.Analyze.TreeWalker.Steps;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OrbintSoft.Yauaa.Analyzer.Test.Parse.UserAgentNS.Analyze
{
    public class TestTreewalkerRequire
    {
        [Fact]
        public void ValidateWalkPathParsing()
        {
            string path = "IsNull[LookUp[TridentVersions;agent.(1)product.(2-4)comments.(*)product.name[1]=\"Trident\"" +
                "[2-3]~\"Foo\"^.(*)version[-2]{\"7.\";\"DefaultValue\"]]";

            string[] expectedHashEntries = {
                "agent.(1)product.(2)comments.(1)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(2)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(3)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(4)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(5)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(6)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(7)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(8)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(9)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(10)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(1)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(2)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(3)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(4)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(5)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(6)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(7)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(8)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(9)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(10)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(1)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(2)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(3)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(4)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(5)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(6)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(7)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(8)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(9)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(10)product.(1)name[1-1]=\"Trident\"",
            };

            string[] expectedWalkList = {
                "IsNull()",
                "WordRange([2:3])",
                "Contains(foo)",
                "Up()",
                "Down([1:5]version)",
                "WordRange([1:2])",
                "StartsWith(7.)",
                "Lookup(@TridentVersions ; default=DefaultValue)",
            };

            CheckPath(path, expectedHashEntries, expectedWalkList);
        }

        [Fact]
        public void ValidateWalkPathPruneAllSteps()
        {
            string path = "CleanVersion[agent.(1)product.(1)name[1-2]=\"Foo\"@[1]@]";

            string[] expectedHashEntries = {
                "agent.(1)product.(1)name[1-2]=\"Foo\"",
            };

            string[] expectedWalkList = {};

            CheckPath(path, expectedHashEntries, expectedWalkList);
        }

        [Fact]
        public void ValidateWalkPathPruneOne()
        {
            string path = "agent.(1)product.(1)name[1-2]=\"Foo\"^.(1-3)version@";

            string[] expectedHashEntries = {
                "agent.(1)product.(1)name[1-2]=\"Foo\"",
            };

            string[] expectedWalkList = {
                "Up()",
                "Down([1:3]version)"
            };

            CheckPath(path, expectedHashEntries, expectedWalkList);
        }

        [Fact]
        public void ValidateWalkPathPruneTwo()
        {
            string path = "CleanVersion[agent.(1)product.(1)name[1-2]=\"Foo\"^.(1-3)version@]";

            string[] expectedHashEntries = {
                "agent.(1)product.(1)name[1-2]=\"Foo\"",
            };

            string[] expectedWalkList = {
                "Up()",
                "Down([1:3]version)"
            };

            CheckPath(path, expectedHashEntries, expectedWalkList);
        }

        [Fact]
        public void ValidateWalkPathPruneFirstWord()
        {
            string path = "CleanVersion[agent.(1)product.(1)name[1-2]=\"Foo\"[1]@]";

            string[] expectedHashEntries = {
                "agent.(1)product.(1)name[1-2]=\"Foo\"",
            };

            string[] expectedWalkList = {};

            CheckPath(path, expectedHashEntries, expectedWalkList);
        }

        [Fact]
        public void ValidateWalkPathPruneSecondWord()
        {
            string path = "CleanVersion[agent.(1)product.(1)name[1-2]=\"Foo\"@[2]@]";

            string[] expectedHashEntries = { "agent.(1)product.(1)name[1-2]=\"Foo\"" };

            string[] expectedWalkList = { "BackToFull()", "WordRange([2:2])" };

            CheckPath(path, expectedHashEntries, expectedWalkList);
        }

        [Fact]
        public void ValidateWalkPathPruneUnfallableSteps()
        {
            string[] paths = {
                "NormalizeBrand[agent.(1)product.(1)name[1-2]=\"Foo\"@[2]@]",
                "CleanVersion[agent.(1)product.(1)name[1-2]=\"Foo\"@[2]@]",
                "Concat[\"Foo\";agent.(1)product.(1)name[1-2]=\"Foo\"@[2]@]",
                "Concat[\"Foo\";agent.(1)product.(1)name[1-2]=\"Foo\"@[2]@;\"Bar\"]",
                "Concat[agent.(1)product.(1)name[1-2]=\"Foo\"@[2]@;\"Bar\"]",
            };

            string[] expectedHashEntries = {
                "agent.(1)product.(1)name[1-2]=\"Foo\"",
            };

            string[] expectedWalkList = {
                "BackToFull()",
                "WordRange([2:2])"
            };

            foreach (string path in paths)
            {
                CheckPath(path, expectedHashEntries, expectedWalkList);
            }
        }

        [Fact]
        public void ValidateParseErrorUselessFixedString()
        {
            string path = "\"Safari\"";

            TestMatcher matcher = new TestMatcher(new Dictionary<string, IDictionary<string, string>>(), new Dictionary<string, ISet<string>>());
            MatcherRequireAction action = new MatcherRequireAction(path, matcher);            
            Action a = new Action(() => action.Initialize());
            a.Should().Throw<InvalidParserConfigurationException>();
        }


        [Fact]
        public void ValidateWalkPathParsingRange()
        {
            string path = "IsNull[LookUp[TridentVersions;agent.(1)product.(2-4)comments.(*)product.name[1]=\"Trident\"" +
                "[2-3]~\"Foo\"^.(*)version[2]{\"7.\";\"DefaultValue\"]]";

            string[] expectedHashEntries = {
                "agent.(1)product.(2)comments.(1)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(2)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(3)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(4)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(5)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(6)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(7)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(8)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(9)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(2)comments.(10)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(1)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(2)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(3)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(4)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(5)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(6)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(7)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(8)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(9)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(3)comments.(10)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(1)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(2)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(3)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(4)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(5)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(6)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(7)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(8)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(9)product.(1)name[1-1]=\"Trident\"",
                "agent.(1)product.(4)comments.(10)product.(1)name[1-1]=\"Trident\"",
            };

            string[] expectedWalkList = {
                "IsNull()",
                "WordRange([2:3])",
                "Contains(foo)",
                "Up()",
                "Down([1:5]version)",
                "WordRange([2:2])",
                "StartsWith(7.)",
                "Lookup(@TridentVersions ; default=DefaultValue)",
            };

            CheckPath(path, expectedHashEntries, expectedWalkList);
        }

        [Fact]
        public void ValidateStartsWithLength()
        {
            string value = "OneTwoThree";

            for (int i = 1; i <= value.Length; i++)
            {
                string matchValue = value.Substring(0, i);
                string hashValue = matchValue.Substring(0, Math.Min(UserAgentAnalyzerDirect.MAX_PREFIX_HASH_MATCH, matchValue.Length));

                string path = "IsNull[LookUp[TridentVersions;agent.(1)product.(1)name{\"" + matchValue + "\";\"DefaultValue\"]]";

                string[] expectedHashEntries = { "agent.(1)product.(1)name{\"" + hashValue + "\"" };

                string[] expectedWalkList;
                if (matchValue.Length > UserAgentAnalyzerDirect.MAX_PREFIX_HASH_MATCH)
                {
                    expectedWalkList = new string[]{
                        "IsNull()",
                        "StartsWith("+matchValue.ToLower()+")",
                        "Lookup(@TridentVersions ; default=DefaultValue)",
                    };
                }
                else
                {
                    expectedWalkList = new string[]{
                        "IsNull()",
                        // Short entries should not appear in the walk list to optimize performance
                        "Lookup(@TridentVersions ; default=DefaultValue)",
                    };
                }

                CheckPath(path, expectedHashEntries, expectedWalkList);
            }
        }

        private void CheckPath(string path, string[] expectedHashEntries, string[] expectedWalkList)
        {
            var lookups = new Dictionary<string, IDictionary<string, string>>
            {
                ["TridentVersions"] = new Dictionary<string, string>()
            };

            TestMatcher matcher = new TestMatcher(lookups, new Dictionary<string, ISet<string>>());
            var action = new MatcherRequireAction(path, matcher);
            action.Initialize();

            StringBuilder sb = new StringBuilder("\n---------------------------\nActual list (")
                .Append(matcher.reveicedValues.Count)
                .Append(" entries):\n");

            foreach (string actual in matcher.reveicedValues)
            {
                sb.Append(actual).Append('\n');
            }
            sb.Append("---------------------------\n");

            // Validate the expected hash entries (i.e. the first part of the path)
            foreach (string expect in expectedHashEntries)
            {
                matcher.reveicedValues.Contains(expect).Should().BeTrue("\nExpected:\n" + expect + sb.ToString());
            }

            expectedHashEntries.Length.Should().Be(matcher.reveicedValues.Count, "Found that number of entries");

            // Validate the expected walk list entries (i.e. the dynamic part of the path)
            TreeExpressionEvaluator evaluator = action.EvaluatorForUnitTesting;
            WalkList walkList = evaluator.GetWalkListForUnitTesting();

            Step step = walkList.GetFirstStep();
            foreach (string walkStep in expectedWalkList)
            {
                step.Should().NotBeNull("Step: " + walkStep);
                walkStep.Should().Be(step.ToString(), "step(" + step.ToString() + " should be " + walkStep + ")");
                step = step.GetNextStep();
            }
            step.Should().BeNull();
        }

        private class TestMatcher : Matcher
        {
            internal readonly IList<string> reveicedValues = new List<string>(128);

            internal TestMatcher(IDictionary<string, IDictionary<string, string>> lookups, IDictionary<string, ISet<string>> lookupSets) : base(null, lookups, lookupSets)
            {
            }


            public override void InformMeAbout(MatcherAction matcherAction, string keyPattern)
            {
                reveicedValues.Add(keyPattern);
            }


            public override void InformMeAboutPrefix(MatcherAction matcherAction, string treeName, string prefix)
            {
                InformMeAbout(matcherAction, treeName + "{\"" + UserAgentAnalyzerDirect.FirstCharactersForPrefixHash(prefix, UserAgentAnalyzerDirect.MAX_PREFIX_HASH_MATCH) + "\"");
            }


            public override void Analyze(UserAgent userAgent)
            {
                // Do nothing
            }


            public override void LookingForRange(string treeName, WordRangeVisitor.Range range)
            {
                // Do nothing
            }
        }
    }
}