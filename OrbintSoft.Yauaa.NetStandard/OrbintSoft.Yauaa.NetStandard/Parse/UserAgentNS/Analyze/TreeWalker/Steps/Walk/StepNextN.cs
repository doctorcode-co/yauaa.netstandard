﻿//<copyright file="StepNextN.cs" company="OrbintSoft">
//	Yet Another UserAgent Analyzer.NET Standard
//	Porting realized by Stefano Balzarotti, Copyright (C) OrbintSoft
//
//	Original Author and License:
//
//	Yet Another UserAgent Analyzer
//	Copyright(C) 2013-2018 Niels Basjes
//
//	Licensed under the Apache License, Version 2.0 (the "License");
//	you may not use this file except in compliance with the License.
//	You may obtain a copy of the License at
//
//	https://www.apache.org/licenses/LICENSE-2.0
//
//	Unless required by applicable law or agreed to in writing, software
//	distributed under the License is distributed on an "AS IS" BASIS,
//	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//	See the License for the specific language governing permissions and
//	limitations under the License.
//
//</copyright>
//<author>Stefano Balzarotti, Niels Basjes</author>
//<date>2018, 8, 16, 01:59</date>
//<summary></summary>

using Antlr4.Runtime.Tree;
using System;

namespace OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS.Analyze.TreeWalker.Steps.Walk
{
    [Serializable]
    public class StepNextN: Step
    {
        private readonly int steps;

        public StepNextN(int steps)
        {
            this.steps = steps;
        }

        private IParseTree Next(IParseTree tree)
        {
            IParseTree parent = Up(tree);
            IParseTree child;
            bool foundCurrent = false;
            int stepsToDo = steps;
            for (int i = 0; i < parent.ChildCount; i++)
            {
                child = parent.GetChild(i);
                if (foundCurrent)
                {
                    if (TreeIsSeparator(child))
                    {
                        continue;
                    }
                    stepsToDo--;
                    if (stepsToDo == 0)
                    {
                        return child;
                    }
                }

                if (child == tree)
                {
                    foundCurrent = true;
                }
            }
            return null; // There is no next
        }


        public override WalkList.WalkResult Walk(IParseTree tree, string value)
        {
            IParseTree nextTree = Next(tree);
            if (nextTree == null)
            {
                return null;
            }

            return WalkNextStep(nextTree, null);
        }

        public override string ToString()
        {
            return "Next(" + steps + ")";
        }
    }
}
