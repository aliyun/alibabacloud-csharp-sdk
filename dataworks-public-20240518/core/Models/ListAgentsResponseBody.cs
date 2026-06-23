// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListAgentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response object that conforms to the JSON-RPC specification.</para>
        /// </summary>
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public ListAgentsResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class ListAgentsResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <para>The request ID passed in by the caller. The value is returned as-is in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70623e38-a889-4192-930a-752ffdd75f48</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The JSON-RPC version. Fixed value: 2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("Jsonrpc")]
            [Validation(Required=false)]
            public string Jsonrpc { get; set; }

            /// <summary>
            /// <para>The paginated query result for agents.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public ListAgentsResponseBodyJsonRpcResponseResult Result { get; set; }
            public class ListAgentsResponseBodyJsonRpcResponseResult : TeaModel {
                /// <summary>
                /// <para>The list of agents.</para>
                /// </summary>
                [NameInMap("Agents")]
                [Validation(Required=false)]
                public List<ListAgentsResponseBodyJsonRpcResponseResultAgents> Agents { get; set; }
                public class ListAgentsResponseBodyJsonRpcResponseResultAgents : TeaModel {
                    /// <summary>
                    /// <para>The agent name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chat_cli_chatbi</para>
                    /// </summary>
                    [NameInMap("AgentName")]
                    [Validation(Required=false)]
                    public string AgentName { get; set; }

                }

                /// <summary>
                /// <para>The actual number of entries per page that takes effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxResults")]
                [Validation(Required=false)]
                public int? MaxResults { get; set; }

                /// <summary>
                /// <para>The token for the next page. The value is null when the current page is the last page or no data is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("NextToken")]
                [Validation(Required=false)]
                public string NextToken { get; set; }

                /// <summary>
                /// <para>The total number of agents that match the filter criteria.</para>
                /// 
                /// <b>Example:</b>
                /// <para>27</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4003B739-C33C-5297-B810-0490EEE5A767</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
