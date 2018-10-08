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
    public class TestTreewalkerParsing
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

                string[] expectedHashEntries = {
                    "agent.(1)product.(1)name{\"" + hashValue + "\"",
                };

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

        [Fact]
        public void ValidateWalkPathSimpleName()
        {
            string path = "agent.(1)product.(1)name";

            string[] expectedHashEntries = {
                "agent.(1)product.(1)name",
            };

            string[] expectedWalkList = {};

            CheckPath(path, expectedHashEntries, expectedWalkList);
        }

        [Fact]
        public void ValidateWalkPathSimpleNameEquals()
        {
            string path = "agent.(1)product.(1)name=\"Foo\"^.(1-3)version";

            string[] expectedHashEntries = {
                "agent.(1)product.(1)name=\"Foo\"",
            };

            string[] expectedWalkList = {
                "Up()",
                "Down([1:3]version)"
            };

            CheckPath(path, expectedHashEntries, expectedWalkList);
        }

        [Fact]
        public void ValidateWalkPathNameSubstring()
        {
            string path = "agent.(1)product.(1)name[1-2]=\"Foo\"^.(1-3)version";

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
        public void ValidateWalkPathNameSubstring2()
        {
            string path = "agent.(1)product.(1)name[3-5]=\"Foo\"^.(1-3)version";

            string[] expectedHashEntries = {
                "agent.(1)product.(1)name[3-5]=\"Foo\"",
            };

            string[] expectedWalkList = {
                "Up()",
                "Down([1:3]version)"
            };

            CheckPath(path, expectedHashEntries, expectedWalkList);
        }

        [Fact]
        public void ValidateWalkAroundTheWorld()
        {
            string path = "agent.(2-4)product.(1)comments.(5-6)entry.(1)text[2]=\"seven\"^^^<.name=\"foo faa\"^.comments.entry.text[-2]=\"three\"@[1-1]";

            string[] expectedHashEntries = {
                "agent.(2)product.(1)comments.(5)entry.(1)text[2-2]=\"seven\"",
                "agent.(2)product.(1)comments.(6)entry.(1)text[2-2]=\"seven\"",
                "agent.(3)product.(1)comments.(5)entry.(1)text[2-2]=\"seven\"",
                "agent.(3)product.(1)comments.(6)entry.(1)text[2-2]=\"seven\"",
                "agent.(4)product.(1)comments.(5)entry.(1)text[2-2]=\"seven\"",
                "agent.(4)product.(1)comments.(6)entry.(1)text[2-2]=\"seven\"",
            };

            string[] expectedWalkList = {
                "Up()",
                "Up()",
                "Up()",
                "Prev(1)",
                "Down([1:1]name)",
                "Equals(foo faa)",
                "Up()",
                "Down([1:2]comments)",
                "Down([1:20]entry)",
                "Down([1:8]text)",
                "WordRange([1:2])",
                "Equals(three)",
                "BackToFull()",
                "WordRange([1:1])",
            };

            CheckPath(path, expectedHashEntries, expectedWalkList);
        }

        [Fact]
        public void ValidateWalkPathParsingCleanVersion()
        {

            string path = "CleanVersion[LookUp[TridentVersions;agent.(1)product.(2-4)comments.(*)product.name[1-1]=\"Trident\"" +
                "^.(*)version[-2]{\"7.\";\"DefaultValue\"]]";

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
                "Up()",
                "Down([1:5]version)",
                "WordRange([1:2])",
                "StartsWith(7.)",
                "Lookup(@TridentVersions ; default=DefaultValue)",
                "CleanVersion()"
            };

            CheckPath(path, expectedHashEntries, expectedWalkList);
        }


        private void CheckPath(string path, string[] expectedHashEntries, string[] expectedWalkList)
        {
            Dictionary<string, Dictionary<string, string>> lookups = new Dictionary<string, Dictionary<string, string>>();
            lookups["TridentVersions"] = new Dictionary<string, string>();

            TestMatcher matcher = new TestMatcher(lookups, new Dictionary<string, HashSet<string>>());
            MatcherRequireAction action = new MatcherRequireAction(path, matcher);
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
            expectedHashEntries.Length.Should().Be(matcher.reveicedValues.Count, "I expect that number of entries");

            // Validate the expected walk list entries (i.e. the dynamic part of the path)
            TreeExpressionEvaluator evaluator = action.GetEvaluatorForUnitTesting();
            WalkList walkList = evaluator.GetWalkListForUnitTesting();

            Step step = walkList.GetFirstStep();
            foreach (string walkStep in expectedWalkList)
            {
                step.Should().NotBeNull(step + " + walkStep");
                walkStep.Should().Be(step.ToString(), "Wrong step (" + step.ToString() + " should be " + walkStep + ")");
                step = step.GetNextStep();
            }
            step.Should().Be(null);
        }

        private class TestMatcher : Matcher
        {
            internal readonly List<string> reveicedValues = new List<string>(128);

            internal TestMatcher(Dictionary<string, Dictionary<string, string>> lookups, Dictionary<string, HashSet<string>> lookupSets) : base(null, lookups, lookupSets)
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