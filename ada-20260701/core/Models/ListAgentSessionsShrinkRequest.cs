// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class ListAgentSessionsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The correlation identifier for this call. It is echoed in the response and does not provide idempotency guarantees.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC protocol version. Set this parameter to <c>2.0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The business parameter object. The public fields are only AgentName, MaxResults, and NextToken.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AgentName&quot;:&quot;review-agent-demo&quot;,&quot;MaxResults&quot;:20}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string ParamsShrink { get; set; }

    }

}
