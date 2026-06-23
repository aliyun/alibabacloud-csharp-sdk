// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMcpServersResponseBody : TeaModel {
        /// <summary>
        /// <para>The paging information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListMcpServersResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListMcpServersResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The maximum number of results returned on the current page.****</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>A list of MCP Server objects.</para>
            /// </summary>
            [NameInMap("McpServers")]
            [Validation(Required=false)]
            public List<ListMcpServersResponseBodyPagingInfoMcpServers> McpServers { get; set; }
            public class ListMcpServersResponseBodyPagingInfoMcpServers : TeaModel {
                /// <summary>
                /// <para>The connection configuration of the MCP Server.</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public ListMcpServersResponseBodyPagingInfoMcpServersConfig Config { get; set; }
                public class ListMcpServersResponseBodyPagingInfoMcpServersConfig : TeaModel {
                    /// <summary>
                    /// <para>The custom headers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("CustomHeaders")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> CustomHeaders { get; set; }

                    /// <summary>
                    /// <para>The transport protocol.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SSE</para>
                    /// </summary>
                    [NameInMap("Transport")]
                    [Validation(Required=false)]
                    public string Transport { get; set; }

                    /// <summary>
                    /// <para>The service address of the MCP Server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/mcp/sse">https://example.com/mcp/sse</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The creator ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>805298765622151</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The creation time, as a millisecond timestamp.****</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>1780555634000</para>
                /// </summary>
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                /// <summary>
                /// <para>The last modified time, as a millisecond timestamp.****</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>1780555634000</para>
                /// </summary>
                [NameInMap("GmtModifiedTime")]
                [Validation(Required=false)]
                public string GmtModifiedTime { get; set; }

                /// <summary>
                /// <para>The ID of the user who last modified the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("ModifierId")]
                [Validation(Required=false)]
                public string ModifierId { get; set; }

                /// <summary>
                /// <para>The name of the MCP Server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-mcp-server</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The visibility level.****</para>
                /// 
                /// <b>Example:</b>
                /// <para>TENANT</para>
                /// </summary>
                [NameInMap("Visibility")]
                [Validation(Required=false)]
                public string Visibility { get; set; }

            }

            /// <summary>
            /// <para>The token for the next page of results. A null value indicates that all results have been returned.****</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total count of entries that match the filter criteria.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>824F80BA-1778-5D8A-BAFF-668A4D9C4CC7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
