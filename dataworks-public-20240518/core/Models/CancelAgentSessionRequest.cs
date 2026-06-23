// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CancelAgentSessionRequest : TeaModel {
        /// <summary>
        /// <para>The ID passed by the requester. The value is returned as-is in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>676303114031776</para>
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
        /// <para>The business parameters of the request.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public CancelAgentSessionRequestParams Params { get; set; }
        public class CancelAgentSessionRequestParams : TeaModel {
            /// <summary>
            /// <para>The ID of the session to cancel. This parameter is required.</para>
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
