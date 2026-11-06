// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class ListAgentSessionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC response object. The business result is located in Result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Jsonrpc&quot;:&quot;2.0&quot;,&quot;Id&quot;:&quot;request-001&quot;,&quot;Result&quot;:{&quot;MaxResults&quot;:20,&quot;NextToken&quot;:&quot;next-token-example&quot;,&quot;SessionList&quot;:[{&quot;sessionId&quot;:&quot;0123456789abcdef0123456789abcdef&quot;,&quot;title&quot;:&quot;代码评审&quot;,&quot;agentName&quot;:&quot;review-agent-demo&quot;,&quot;createdAt&quot;:1793232000000,&quot;updatedAt&quot;:1793232060000}]}}</para>
        /// </summary>
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public ListAgentSessionsResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class ListAgentSessionsResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <para>The Id from the request, echoed as is.</para>
            /// 
            /// <b>Example:</b>
            /// <para>request-001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The fixed value <c>2.0</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("Jsonrpc")]
            [Validation(Required=false)]
            public string Jsonrpc { get; set; }

            /// <summary>
            /// <para>The paginated result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;MaxResults&quot;:20,&quot;NextToken&quot;:&quot;next-token-example&quot;,&quot;SessionList&quot;:[{&quot;sessionId&quot;:&quot;0123456789abcdef0123456789abcdef&quot;}]}</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public ListAgentSessionsResponseBodyJsonRpcResponseResult Result { get; set; }
            public class ListAgentSessionsResponseBodyJsonRpcResponseResult : TeaModel {
                /// <summary>
                /// <para>The effective page size for the current page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("MaxResults")]
                [Validation(Required=false)]
                public int? MaxResults { get; set; }

                /// <summary>
                /// <para>The credential to continue querying the next page. Pass it as is to Params.NextToken. Pagination ends when the token is not returned or is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>next-token-example</para>
                /// </summary>
                [NameInMap("NextToken")]
                [Validation(Required=false)]
                public string NextToken { get; set; }

                /// <summary>
                /// <para>The array of session summaries for the current page. If no matching records are found, an empty array [] is returned. The type is any. The fields of array elements retain the original backend names. For the structure, see the supplementary description of response parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;sessionId&quot;:&quot;0123456789abcdef0123456789abcdef&quot;,&quot;title&quot;:&quot;Code review&quot;,&quot;agentName&quot;:&quot;review-agent-demo&quot;,&quot;createdAt&quot;:1793232000000,&quot;updatedAt&quot;:1793232060000}]</para>
                /// </summary>
                [NameInMap("SessionList")]
                [Validation(Required=false)]
                public object SessionList { get; set; }

            }

        }

        /// <summary>
        /// <para>The server-side request ID used to troubleshoot this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A1B2C3D-4E5F-6789-ABCD-EF0123456789</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
