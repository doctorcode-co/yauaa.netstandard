﻿//-----------------------------------------------------------------------
// <copyright file="IFieldCalculator.cs" company="OrbintSoft">
//   Yet Another User Agent Analyzer for .NET Standard
//   porting realized by Stefano Balzarotti, Copyright 2018-2020 (C) OrbintSoft
//
//   Original Author and License:
//
//   Yet Another UserAgent Analyzer
//   Copyright(C) 2013-2020 Niels Basjes
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//   https://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// <author>Stefano Balzarotti, Niels Basjes</author>
// <date>2020, 04, 16, 01:26</date>
//-----------------------------------------------------------------------

namespace OrbintSoft.Yauaa.Calculate
{
    using OrbintSoft.Yauaa.Analyzer;

    /// <summary>
    /// Interface for a field calculator.
    /// </summary>
    public interface IFieldCalculator
    {
        /// <summary>
        /// Calculate derived fields from a user agent.
        /// </summary>
        /// <param name="userAgent"><see cref="UserAgent"/>.</param>
        void Calculate(UserAgent userAgent);
    }
}
