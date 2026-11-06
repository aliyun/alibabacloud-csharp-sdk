// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class SetAgentSessionModelRequest : TeaModel {
        /// <summary>
        /// <para>The client request identifier, which is echoed in the response. It is used to associate this call and does not have idempotent semantics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC version. Set this parameter to <c>2.0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The defined business parameter structure. For core nested fields, see the supplementary description.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sessionId&quot;:&quot;0123456789abcdef0123456789abcdef&quot;,&quot;modelId&quot;:&quot;text-model-example&quot;}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public object Params { get; set; }

    }

}
