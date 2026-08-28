// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListAgentSpecsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListAgentSpecsResponseBodyData Data { get; set; }
        public class ListAgentSpecsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data on the current page.</para>
            /// </summary>
            [NameInMap("pageItems")]
            [Validation(Required=false)]
            public List<ListAgentSpecsResponseBodyDataPageItems> PageItems { get; set; }
            public class ListAgentSpecsResponseBodyDataPageItems : TeaModel {
                /// <summary>
                /// <para>The business tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample property value</para>
                /// </summary>
                [NameInMap("bizTags")]
                [Validation(Required=false)]
                public string BizTags { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A sample description that explains the purpose of the resource</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The download count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("downloadCount")]
                [Validation(Required=false)]
                public long? DownloadCount { get; set; }

                /// <summary>
                /// <para>The version currently being edited.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("editingVersion")]
                [Validation(Required=false)]
                public string EditingVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the AgentSpec is enabled.</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UPLOAD</para>
                /// </summary>
                [NameInMap("from")]
                [Validation(Required=false)]
                public string From { get; set; }

                /// <summary>
                /// <para>The version labels.</para>
                /// </summary>
                [NameInMap("labels")]
                [Validation(Required=false)]
                public Dictionary<string, string> Labels { get; set; }

                /// <summary>
                /// <para>The list of MCP server references.</para>
                /// </summary>
                [NameInMap("mcpServers")]
                [Validation(Required=false)]
                public List<ListAgentSpecsResponseBodyDataPageItemsMcpServers> McpServers { get; set; }
                public class ListAgentSpecsResponseBodyDataPageItemsMcpServers : TeaModel {
                    /// <summary>
                    /// <para>The name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agentspec-example</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agentspec-example</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of online versions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("onlineCnt")]
                [Validation(Required=false)]
                public int? OnlineCnt { get; set; }

                /// <summary>
                /// <para>The version currently under review.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("reviewingVersion")]
                [Validation(Required=false)]
                public string ReviewingVersion { get; set; }

                /// <summary>
                /// <para>The visibility scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PRIVATE</para>
                /// </summary>
                [NameInMap("scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// <para>The list of Skill references.</para>
                /// </summary>
                [NameInMap("skills")]
                [Validation(Required=false)]
                public List<ListAgentSpecsResponseBodyDataPageItemsSkills> Skills { get; set; }
                public class ListAgentSpecsResponseBodyDataPageItemsSkills : TeaModel {
                    /// <summary>
                    /// <para>The name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agentspec-example</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The update time. This value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1787671022000</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("pagesAvailable")]
            [Validation(Required=false)]
            public int? PagesAvailable { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-47A8-90AB-CDEF12345678</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
