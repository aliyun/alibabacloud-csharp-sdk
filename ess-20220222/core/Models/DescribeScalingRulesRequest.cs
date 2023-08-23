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
        /// The number of the page to return. Pages start from page 1.
        /// 
        /// Default value: 1
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 50.
        /// 
        /// Default value: 10
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1.
        /// 
        /// Default value: 1.
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
        /// The type of the scaling rule. Valid values:
        /// 
        /// *   SimpleScalingRule: adjusts the number of ECS instances based on the values of the AdjustmentType and AdjustmentValue parameters.
        /// *   TargetTrackingScalingRule: calculates the number of ECS instances that need to be scaled in a dynamic manner and maintains the value of a predefined metric close to the value of the TargetValue parameter.
        /// *   StepScalingRule: scales ECS instances in steps based on the specified thresholds and metric values.
        /// *   PredictiveScalingRule: uses machine learning to analyze historical monitoring data of the scaling group and predicts the future values of metrics. In addition, Auto Scaling automatically creates scheduled tasks to adjust the boundary values for the scaling group.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// The unique identifiers of the scaling rules that you want to query.
        /// </summary>
        [NameInMap("ScalingRuleAris")]
        [Validation(Required=false)]
        public List<string> ScalingRuleAris { get; set; }

        /// <summary>
        /// The IDs of the scaling rules that you want to query.
        /// </summary>
        [NameInMap("ScalingRuleIds")]
        [Validation(Required=false)]
        public List<string> ScalingRuleIds { get; set; }

        /// <summary>
        /// The names of the scaling rules that you want to query.
        /// </summary>
        [NameInMap("ScalingRuleNames")]
        [Validation(Required=false)]
        public List<string> ScalingRuleNames { get; set; }

        /// <summary>
        /// Specifies whether to return CloudMonitor event-triggered tasks associated with scaling rules. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ScalingRuleType")]
        [Validation(Required=false)]
        public string ScalingRuleType { get; set; }

        /// <summary>
        /// Specifies whether to return the event-triggered tasks that are associated with the scaling rules. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("ShowAlarmRules")]
        [Validation(Required=false)]
        public bool? ShowAlarmRules { get; set; }

    }

}
