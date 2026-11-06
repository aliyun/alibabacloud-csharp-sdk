// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class GetAgentSessionModelResponseBody : TeaModel {
        /// <summary>
        /// <para>The defined JSON-RPC response structure. For core nested fields, see the supplementary description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;jsonrpc&quot;:&quot;2.0&quot;,&quot;id&quot;:&quot;request-001&quot;,&quot;result&quot;:{&quot;modelId&quot;:&quot;text-model-example&quot;,&quot;thinkingLevel&quot;:&quot;off&quot;,&quot;thinkingLevels&quot;:[&quot;off&quot;,&quot;low&quot;,&quot;medium&quot;,&quot;high&quot;]}}</para>
        /// </summary>
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public object JsonRpcResponse { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A1B2C3D-4E5F-6789-ABCD-EF0123456789</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
