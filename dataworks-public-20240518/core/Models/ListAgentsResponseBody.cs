// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListAgentsResponseBody : TeaModel {
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public ListAgentsResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class ListAgentsResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>70623e38-a889-4192-930a-752ffdd75f48</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Jsonrpc")]
            [Validation(Required=false)]
            public string Jsonrpc { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public ListAgentsResponseBodyJsonRpcResponseResult Result { get; set; }
            public class ListAgentsResponseBodyJsonRpcResponseResult : TeaModel {
                [NameInMap("Agents")]
                [Validation(Required=false)]
                public List<ListAgentsResponseBodyJsonRpcResponseResultAgents> Agents { get; set; }
                public class ListAgentsResponseBodyJsonRpcResponseResultAgents : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>chat_cli_chatbi</para>
                    /// </summary>
                    [NameInMap("AgentName")]
                    [Validation(Required=false)]
                    public string AgentName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxResults")]
                [Validation(Required=false)]
                public int? MaxResults { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("NextToken")]
                [Validation(Required=false)]
                public string NextToken { get; set; }

                /// <summary>
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
