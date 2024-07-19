// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceAutoScalerResponseBody : TeaModel {
        /// <summary>
        /// The additional information about the Autoscaler policy, such as the interval of triggering Autoscaler.
        /// </summary>
        [NameInMap("Behavior")]
        [Validation(Required=false)]
        public Dictionary<string, object> Behavior { get; set; }

        /// <summary>
        /// The metrics.
        /// </summary>
        [NameInMap("CurrentMetrics")]
        [Validation(Required=false)]
        public List<DescribeServiceAutoScalerResponseBodyCurrentMetrics> CurrentMetrics { get; set; }
        public class DescribeServiceAutoScalerResponseBodyCurrentMetrics : TeaModel {
            /// <summary>
            /// The metric name. Valid values:
            /// 
            /// *   QPS
            /// *   CPU
            /// </summary>
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The service for which the metric is specified.
            /// </summary>
            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// The metric value.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public float? Value { get; set; }

        }

        /// <summary>
        /// The maximum number of instances in the service.
        /// </summary>
        [NameInMap("MaxReplica")]
        [Validation(Required=false)]
        public int? MaxReplica { get; set; }

        /// <summary>
        /// The minimum number of instances in the service.
        /// </summary>
        [NameInMap("MinReplica")]
        [Validation(Required=false)]
        public int? MinReplica { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The auto scaling policies.
        /// </summary>
        [NameInMap("ScaleStrategies")]
        [Validation(Required=false)]
        public List<DescribeServiceAutoScalerResponseBodyScaleStrategies> ScaleStrategies { get; set; }
        public class DescribeServiceAutoScalerResponseBodyScaleStrategies : TeaModel {
            /// <summary>
            /// The metric name. Valid values:
            /// 
            /// *   QPS: the queries per second (QPS) for an individual instance.
            /// *   CPU: the CPU utilization.
            /// </summary>
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The service for which the metric is specified. If you do not set this parameter, the current service is specified by default.
            /// </summary>
            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// The threshold of the metric that triggers auto scaling.
            /// 
            /// *   If you set metricName to QPS, scale-out is triggered when the average QPS for a single instance is greater than this threshold.
            /// *   If you set metricName to CPU, scale-out is triggered when the average CPU utilization for a single instance is greater than this threshold.
            /// </summary>
            [NameInMap("threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

        /// <summary>
        /// The service name.
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
