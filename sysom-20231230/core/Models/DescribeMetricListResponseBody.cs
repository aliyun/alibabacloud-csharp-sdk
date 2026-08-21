// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class DescribeMetricListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates that the authorization is successful.</description></item>
        /// <item><description>Other status codes indicate that the authorization failed. Check the <c>message</c> field for the detailed fault information.</description></item>
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
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<DescribeMetricListResponseBodyData> Data { get; set; }
        public class DescribeMetricListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The metric labels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;taskExecName\&quot;: \&quot;build-and-deploy\&quot;, \&quot;pipelineName\&quot;: \&quot;pipeline-run-1722909642357\&quot;}</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public string Labels { get; set; }

            /// <summary>
            /// <para>The metric name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sysom_cpu_usage_idle</para>
            /// </summary>
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The metric data.</para>
            /// </summary>
            [NameInMap("values")]
            [Validation(Required=false)]
            public List<List<string>> Values { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.</description></item>
        /// <item><description>Otherwise, this field contains the request error information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Analysis ID: 56dae746-ef55-4f77-8373-cb3594c41457
        /// Analysis failed for machine i-bp164ns76pzirbwv0snt. Failure reason: Not get GPU trace data for \&quot;56dae746-ef55-4f77-8373-cb3594c41457\&quot; \&quot;[\&quot;93811\&quot;]\&quot;!</para>
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
