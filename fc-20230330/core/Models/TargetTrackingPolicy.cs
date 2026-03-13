// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class TargetTrackingPolicy : TeaModel {
        /// <summary>
        /// <para>The end time of the policy, in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-10T10:10:10Z</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The maximum number of provisioned instances for scale-out.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxCapacity")]
        [Validation(Required=false)]
        public long? MaxCapacity { get; set; }

        /// <summary>
        /// <para>The threshold value for metric-based auto scaling.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.6</para>
        /// </summary>
        [NameInMap("metricTarget")]
        [Validation(Required=false)]
        public float? MetricTarget { get; set; }

        /// <summary>
        /// <para>The metric type for tracing. ProvisionedConcurrencyUtilization: the concurrency utilization of provisioned instances. CPUUtilization: the CPU utilization. GPUMemUtilization: the GPU utilization.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPUUtilization</para>
        /// </summary>
        [NameInMap("metricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The minimum number of provisioned instances for scale-in.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("minCapacity")]
        [Validation(Required=false)]
        public long? MinCapacity { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The time when the policy starts to take effect, in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-10T10:10:10Z</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The time zone. If the time zone parameter is empty, the time of startTime and endTime must be in UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
