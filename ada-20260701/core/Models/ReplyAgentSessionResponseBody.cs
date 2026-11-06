// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class ReplyAgentSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC response. For core embedded fields, see the supplementary description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;jsonrpc&quot;:&quot;2.0&quot;,&quot;id&quot;:&quot;request-001&quot;,&quot;result&quot;:{&quot;accepted&quot;:true}}</para>
        /// </summary>
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public object JsonRpcResponse { get; set; }

        /// <summary>
        /// <para>The ID of the current request, used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A1B2C3D-4E5F-6789-ABCD-EF0123456789</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current API call is successful. This parameter cannot replace the business acceptance result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
