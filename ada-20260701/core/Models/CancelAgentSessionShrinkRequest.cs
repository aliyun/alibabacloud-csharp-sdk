// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class CancelAgentSessionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The correlation identifier for this call, which is echoed in the response. This parameter does not provide idempotence guarantees.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC protocol version. Set this parameter to 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The business parameter object. For nested fields, refer to the supplementary description of request parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sessionId&quot;:&quot;0123456789abcdef0123456789abcdef&quot;,&quot;_meta&quot;:{&quot;promptId&quot;:&quot;prompt-example-001&quot;}}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string ParamsShrink { get; set; }

    }

}
