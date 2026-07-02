// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CreateAlertStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, the request is successful.</description></item>
        /// <item><description>Other status codes indicate a failed request. If the request fails, check the <c>message</c> field for detailed error information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///             &quot;uid&quot;: &quot;uid-1&quot;,
        ///             &quot;name&quot;: &quot;test-name&quot;,
        ///             &quot;strategy&quot;: {
        ///                 &quot;clusters&quot;: [&quot;test-cluster-1&quot;,&quot;test-cluster-2&quot;],
        ///                 &quot;items&quot;: [&quot;test-item1&quot;,&quot;test-item2&quot;]
        ///             },
        ///             &quot;enabled&quot;: True,</para>
        /// <pre><c>    }
        /// </c></pre>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.</description></item>
        /// <item><description>Otherwise, this field contains the error information of the request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>创建策略失败</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
