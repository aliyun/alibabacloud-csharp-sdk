// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class DescribeMetricListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<DescribeMetricListResponseBodyData> Data { get; set; }
        public class DescribeMetricListResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;taskExecName\&quot;: \&quot;build-and-deploy\&quot;, \&quot;pipelineName\&quot;: \&quot;pipeline-run-1722909642357\&quot;}</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public string Labels { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sysom_cpu_usage_idle</para>
            /// </summary>
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("values")]
            [Validation(Required=false)]
            public List<List<string>> Values { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>分析ID: 56dae746-ef55-4f77-8373-cb3594c41457
        /// 机器i-bp164ns76pzirbwv0snt分析失败, 失败原因: Not get GPU trace data for &quot;56dae746-ef55-4f77-8373-cb3594c41457&quot; &quot;[&quot;93811&quot;]&quot;!</para>
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
