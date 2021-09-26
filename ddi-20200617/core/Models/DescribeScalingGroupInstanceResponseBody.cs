// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class DescribeScalingGroupInstanceResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HostGroupId")]
        [Validation(Required=false)]
        public string HostGroupId { get; set; }

        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        [NameInMap("MinSize")]
        [Validation(Required=false)]
        public long? MinSize { get; set; }

        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public long? MaxSize { get; set; }

        [NameInMap("DefaultCooldown")]
        [Validation(Required=false)]
        public long? DefaultCooldown { get; set; }

        [NameInMap("ActiveRuleCategory")]
        [Validation(Required=false)]
        public string ActiveRuleCategory { get; set; }

        [NameInMap("WithGrace")]
        [Validation(Required=false)]
        public bool? WithGrace { get; set; }

        [NameInMap("TimeoutWithGrace")]
        [Validation(Required=false)]
        public long? TimeoutWithGrace { get; set; }

        [NameInMap("MultiAvailablePolicy")]
        [Validation(Required=false)]
        public string MultiAvailablePolicy { get; set; }

        [NameInMap("MultiAvailablePolicyParam")]
        [Validation(Required=false)]
        public string MultiAvailablePolicyParam { get; set; }

        [NameInMap("ScalingConfig")]
        [Validation(Required=false)]
        public DescribeScalingGroupInstanceResponseBodyScalingConfig ScalingConfig { get; set; }
        public class DescribeScalingGroupInstanceResponseBodyScalingConfig : TeaModel {
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public long? DataDiskSize { get; set; }
            [NameInMap("DataDiskCount")]
            [Validation(Required=false)]
            public long? DataDiskCount { get; set; }
            [NameInMap("SysDiskCategory")]
            [Validation(Required=false)]
            public string SysDiskCategory { get; set; }
            [NameInMap("SysDiskSize")]
            [Validation(Required=false)]
            public long? SysDiskSize { get; set; }
            [NameInMap("InstanceTypeList")]
            [Validation(Required=false)]
            public DescribeScalingGroupInstanceResponseBodyScalingConfigInstanceTypeList InstanceTypeList { get; set; }
            public class DescribeScalingGroupInstanceResponseBodyScalingConfigInstanceTypeList : TeaModel {
                [NameInMap("instanceTypeList")]
                [Validation(Required=false)]
                public List<string> InstanceTypeList { get; set; }

            }
            [NameInMap("SpotPriceLimits")]
            [Validation(Required=false)]
            public DescribeScalingGroupInstanceResponseBodyScalingConfigSpotPriceLimits SpotPriceLimits { get; set; }
            public class DescribeScalingGroupInstanceResponseBodyScalingConfigSpotPriceLimits : TeaModel {
                [NameInMap("spotPriceLimits")]
                [Validation(Required=false)]
                public List<DescribeScalingGroupInstanceResponseBodyScalingConfigSpotPriceLimitsSpotPriceLimits> SpotPriceLimits { get; set; }
                public class DescribeScalingGroupInstanceResponseBodyScalingConfigSpotPriceLimitsSpotPriceLimits : TeaModel {
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("PriceLimit")]
                    [Validation(Required=false)]
                    public float? PriceLimit { get; set; }

                }

            }
        };

        [NameInMap("ScalingRuleList")]
        [Validation(Required=false)]
        public DescribeScalingGroupInstanceResponseBodyScalingRuleList ScalingRuleList { get; set; }
        public class DescribeScalingGroupInstanceResponseBodyScalingRuleList : TeaModel {
            [NameInMap("ScalingRule")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupInstanceResponseBodyScalingRuleListScalingRule> ScalingRule { get; set; }
            public class DescribeScalingGroupInstanceResponseBodyScalingRuleListScalingRule : TeaModel {
                public string RuleCategory { get; set; }
                public string EssScalingRuleId { get; set; }
                public long? ScalingGroupId { get; set; }
                public string RuleName { get; set; }
                public string AdjustmentType { get; set; }
                public long? AdjustmentValue { get; set; }
                public long? Cooldown { get; set; }
                public string Status { get; set; }
                public string LaunchTime { get; set; }
                public long? LaunchExpirationTime { get; set; }
                public string RecurrenceType { get; set; }
                public string RecurrenceValue { get; set; }
                public string RecurrenceEndTime { get; set; }
                public bool? WithGrace { get; set; }
                public long? TimeoutWithGrace { get; set; }
                public DescribeScalingGroupInstanceResponseBodyScalingRuleListScalingRuleSchedulerTrigger SchedulerTrigger { get; set; }
                public class DescribeScalingGroupInstanceResponseBodyScalingRuleListScalingRuleSchedulerTrigger : TeaModel {
                    [NameInMap("LaunchTime")]
                    [Validation(Required=false)]
                    public long? LaunchTime { get; set; }

                    [NameInMap("LaunchExpirationTime")]
                    [Validation(Required=false)]
                    public long? LaunchExpirationTime { get; set; }

                    [NameInMap("RecurrenceType")]
                    [Validation(Required=false)]
                    public string RecurrenceType { get; set; }

                    [NameInMap("RecurrenceValue")]
                    [Validation(Required=false)]
                    public string RecurrenceValue { get; set; }

                    [NameInMap("RecurrenceEndTime")]
                    [Validation(Required=false)]
                    public long? RecurrenceEndTime { get; set; }

                }
                public DescribeScalingGroupInstanceResponseBodyScalingRuleListScalingRuleCloudWatchTrigger CloudWatchTrigger { get; set; }
                public class DescribeScalingGroupInstanceResponseBodyScalingRuleListScalingRuleCloudWatchTrigger : TeaModel {
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    [NameInMap("Period")]
                    [Validation(Required=false)]
                    public long? Period { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("EvaluationCount")]
                    [Validation(Required=false)]
                    public string EvaluationCount { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("MetricDisplayName")]
                    [Validation(Required=false)]
                    public string MetricDisplayName { get; set; }

                }
            }
        };

    }

}
