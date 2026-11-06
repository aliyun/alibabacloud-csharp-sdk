// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class GetAgentSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The response object. The business result is located in <c>result</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;jsonrpc&quot;:&quot;2.0&quot;,&quot;id&quot;:&quot;request-001&quot;,&quot;result&quot;:{&quot;sessionId&quot;:&quot;0123456789abcdef0123456789abcdef&quot;,&quot;title&quot;:&quot;Code review&quot;,&quot;displayName&quot;:&quot;Code review&quot;,&quot;agentName&quot;:&quot;review-agent-demo&quot;,&quot;createdAtMs&quot;:1793232000000,&quot;lastMessageAtMs&quot;:1793232060000}}</para>
        /// </summary>
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public object JsonRpcResponse { get; set; }

        /// <summary>
        /// <para>The server-side request ID, which is used to troubleshoot this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A1B2C3D-4E5F-6789-ABCD-EF0123456789</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
