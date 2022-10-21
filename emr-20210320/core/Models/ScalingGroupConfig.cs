// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingGroupConfig : TeaModel {
        [NameInMap("DataDiskCategory")]
        [Validation(Required=false)]
        public string DataDiskCategory { get; set; }

        [NameInMap("DataDiskCount")]
        [Validation(Required=false)]
        public int? DataDiskCount { get; set; }

        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public long? DataDiskSize { get; set; }

        [NameInMap("DefaultCoolDownTime")]
        [Validation(Required=false)]
        public long? DefaultCoolDownTime { get; set; }

        [NameInMap("InstanceTypeList")]
        [Validation(Required=false)]
        public List<ScalingGroupConfigInstanceTypeList> InstanceTypeList { get; set; }
        public class ScalingGroupConfigInstanceTypeList : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

        }

        [NameInMap("MultiAvailablePolicy")]
        [Validation(Required=false)]
        public ScalingGroupConfigMultiAvailablePolicy MultiAvailablePolicy { get; set; }
        public class ScalingGroupConfigMultiAvailablePolicy : TeaModel {
            [NameInMap("PolicyParam")]
            [Validation(Required=false)]
            public ScalingGroupConfigMultiAvailablePolicyPolicyParam PolicyParam { get; set; }
            public class ScalingGroupConfigMultiAvailablePolicyPolicyParam : TeaModel {
                [NameInMap("OnDemandBaseCapacity")]
                [Validation(Required=false)]
                public int? OnDemandBaseCapacity { get; set; }

                [NameInMap("OnDemandPercentageAboveBaseCapacity")]
                [Validation(Required=false)]
                public int? OnDemandPercentageAboveBaseCapacity { get; set; }

                [NameInMap("SpotInstancePools")]
                [Validation(Required=false)]
                public int? SpotInstancePools { get; set; }

                [NameInMap("SpotInstanceRemedy")]
                [Validation(Required=false)]
                public bool? SpotInstanceRemedy { get; set; }

            }

            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        [NameInMap("NodeOfflinePolicy")]
        [Validation(Required=false)]
        public ScalingGroupConfigNodeOfflinePolicy NodeOfflinePolicy { get; set; }
        public class ScalingGroupConfigNodeOfflinePolicy : TeaModel {
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("TimeoutMs")]
            [Validation(Required=false)]
            public long? TimeoutMs { get; set; }

        }

        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public ScalingGroupConfigPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class ScalingGroupConfigPrivatePoolOptions : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }

        }

        [NameInMap("ScalingMaxSize")]
        [Validation(Required=false)]
        public int? ScalingMaxSize { get; set; }

        [NameInMap("ScalingMinSize")]
        [Validation(Required=false)]
        public int? ScalingMinSize { get; set; }

        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        [NameInMap("SysDiskCategory")]
        [Validation(Required=false)]
        public string SysDiskCategory { get; set; }

        [NameInMap("SysDiskSize")]
        [Validation(Required=false)]
        public long? SysDiskSize { get; set; }

        [NameInMap("TriggerMode")]
        [Validation(Required=false)]
        public string TriggerMode { get; set; }

    }

}
