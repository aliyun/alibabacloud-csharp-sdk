// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class CreateAgentSessionRequest : TeaModel {
        /// <summary>
        /// <para>The correlation identifier for this call. It is echoed in the response and does not provide idempotence guarantees.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC protocol version. Set the value to <c>2.0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The business parameter object. For nested fields, see the supplementary description of request parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;clientToken&quot;:&quot;create-review-001&quot;,&quot;_meta&quot;:{&quot;agent&quot;:{&quot;agentName&quot;:&quot;review-agent-demo&quot;},&quot;initialConfigOptions&quot;:{&quot;approvalMode&quot;:&quot;default&quot;}}}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public object Params { get; set; }

    }

}
