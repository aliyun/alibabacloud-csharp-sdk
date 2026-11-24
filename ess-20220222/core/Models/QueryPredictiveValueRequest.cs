// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class QueryPredictiveValueRequest : TeaModel {
        /// <summary>
        /// <para>The end time to query the predicted number of instances in the scaling group. The time must be in UTC and follow the ISO 8601 standard.</para>
        /// <para>Format: yyyy-MM-ddTHH:mmZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-18T08:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the monitoring metrics for the predictive scaling rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CpuUtilization: the average CPU utilization of ECS instances.</description></item>
        /// <item><description>IntranetRx: the average inbound internal network traffic of ECS instances.</description></item>
        /// <item><description>IntranetTx: the average outbound internal network traffic of ECS instances.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CpuUtilization</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-2zee0wsy0zkdxxxxx</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The start time to query the predicted number of instances in the scaling group. The time must be in UTC and follow the ISO 8601 standard.</para>
        /// <para>Format: yyyy-MM-ddTHH:mmZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-17T08:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The current value of the monitoring metrics for the predictive scaling rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public float? TargetValue { get; set; }

    }

}
