// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceAutoScalerRequest : TeaModel {
        /// <summary>
        /// The Autoscaler operation.
        /// </summary>
        [NameInMap("behavior")]
        [Validation(Required=false)]
        public CreateServiceAutoScalerRequestBehavior Behavior { get; set; }
        public class CreateServiceAutoScalerRequestBehavior : TeaModel {
            /// <summary>
            /// The operation that reduces the number of instances to 0.
            /// </summary>
            [NameInMap("onZero")]
            [Validation(Required=false)]
            public CreateServiceAutoScalerRequestBehaviorOnZero OnZero { get; set; }
            public class CreateServiceAutoScalerRequestBehaviorOnZero : TeaModel {
                /// <summary>
                /// The time window that is required before the number of instances is reduced to 0. The number of instances can be reduced to 0 only if no request is available or no traffic exists in the specified time window. Default value: 600.
                /// </summary>
                [NameInMap("scaleDownGracePeriodSeconds")]
                [Validation(Required=false)]
                public int? ScaleDownGracePeriodSeconds { get; set; }

                /// <summary>
                /// The number of instances that you want to create at a time if the number of instances is 0. Default value: 1.
                /// </summary>
                [NameInMap("scaleUpActivationReplicas")]
                [Validation(Required=false)]
                public int? ScaleUpActivationReplicas { get; set; }

            }

            /// <summary>
            /// The scale-in operation.
            /// </summary>
            [NameInMap("scaleDown")]
            [Validation(Required=false)]
            public CreateServiceAutoScalerRequestBehaviorScaleDown ScaleDown { get; set; }
            public class CreateServiceAutoScalerRequestBehaviorScaleDown : TeaModel {
                /// <summary>
                /// The time window that is required before the scale-in operation is performed. The scale-in operation can be performed only if the specified metric drops below the specified threshold in the specified time window. Default value: 300.
                /// </summary>
                [NameInMap("stabilizationWindowSeconds")]
                [Validation(Required=false)]
                public int? StabilizationWindowSeconds { get; set; }

            }

            /// <summary>
            /// The scale-out operation.
            /// </summary>
            [NameInMap("scaleUp")]
            [Validation(Required=false)]
            public CreateServiceAutoScalerRequestBehaviorScaleUp ScaleUp { get; set; }
            public class CreateServiceAutoScalerRequestBehaviorScaleUp : TeaModel {
                /// <summary>
                /// The time window that is required before the scale-out operation is performed. The scale-out operation can be performed only if the specified metric exceeds the specified threshold in the specified time window. Default value: 0.
                /// </summary>
                [NameInMap("stabilizationWindowSeconds")]
                [Validation(Required=false)]
                public int? StabilizationWindowSeconds { get; set; }

            }

        }

        /// <summary>
        /// The maximum number of instances in the service. The value of max must be greater than the value of min.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("max")]
        [Validation(Required=false)]
        public int? Max { get; set; }

        /// <summary>
        /// The minimum number of instances in the service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("min")]
        [Validation(Required=false)]
        public int? Min { get; set; }

        /// <summary>
        /// The service for which the metric is specified. If you do not set this parameter, the current service is specified by default.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("scaleStrategies")]
        [Validation(Required=false)]
        public List<CreateServiceAutoScalerRequestScaleStrategies> ScaleStrategies { get; set; }
        public class CreateServiceAutoScalerRequestScaleStrategies : TeaModel {
            /// <summary>
            /// The name of the metric for triggering auto scaling. Valid values:
            /// 
            /// *   qps: the queries per second (qps) for an individual instance.
            /// *   cpu: the cpu utilization.
            /// * gpu[util]: gpu utilization.
            /// 
            /// This parameter is required.
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
            /// *   If you set metricName to qps, scale-out is triggered when the average qps for a single instance is greater than this threshold.
            /// *   If you set metricName to cpu, scale-out is triggered when the average cpu utilization for a single instance is greater than this threshold.
            /// *   If you set metricName to gpu, scale-out is triggered when the average cpu utilization for a single instance is greater than this threshold.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

    }

}
