// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QuerySensNodeInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned business data in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;success&quot;: true, &quot;httpStatusCode&quot;: 200, &quot;data&quot;: { &quot;result&quot;: [ { &quot;sensitiveName&quot;: &quot;certificate expiration date&quot;, &quot;sensitiveId&quot;: &quot;fd4ff5a2-9537-43d1-8e4f-1d0b5ffaac12&quot;, &quot;status&quot;: 0, &quot;templateName&quot;: &quot;built-in classification and grading template&quot;, &quot;keyRuleId&quot;: &quot;228248921215042 certificate expiration date&quot;} ], &quot;totalCount&quot;: 1, &quot;currentPage&quot;: 1, &quot;pageSize&quot;: 10 }, &quot;requestId&quot;: 10000001}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9990030003</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Missing parameter</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
