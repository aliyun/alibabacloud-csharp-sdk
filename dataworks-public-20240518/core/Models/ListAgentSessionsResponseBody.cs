// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListAgentSessionsResponseBody : TeaModel {
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public ListAgentSessionsResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class ListAgentSessionsResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>29d9a29c-a284-48c1-9eaa-4a42c7c616d5</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Jsonrpc")]
            [Validation(Required=false)]
            public string Jsonrpc { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public ListAgentSessionsResponseBodyJsonRpcResponseResult Result { get; set; }
            public class ListAgentSessionsResponseBodyJsonRpcResponseResult : TeaModel {
                [NameInMap("AgentSessions")]
                [Validation(Required=false)]
                public List<ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessions> AgentSessions { get; set; }
                public class ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessions : TeaModel {
                    [NameInMap("Meta")]
                    [Validation(Required=false)]
                    public ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessionsMeta Meta { get; set; }
                    public class ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessionsMeta : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>openapi_sdk</para>
                        /// </summary>
                        [NameInMap("SessionSource")]
                        [Validation(Required=false)]
                        public string SessionSource { get; set; }

                        [NameInMap("SessionStatus")]
                        [Validation(Required=false)]
                        public string SessionStatus { get; set; }

                        [NameInMap("SessionTagList")]
                        [Validation(Required=false)]
                        public List<ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessionsMetaSessionTagList> SessionTagList { get; set; }
                        public class ListAgentSessionsResponseBodyJsonRpcResponseResultAgentSessionsMetaSessionTagList : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>user_123456</para>
                            /// </summary>
                            [NameInMap("SessionTagCode")]
                            [Validation(Required=false)]
                            public string SessionTagCode { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123456789</para>
                    /// </summary>
                    [NameInMap("SessionCreatedAt")]
                    [Validation(Required=false)]
                    public long? SessionCreatedAt { get; set; }

                    [NameInMap("SessionDescription")]
                    [Validation(Required=false)]
                    public string SessionDescription { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>sess_0f12abc34</para>
                    /// </summary>
                    [NameInMap("SessionId")]
                    [Validation(Required=false)]
                    public string SessionId { get; set; }

                    [NameInMap("SessionTitle")]
                    [Validation(Required=false)]
                    public string SessionTitle { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123456789</para>
                    /// </summary>
                    [NameInMap("SessionUpdatedAt")]
                    [Validation(Required=false)]
                    public long? SessionUpdatedAt { get; set; }

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
                /// <para>1</para>
                /// </summary>
                [NameInMap("NextToken")]
                [Validation(Required=false)]
                public string NextToken { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
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
        /// <para>50C5A9F7-B5BD-58B2-9EB8-ADFFA9E6A56F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
