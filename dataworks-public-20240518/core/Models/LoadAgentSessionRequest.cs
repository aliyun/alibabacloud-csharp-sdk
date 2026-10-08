// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class LoadAgentSessionRequest : TeaModel {
        /// <summary>
        /// <para>The client-generated request ID, which is returned in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4as3dasf654a</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC version. The value must be <c>2.0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>Business parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public LoadAgentSessionRequestParams Params { get; set; }
        public class LoadAgentSessionRequestParams : TeaModel {
            /// <summary>
            /// <para>DataWorks-specific extended parameters for ACP.</para>
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public LoadAgentSessionRequestParamsMeta Meta { get; set; }
            public class LoadAgentSessionRequestParamsMeta : TeaModel {
                /// <summary>
                /// <para>In a resumable transfer scenario, this specifies the offset from which to resume fetching the SSE output.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("BeginLogOffset")]
                [Validation(Required=false)]
                public long? BeginLogOffset { get; set; }

                /// <summary>
                /// <para>Specifies whether to use resumable transfer. If the SSE stream is interrupted due to issues like an unstable network connection, you can set this parameter to <c>true</c> to re-fetch the stream data from the point of failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true or false</para>
                /// </summary>
                [NameInMap("IsReload")]
                [Validation(Required=false)]
                public bool? IsReload { get; set; }

            }

            /// <summary>
            /// <para>The ID of the target session. If the session does not exist, an SSE error frame is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sess_0f12abc34</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

    }

}
