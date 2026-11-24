// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingRulesRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number of the scaling rule list. Pages start from 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The Settings for the number of entries per page during a paged query. Maximum value: 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group to which the scaling rules belong.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1ffogfdauy0jw0****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The unique identifiers of the scaling rules to be queried.</para>
        /// </summary>
        [NameInMap("ScalingRuleAris")]
        [Validation(Required=false)]
        public List<string> ScalingRuleAris { get; set; }

        /// <summary>
        /// <para>The IDs of the scaling rules to be queried.</para>
        /// </summary>
        [NameInMap("ScalingRuleIds")]
        [Validation(Required=false)]
        public List<string> ScalingRuleIds { get; set; }

        /// <summary>
        /// <para>The names of the scaling rules to be queried.</para>
        /// </summary>
        [NameInMap("ScalingRuleNames")]
        [Validation(Required=false)]
        public List<string> ScalingRuleNames { get; set; }

        /// <summary>
        /// <para>The type of the scaling rule. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>SimpleScalingRule: simple scaling rule. Adjusts the number of ECS instances based on the adjustment type (AdjustmentType) and adjustment value (AdjustmentValue).</description></item>
        /// <item><description>TargetTrackingScalingRule: target tracking scaling rule. Dynamically calculates the number of ECS instances to scale out or scale-in based on a predefined metric (MetricName) and attempts to maintain the metric value near the target value (TargetValue).</description></item>
        /// <item><description>StepScalingRule: step scaling rule. Provides a step-by-step extension method based on thresholds and metric values.</description></item>
        /// <item><description>PredictiveScalingRule: predictive scaling rule. Analyzes the historical monitoring data of the scaling group based on machine learning capabilities to predict future monitoring metrics, and supports the automatic creation of scheduled tasks to set the boundaries of the scaling group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SimpleScalingRule</para>
        /// </summary>
        [NameInMap("ScalingRuleType")]
        [Validation(Required=false)]
        public string ScalingRuleType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the CloudMonitor event-triggered tasks associated with the scaling rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: returns the CloudMonitor event-triggered tasks associated with the scaling rules.</description></item>
        /// <item><description>false: does not return the CloudMonitor event-triggered tasks associated with the scaling rules.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowAlarmRules")]
        [Validation(Required=false)]
        public bool? ShowAlarmRules { get; set; }

    }

}
