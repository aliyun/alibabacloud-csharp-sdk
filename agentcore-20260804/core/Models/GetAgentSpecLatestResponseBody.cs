// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetAgentSpecLatestResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAgentSpecLatestResponseBodyData Data { get; set; }
        public class GetAgentSpecLatestResponseBodyData : TeaModel {
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
            /// <para>The content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample content</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

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
            /// <para>Indicates whether the AgentSpec is enabled.</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The list of MCP server references.</para>
            /// </summary>
            [NameInMap("mcpServers")]
            [Validation(Required=false)]
            public List<GetAgentSpecLatestResponseBodyDataMcpServers> McpServers { get; set; }
            public class GetAgentSpecLatestResponseBodyDataMcpServers : TeaModel {
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
            /// <para>The resource file mapping.</para>
            /// </summary>
            [NameInMap("resource")]
            [Validation(Required=false)]
            public Dictionary<string, DataResourceValue> Resource { get; set; }

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
            /// <para>The list of skill references.</para>
            /// </summary>
            [NameInMap("skills")]
            [Validation(Required=false)]
            public List<GetAgentSpecLatestResponseBodyDataSkills> Skills { get; set; }
            public class GetAgentSpecLatestResponseBodyDataSkills : TeaModel {
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
