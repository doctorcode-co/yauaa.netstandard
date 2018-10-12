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
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * All rights should be reserved to the original author Niels Basjes
 */

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS.Analyze.TreeWalker.Steps.Walk.StepDowns;
using OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS.Antlr4Source;
using System.Collections.Generic;
using System.IO;

namespace OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS.Analyze.TreeWalker.Steps.Walk
{
    public class StepDown: Step
    {
        private readonly int start;
        private readonly int end;
        private readonly string name;
        private UserAgentGetChildrenVisitor userAgentGetChildrenVisitor;

        /// <summary>
        /// Initialize the transient default values
        /// </summary>
        private void SetDefaultFieldValues()
        {
            userAgentGetChildrenVisitor = new UserAgentGetChildrenVisitor(name, start, end);
        }

        private void ReadObject(Stream stream)
        {
            SetDefaultFieldValues();
        }

        public StepDown(UserAgentTreeWalkerParser.NumberRangeContext numberRange, string name): this(NumberRangeVisitor.GetList(numberRange), name)
        {
            
        }

        private StepDown(NumberRangeList numberRange, string name)
        {
            this.name = name;
            start = numberRange.GetStart();
            end = numberRange.GetEnd();
            SetDefaultFieldValues();
        }

        public override string ToString()
        {
            return "Down([" + start + ":" + end + "]" + name + ")";
        }

        public override WalkList.WalkResult Walk(IParseTree tree, string value)
        {
            IEnumerator<ParserRuleContext> children = userAgentGetChildrenVisitor.Visit(tree);
            while(children.MoveNext())
            {
                ParserRuleContext child = children.Current;
                WalkList.WalkResult childResult = WalkNextStep(child, null);
                if (childResult != null)
                {
                    return childResult;
                }
            }
            return null;
        }
    }
}
