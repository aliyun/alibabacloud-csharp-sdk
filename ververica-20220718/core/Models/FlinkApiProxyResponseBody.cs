// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class FlinkApiProxyResponseBody : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>If the value of success was true, the result of the proxy request was returned.</description></item>
        /// <item><description>If the value of success was false, a null value was returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;jobs&quot;: [ { &quot;jid&quot;: &quot;4df35f8e54554b23bf7dcd38a151****&quot;, &quot;name&quot;: &quot;69d001d5-419a-4bfc-9c2e-849cacd3****&quot;, &quot;state&quot;: &quot;RUNNING&quot;, &quot;start-time&quot;: 1659154942068, &quot;end-time&quot;: -1, &quot;duration&quot;: 188161756, &quot;last-modification&quot;: 1659154968305, &quot;tasks&quot;: { &quot;total&quot;: 2, &quot;created&quot;: 0, &quot;scheduled&quot;: 0, &quot;deploying&quot;: 0, &quot;running&quot;: 2, &quot;finished&quot;: 0, &quot;canceling&quot;: 0, &quot;canceled&quot;: 0, &quot;failed&quot;: 0, &quot;reconciling&quot;: 0, &quot;initializing&quot;: 0 } } ] }</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If the value of success was false, an error code was returned.</description></item>
        /// <item><description>If the value of success was true, a null value was returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If the value of success was false, an error message was returned.</description></item>
        /// <item><description>If the value of success was true, a null value was returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The value was fixed to 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBC799F0-AS7S-1D30-8A4F-882ED4DD****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
