// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListAgentSessionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC response.</para>
        /// </summary>
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public ListAgentSessionsResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class ListAgentSessionsResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <para>The ID provided in the request. This value is returned unmodified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29d9a29c-a284-48c1-9eaa-4a42c7c616d5</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The JSON-RPC version. The value is always <c>2.0</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("Jsonrpc")]
            [Validation(Required=false)]
            public string Jsonrpc { get; set; }

            /// <summary>
            /// <para>The paginated results of the session query.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public ListAgentSessionsResponseBodyJsonRpcResponseResult Result { get; set; }
            public class ListAgentSessionsResponseBodyJsonRpcResponseResult : TeaModel {
                /// <summary>
                /// <para>A list of sessions.</para>
                /// </summary>
                [NameInMap("AgentSessions")]
                [Validation(Required=false)]
                public List<ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessions> AgentSessions { get; set; }
                public class ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessions : TeaModel {
                    /// <summary>
                    /// <para>DataWorks-specific session metadata. This field is not part of the standard ACP protocol.</para>
                    /// </summary>
                    [NameInMap("Meta")]
                    [Validation(Required=false)]
                    public ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessionsMeta Meta { get; set; }
                    public class ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessionsMeta : TeaModel {
                        /// <summary>
                        /// <para>The source of the session.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>openapi_sdk</para>
                        /// </summary>
                        [NameInMap("SessionSource")]
                        [Validation(Required=false)]
                        public string SessionSource { get; set; }

                        /// <summary>
                        /// <para>The session status.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <list type="bullet">
                        /// <item><description>NORMAL: 无状态的session</description></item>
                        /// <item><description>INIT: 初始化状态</description></item>
                        /// <item><description>RUNNING: 运行中</description></item>
                        /// <item><description>RELEASED: 释放状态</description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("SessionStatus")]
                        [Validation(Required=false)]
                        public string SessionStatus { get; set; }

                        /// <summary>
                        /// <para>A list of session tags.</para>
                        /// </summary>
                        [NameInMap("SessionTagList")]
                        [Validation(Required=false)]
                        public List<ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessionsMetaSessionTagList> SessionTagList { get; set; }
                        public class ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessionsMetaSessionTagList : TeaModel {
                            /// <summary>
                            /// <para>A tag for the session, which can be used for filtering. For example, if your application has its own user accounts but calls the API through a single service account, you can pass your application\&quot;s user ID as a tag. This allows you to filter sessions by your internal users.</para>
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
                    /// <para>The time the session was created.</para>
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
                    /// <para>The unique session ID.</para>
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
                    /// <para>The time the session was last modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456789</para>
                    /// </summary>
                    [NameInMap("SessionUpdatedAt")]
                    [Validation(Required=false)]
                    public long? SessionUpdatedAt { get; set; }

                }

                /// <summary>
                /// <para>The number of entries returned on the current page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxResults")]
                [Validation(Required=false)]
                public int? MaxResults { get; set; }

                /// <summary>
                /// <para>The token to retrieve the next page of results. To retrieve the first page, use the value <c>1</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NextToken")]
                [Validation(Required=false)]
                public string NextToken { get; set; }

                /// <summary>
                /// <para>The total number of sessions that match the query.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50C5A9F7-B5BD-58B2-9EB8-ADFFA9E6A56F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
