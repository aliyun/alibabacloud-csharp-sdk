// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeScalingGroupInstanceV2ResponseBody : TeaModel {
        [NameInMap("ScalingConfig")]
        [Validation(Required=false)]
        public DescribeScalingGroupInstanceV2ResponseBodyScalingConfig ScalingConfig { get; set; }
        public class DescribeScalingGroupInstanceV2ResponseBodyScalingConfig : TeaModel {
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }
            [NameInMap("DataDiskCount")]
            [Validation(Required=false)]
            public int? DataDiskCount { get; set; }
            [NameInMap("InstanceTypeList")]
            [Validation(Required=false)]
            public DescribeScalingGroupInstanceV2ResponseBodyScalingConfigInstanceTypeList InstanceTypeList { get; set; }
            public class DescribeScalingGroupInstanceV2ResponseBodyScalingConfigInstanceTypeList : TeaModel {
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public List<string> InstanceType { get; set; }

            }
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }
            [NameInMap("SysDiskCategory")]
            [Validation(Required=false)]
            public string SysDiskCategory { get; set; }
            [NameInMap("SpotPriceLimits")]
            [Validation(Required=false)]
            public DescribeScalingGroupInstanceV2ResponseBodyScalingConfigSpotPriceLimits SpotPriceLimits { get; set; }
            public class DescribeScalingGroupInstanceV2ResponseBodyScalingConfigSpotPriceLimits : TeaModel {
                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public List<DescribeScalingGroupInstanceV2ResponseBodyScalingConfigSpotPriceLimitsSpotPriceLimit> SpotPriceLimit { get; set; }
                public class DescribeScalingGroupInstanceV2ResponseBodyScalingConfigSpotPriceLimitsSpotPriceLimit : TeaModel {
                    [NameInMap("PriceLimit")]
                    [Validation(Required=false)]
                    public float? PriceLimit { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                }

            }
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }
            [NameInMap("SysDiskSize")]
            [Validation(Required=false)]
            public int? SysDiskSize { get; set; }
        };

        [NameInMap("ActiveRuleCategory")]
        [Validation(Required=false)]
        public string ActiveRuleCategory { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeoutWithGrace")]
        [Validation(Required=false)]
        public long? TimeoutWithGrace { get; set; }

        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public int? MaxSize { get; set; }

        [NameInMap("MultiAvailablePolicyParam")]
        [Validation(Required=false)]
        public string MultiAvailablePolicyParam { get; set; }

        [NameInMap("MinSize")]
        [Validation(Required=false)]
        public int? MinSize { get; set; }

        [NameInMap("DefaultCooldown")]
        [Validation(Required=false)]
        public int? DefaultCooldown { get; set; }

        [NameInMap("HostGroupId")]
        [Validation(Required=false)]
        public string HostGroupId { get; set; }

        [NameInMap("WithGrace")]
        [Validation(Required=false)]
        public bool? WithGrace { get; set; }

        [NameInMap("MultiAvailablePolicy")]
        [Validation(Required=false)]
        public string MultiAvailablePolicy { get; set; }

        [NameInMap("ScalingRuleList")]
        [Validation(Required=false)]
        public DescribeScalingGroupInstanceV2ResponseBodyScalingRuleList ScalingRuleList { get; set; }
        public class DescribeScalingGroupInstanceV2ResponseBodyScalingRuleList : TeaModel {
            [NameInMap("ScalingRule")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupInstanceV2ResponseBodyScalingRuleListScalingRule> ScalingRule { get; set; }
            public class DescribeScalingGroupInstanceV2ResponseBodyScalingRuleListScalingRule : TeaModel {
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public string EvaluationCount { get; set; }

                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                [NameInMap("MetricDisplayName")]
                [Validation(Required=false)]
                public string MetricDisplayName { get; set; }

                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

            }
        };

    }

}
