﻿//<copyright file="TestAnnotationBadUsages.cs" company="OrbintSoft">
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
//<date>2018, 10, 10, 09:10</date>
//<summary></summary>

namespace OrbintSoft.Yauaa.Analyzer.Test.Parse.UserAgentNS.Annotate
{
    using FluentAssertions;
    using OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS.Analyze;
    using OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS.Annotate;
    using OrbintSoft.Yauaa.Analyzer.Test.Fixtures;
    using System;
    using Xunit;

    /// <summary>
    /// Defines the <see cref="TestAnnotationBadUsages" />
    /// </summary>
    public class TestAnnotationBadUsages : IClassFixture<LogFixture>
    {
        /// <summary>
        /// The TestNullInitAnalyzer
        /// </summary>
        [Fact]
        public void TestNullInitAnalyzer()
        {
            UserAgentAnnotationAnalyzer<string> userAgentAnalyzer = new UserAgentAnnotationAnalyzer<string>();
            userAgentAnalyzer.Invoking(u => u.Initialize(null)).Should().Throw<InvalidParserConfigurationException>().Which.Message.Should().StartWith("[Initialize] The mapper instance is null.");
        }

        /// <summary>
        /// The TestNullInit
        /// </summary>
        [Fact]
        public void TestNullInit()
        {
            UserAgentAnnotationAnalyzer<string> userAgentAnalyzer = new UserAgentAnnotationAnalyzer<string>();
            userAgentAnalyzer.Map(null).Should().BeNull();
        }

        /// <summary>
        /// The TestNoInit
        /// </summary>
        [Fact]
        public void TestNoInit()
        {
            UserAgentAnnotationAnalyzer<string> userAgentAnalyzer = new UserAgentAnnotationAnalyzer<string>();
            userAgentAnalyzer.Invoking(u => u.Map("Foo")).Should().Throw<InvalidParserConfigurationException>().Which.Message.Should().StartWith("[Map] The mapper instance is null.");
        }

        /// <summary>
        /// Defines the <see cref="BaseMapperWithoutGenericType{T}" />
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract class BaseMapperWithoutGenericType<T> : IUserAgentAnnotationMapper<T>
        {
            /// <summary>
            /// The GetUserAgentString
            /// </summary>
            /// <param name="record">The record<see cref="T"/></param>
            /// <returns>The <see cref="string"/></returns>
            public abstract string GetUserAgentString(T record);
        }

        /// <summary>
        /// Defines the <see cref="MapperWithoutGenericType" />
        /// </summary>
        public class MapperWithoutGenericType : BaseMapperWithoutGenericType<dynamic>
        {
            /// <summary>
            /// Defines the userAgentAnalyzer
            /// </summary>
            private UserAgentAnnotationAnalyzer<dynamic> userAgentAnalyzer;

            /// <summary>
            /// Initializes a new instance of the <see cref="MapperWithoutGenericType"/> class.
            /// </summary>
            public MapperWithoutGenericType()
            {
                Type generic = typeof(UserAgentAnnotationAnalyzer<>);
                Type[] typeArgs = { null };

                var makeme = generic.MakeGenericType(typeArgs);
                userAgentAnalyzer = Activator.CreateInstance(makeme) as UserAgentAnnotationAnalyzer<dynamic>;
                userAgentAnalyzer.Initialize(this);
            }

            /// <summary>
            /// The Enrich
            /// </summary>
            /// <param name="record">The record<see cref="object"/></param>
            /// <returns>The <see cref="object"/></returns>
            public object Enrich(object record)
            {
                return record;
            }

            /// <summary>
            /// The GetUserAgentString
            /// </summary>
            /// <param name="record">The record<see cref="dynamic"/></param>
            /// <returns>The <see cref="string"/></returns>
            public override string GetUserAgentString(dynamic record)
            {
                return null;
            }
        }

        /// <summary>
        /// The TestMissingTypeParameter
        /// </summary>
        [Fact]
        public void TestMissingTypeParameter()
        {
        }
    }
}