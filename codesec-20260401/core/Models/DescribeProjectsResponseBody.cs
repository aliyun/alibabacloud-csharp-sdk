// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class DescribeProjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of projects.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<DescribeProjectsResponseBodyItems> Items { get; set; }
        public class DescribeProjectsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The project configuration version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("configRevision")]
            [Validation(Required=false)]
            public long? ConfigRevision { get; set; }

            /// <summary>
            /// <para>The time when the project was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-28T03:36:31.573Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The user ID of the project creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11111</para>
            /// </summary>
            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The engine switches for the project or scan snapshot. Only SAST and SCA are supported.</para>
            /// </summary>
            [NameInMap("engines")]
            [Validation(Required=false)]
            public DescribeProjectsResponseBodyItemsEngines Engines { get; set; }
            public class DescribeProjectsResponseBodyItemsEngines : TeaModel {
                /// <summary>
                /// <para>Indicates whether SAST is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("sast")]
                [Validation(Required=false)]
                public bool? Sast { get; set; }

                /// <summary>
                /// <para>Indicates whether SCA is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("sca")]
                [Validation(Required=false)]
                public bool? Sca { get; set; }

            }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>934</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The natural language prompt provided by the user that describes scanning or result processing preferences, such as ignoring low-risk vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("instructionPrompt")]
            [Validation(Required=false)]
            public string InstructionPrompt { get; set; }

            /// <summary>
            /// <para>The time when a task was last created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-28T03:36:31.573Z</para>
            /// </summary>
            [NameInMap("lastScanTime")]
            [Validation(Required=false)]
            public string LastScanTime { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>manual-hDecBn</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The project source.</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public DescribeProjectsResponseBodyItemsSource Source { get; set; }
            public class DescribeProjectsResponseBodyItemsSource : TeaModel {
                /// <summary>
                /// <para>The project type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>manual_upload</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The time when the project was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-28T03:36:31.573Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>The page size.</para>
        /// <remarks>
        /// <para>If this parameter is not specified, all projects are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. An empty value indicates the last page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJ0IjoiMjAyNi0wNy0xNlQwNzo1MzozOC4wMjFaIiwiaSI6MTAwMDQ0OH0</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A1F403F-0A85-5578-8B7C-55E3E9408659</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
