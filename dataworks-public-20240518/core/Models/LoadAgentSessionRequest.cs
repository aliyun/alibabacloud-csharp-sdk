// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class LoadAgentSessionRequest : TeaModel {
        /// <summary>
        /// <para>The ID passed by the requester. The value is returned as is.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4as3dasf654a</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC version. The value is fixed to 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The business parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public LoadAgentSessionRequestParams Params { get; set; }
        public class LoadAgentSessionRequestParams : TeaModel {
            /// <summary>
            /// <para>The ACP extension parameters of DataWorks.</para>
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public LoadAgentSessionRequestParamsMeta Meta { get; set; }
            public class LoadAgentSessionRequestParamsMeta : TeaModel {
                /// <summary>
                /// <para>Pulls the subsequent SSE output from the specified position in a resumable transfer scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("BeginLogOffset")]
                [Validation(Required=false)]
                public long? BeginLogOffset { get; set; }

                /// <summary>
                /// <para>Specifies whether this is a resumable transfer scenario. In scenarios where the SSE stream is unstable, such as network instability that causes the SSE connection to drop midway, you can use this flag to pull the SSE response data again from the breakpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
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
