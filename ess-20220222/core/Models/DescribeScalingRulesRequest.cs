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
        /// <para>The number of the page to return. Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group to which the scaling rules that you want to query belong.</para>
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
        /// <para>The unique identifiers of the scaling rules that you want to query.</para>
        /// </summary>
        [NameInMap("ScalingRuleAris")]
        [Validation(Required=false)]
        public List<string> ScalingRuleAris { get; set; }

        /// <summary>
        /// <para>The IDs of the scaling rules that you want to query.</para>
        /// </summary>
        [NameInMap("ScalingRuleIds")]
        [Validation(Required=false)]
        public List<string> ScalingRuleIds { get; set; }

        /// <summary>
        /// <para>The names of the scaling rules that you want to query.</para>
        /// </summary>
        [NameInMap("ScalingRuleNames")]
        [Validation(Required=false)]
        public List<string> ScalingRuleNames { get; set; }

        /// <summary>
        /// <para>The type of the scaling rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SimpleScalingRule: adjusts the number of ECS instances based on the values of the AdjustmentType and AdjustmentValue parameters.</description></item>
        /// <item><description>TargetTrackingScalingRule: calculates the number of ECS instances that need to be scaled in a dynamic manner and maintains the value of a predefined metric close to the value of the TargetValue parameter.</description></item>
        /// <item><description>StepScalingRule: scales ECS instances in steps based on the specified thresholds and metric values.</description></item>
        /// <item><description>PredictiveScalingRule: uses machine learning to analyze historical monitoring data of the scaling group and predicts the future values of metrics. In addition, Auto Scaling automatically creates scheduled tasks to adjust the boundary values for the scaling group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SimpleScalingRule</para>
        /// </summary>
        [NameInMap("ScalingRuleType")]
        [Validation(Required=false)]
        public string ScalingRuleType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return CloudMonitor event-triggered tasks associated with scaling rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
