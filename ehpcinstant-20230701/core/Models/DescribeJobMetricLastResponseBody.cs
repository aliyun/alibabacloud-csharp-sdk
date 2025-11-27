// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class DescribeJobMetricLastResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the JobMetric details.</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<DescribeJobMetricLastResponseBodyMetrics> Metrics { get; set; }
        public class DescribeJobMetricLastResponseBodyMetrics : TeaModel {
            /// <summary>
            /// <para>The index of the array job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ArrayIndex")]
            [Validation(Required=false)]
            public int? ArrayIndex { get; set; }

            /// <summary>
            /// <para>The monitoring item information corresponding to the array job index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;memory_utilization&quot;: 37.42,&quot;cpu_utilization&quot;: 1.008, &quot;disk_utilization&quot;: 3.562}</para>
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
