// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceAutoScalerResponseBody : TeaModel {
        /// <summary>
        /// <para>The additional information about the Autoscaler policy, such as the interval of triggering Autoscaler.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;behavior&quot;: {
        ///     &quot;scaleDown&quot;: {
        ///       &quot;stabilizationWindowSeconds&quot;: 150
        ///     }
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("Behavior")]
        [Validation(Required=false)]
        public Dictionary<string, object> Behavior { get; set; }

        /// <summary>
        /// <para>The metrics.</para>
        /// </summary>
        [NameInMap("CurrentMetrics")]
        [Validation(Required=false)]
        public List<DescribeServiceAutoScalerResponseBodyCurrentMetrics> CurrentMetrics { get; set; }
        public class DescribeServiceAutoScalerResponseBodyCurrentMetrics : TeaModel {
            /// <summary>
            /// <para>The metric name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>QPS</description></item>
            /// <item><description>CPU</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>qps</para>
            /// </summary>
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The service for which the metric is specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo_svc</para>
            /// </summary>
            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// <para>The metric value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public float? Value { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of instances in the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MaxReplica")]
        [Validation(Required=false)]
        public int? MaxReplica { get; set; }

        /// <summary>
        /// <para>The minimum number of instances in the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MinReplica")]
        [Validation(Required=false)]
        public int? MinReplica { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The auto scaling policies.</para>
        /// </summary>
        [NameInMap("ScaleStrategies")]
        [Validation(Required=false)]
        public List<DescribeServiceAutoScalerResponseBodyScaleStrategies> ScaleStrategies { get; set; }
        public class DescribeServiceAutoScalerResponseBodyScaleStrategies : TeaModel {
            /// <summary>
            /// <para>The metric name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>QPS: the queries per second (QPS) for an individual instance.</description></item>
            /// <item><description>CPU: the CPU utilization.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>QPS</para>
            /// </summary>
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The service for which the metric is specified. If you do not set this parameter, the current service is specified by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo_svc</para>
            /// </summary>
            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// <para>The threshold of the metric that triggers auto scaling.</para>
            /// <list type="bullet">
            /// <item><description>If you set metricName to QPS, scale-out is triggered when the average QPS for a single instance is greater than this threshold.</description></item>
            /// <item><description>If you set metricName to CPU, scale-out is triggered when the average CPU utilization for a single instance is greater than this threshold.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

        /// <summary>
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
