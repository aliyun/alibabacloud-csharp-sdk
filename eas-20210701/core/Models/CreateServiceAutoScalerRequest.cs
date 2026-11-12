// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceAutoScalerRequest : TeaModel {
        /// <summary>
        /// <para>The behavior during auto-scaling.</para>
        /// </summary>
        [NameInMap("behavior")]
        [Validation(Required=false)]
        public CreateServiceAutoScalerRequestBehavior Behavior { get; set; }
        public class CreateServiceAutoScalerRequestBehavior : TeaModel {
            /// <summary>
            /// <para>The behavior when scaling in to zero.</para>
            /// </summary>
            [NameInMap("onZero")]
            [Validation(Required=false)]
            public CreateServiceAutoScalerRequestBehaviorOnZero OnZero { get; set; }
            public class CreateServiceAutoScalerRequestBehaviorOnZero : TeaModel {
                /// <summary>
                /// <para>The grace period before scaling in to zero. When the metrics meet the conditions for scaling in to zero, the scale-in to zero is executed after the grace period elapses. Default value: 600.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("scaleDownGracePeriodSeconds")]
                [Validation(Required=false)]
                public int? ScaleDownGracePeriodSeconds { get; set; }

                /// <summary>
                /// <para>The number of instances created at a time when scaling out from zero. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("scaleUpActivationReplicas")]
                [Validation(Required=false)]
                public int? ScaleUpActivationReplicas { get; set; }

            }

            /// <summary>
            /// <para>The behavior during scale-in.</para>
            /// </summary>
            [NameInMap("scaleDown")]
            [Validation(Required=false)]
            public CreateServiceAutoScalerRequestBehaviorScaleDown ScaleDown { get; set; }
            public class CreateServiceAutoScalerRequestBehaviorScaleDown : TeaModel {
                /// <summary>
                /// <para>The stabilization window period for scale-in. Default value: 300. Scale-in is executed only when the metrics do not meet the specified conditions over the past period of time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("stabilizationWindowSeconds")]
                [Validation(Required=false)]
                public int? StabilizationWindowSeconds { get; set; }

            }

            /// <summary>
            /// <para>The behavior during scale-out.</para>
            /// </summary>
            [NameInMap("scaleUp")]
            [Validation(Required=false)]
            public CreateServiceAutoScalerRequestBehaviorScaleUp ScaleUp { get; set; }
            public class CreateServiceAutoScalerRequestBehaviorScaleUp : TeaModel {
                /// <summary>
                /// <para>The stabilization window period for scale-out. Default value: 0. Scale-out is executed only when the metrics meet the specified conditions over the past period of time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("stabilizationWindowSeconds")]
                [Validation(Required=false)]
                public int? StabilizationWindowSeconds { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum number of instances. The value must be greater than the minimum number of instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("max")]
        [Validation(Required=false)]
        public int? Max { get; set; }

        /// <summary>
        /// <para>The minimum number of instances. The value must be greater than 0.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("min")]
        [Validation(Required=false)]
        public int? Min { get; set; }

        /// <summary>
        /// <para>The list of scaling policies.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("scaleStrategies")]
        [Validation(Required=false)]
        public List<CreateServiceAutoScalerRequestScaleStrategies> ScaleStrategies { get; set; }
        public class CreateServiceAutoScalerRequestScaleStrategies : TeaModel {
            /// <summary>
            /// <para>The name of the metric. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>qps: the queries per second (QPS) threshold per instance</description></item>
            /// <item><description>cpu: the CPU utilization threshold</description></item>
            /// <item><description>gpu[util]: the GPU utilization threshold</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qps</para>
            /// </summary>
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The service to which the metric belongs. If this parameter is not specified, the current service is used by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo_svc</para>
            /// </summary>
            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// <para>The threshold that triggers auto-scaling.</para>
            /// <list type="bullet">
            /// <item><description>If the metric name is set to qps, scale-out is triggered when the average QPS per instance exceeds this value.</description></item>
            /// <item><description>If the metric name is set to cpu, scale-out is triggered when the average CPU utilization per instance exceeds this value.</description></item>
            /// <item><description>If the metric name is set to gpu[util], scale-out is triggered when the average GPU utilization per instance exceeds this value.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

    }

}
