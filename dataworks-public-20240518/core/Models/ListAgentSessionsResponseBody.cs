// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListAgentSessionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC response result.</para>
        /// </summary>
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public ListAgentSessionsResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class ListAgentSessionsResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <para>The JSON-RPC error information. This field is returned when the call fails and is not returned when the call succeeds.</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public ListAgentSessionsResponseBodyJsonRpcResponseError Error { get; set; }
            public class ListAgentSessionsResponseBodyJsonRpcResponseError : TeaModel {
                /// <summary>
                /// <para>The JSON-RPC error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <para>The optional additional error information. The content depends on the error type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public object Data { get; set; }

                /// <summary>
                /// <para>The business error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SESSION_FILTER_REQUIRED</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SESSION_FILTER_REQUIRED</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The request ID provided by the caller. This ID is returned as is in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29d9a29c-a284-48c1-9eaa-4a42c7c616d5</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The JSON-RPC version, which is fixed to 2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("Jsonrpc")]
            [Validation(Required=false)]
            public string Jsonrpc { get; set; }

            /// <summary>
            /// <para>The paginated result set for the session query.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public ListAgentSessionsResponseBodyJsonRpcResponseResult Result { get; set; }
            public class ListAgentSessionsResponseBodyJsonRpcResponseResult : TeaModel {
                /// <summary>
                /// <para>The session list.</para>
                /// </summary>
                [NameInMap("AgentSessions")]
                [Validation(Required=false)]
                public List<ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessions> AgentSessions { get; set; }
                public class ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessions : TeaModel {
                    /// <summary>
                    /// <para>The DataWorks extended session information, which is not part of the standard ACP protocol.</para>
                    /// </summary>
                    [NameInMap("Meta")]
                    [Validation(Required=false)]
                    public ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessionsMeta Meta { get; set; }
                    public class ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessionsMeta : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the session is archived.</para>
                        /// </summary>
                        [NameInMap("Archived")]
                        [Validation(Required=false)]
                        public bool? Archived { get; set; }

                        /// <summary>
                        /// <para>The session source.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>openapi_sdk</para>
                        /// </summary>
                        [NameInMap("SessionSource")]
                        [Validation(Required=false)]
                        public string SessionSource { get; set; }

                        /// <summary>
                        /// <para>The session connection status.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <list type="bullet">
                        /// <item><description>NORMAL: Stateless session</description></item>
                        /// <item><description>INIT: Initialized</description></item>
                        /// <item><description>RUNNING: Running</description></item>
                        /// <item><description>RELEASED: Released</description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("SessionStatus")]
                        [Validation(Required=false)]
                        public string SessionStatus { get; set; }

                        /// <summary>
                        /// <para>The session tag list.</para>
                        /// </summary>
                        [NameInMap("SessionTagList")]
                        [Validation(Required=false)]
                        public List<ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessionsMetaSessionTagList> SessionTagList { get; set; }
                        public class ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessionsMetaSessionTagList : TeaModel {
                            /// <summary>
                            /// <para>The session tag. You can filter sessions based on session tags. For example, if you use a fixed RAM user when calling OpenAPI but the calling system has its own account system, you need to filter the session list based on the account ID. In this case, you can pass the account ID of the calling system as this tag.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>user_123456</para>
                            /// </summary>
                            [NameInMap("SessionTagCode")]
                            [Validation(Required=false)]
                            public string SessionTagCode { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The session creation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456789</para>
                    /// </summary>
                    [NameInMap("SessionCreatedAt")]
                    [Validation(Required=false)]
                    public long? SessionCreatedAt { get; set; }

                    /// <summary>
                    /// <para>The session description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sales trend analysis</para>
                    /// </summary>
                    [NameInMap("SessionDescription")]
                    [Validation(Required=false)]
                    public string SessionDescription { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the session.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sess_0f12abc34</para>
                    /// </summary>
                    [NameInMap("SessionId")]
                    [Validation(Required=false)]
                    public string SessionId { get; set; }

                    /// <summary>
                    /// <para>The session title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sales analysis for the last 30 days</para>
                    /// </summary>
                    [NameInMap("SessionTitle")]
                    [Validation(Required=false)]
                    public string SessionTitle { get; set; }

                    /// <summary>
                    /// <para>The session update time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456789</para>
                    /// </summary>
                    [NameInMap("SessionUpdatedAt")]
                    [Validation(Required=false)]
                    public long? SessionUpdatedAt { get; set; }

                }

                /// <summary>
                /// <para>The actual number of entries per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxResults")]
                [Validation(Required=false)]
                public int? MaxResults { get; set; }

                /// <summary>
                /// <para>The token for the next page. Set this parameter to 1 for the first page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NextToken")]
                [Validation(Required=false)]
                public string NextToken { get; set; }

                /// <summary>
                /// <para>The total number of matched sessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID for this OpenAPI request, which can be used to troubleshoot call failures. This is not a session ID or event cursor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50C5A9F7-B5BD-58B2-9EB8-ADFFA9E6A56F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
