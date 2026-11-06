// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class ListAgentSessionsRequest : TeaModel {
        /// <summary>
        /// <para>The correlation identifier for this call. It is echoed in the response and does not provide idempotency guarantees.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC protocol version. Set this parameter to <c>2.0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The business parameter object. The public fields are only AgentName, MaxResults, and NextToken.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AgentName&quot;:&quot;review-agent-demo&quot;,&quot;MaxResults&quot;:20}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public ListAgentSessionsRequestParams Params { get; set; }
        public class ListAgentSessionsRequestParams : TeaModel {
            /// <summary>
            /// <para>Optional. Filters sessions by agent name. The maximum length is 64 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>review-agent-demo</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page. Valid values: 1 to 100. Default value: 50. Keep the page size and filter conditions consistent for subsequent pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The NextToken returned from the previous page. Do not pass this parameter on the first page. In the first phase, the default uses a native opaque cursor. Keep the same filter conditions and pass the token back as is.</para>
            /// 
            /// <b>Example:</b>
            /// <para>next-token-example</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}
