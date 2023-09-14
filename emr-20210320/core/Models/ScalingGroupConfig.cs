// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingGroupConfig : TeaModel {
        /// <summary>
        /// 数据盘类型。
        /// </summary>
        [NameInMap("DataDiskCategory")]
        [Validation(Required=false)]
        public string DataDiskCategory { get; set; }

        /// <summary>
        /// 数据盘个数。
        /// </summary>
        [NameInMap("DataDiskCount")]
        [Validation(Required=false)]
        public int? DataDiskCount { get; set; }

        /// <summary>
        /// 数据盘大小,单位GB。
        /// </summary>
        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public long? DataDiskSize { get; set; }

        /// <summary>
        /// 默认冷却时间。
        /// </summary>
        [NameInMap("DefaultCoolDownTime")]
        [Validation(Required=false)]
        public long? DefaultCoolDownTime { get; set; }

        /// <summary>
        /// 抢占实例列表。
        /// </summary>
        [NameInMap("InstanceTypeList")]
        [Validation(Required=false)]
        public List<ScalingGroupConfigInstanceTypeList> InstanceTypeList { get; set; }
        public class ScalingGroupConfigInstanceTypeList : TeaModel {
            /// <summary>
            /// Ecs类型。
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// 抢占价格上限,可空。
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

        }

        /// <summary>
        /// 资源可用性策略(成本优化参数)。
        /// </summary>
        [NameInMap("MultiAvailablePolicy")]
        [Validation(Required=false)]
        public ScalingGroupConfigMultiAvailablePolicy MultiAvailablePolicy { get; set; }
        public class ScalingGroupConfigMultiAvailablePolicy : TeaModel {
            /// <summary>
            /// 资源可用性策略(成本优化参数)。
            /// </summary>
            [NameInMap("PolicyParam")]
            [Validation(Required=false)]
            public ScalingGroupConfigMultiAvailablePolicyPolicyParam PolicyParam { get; set; }
            public class ScalingGroupConfigMultiAvailablePolicyPolicyParam : TeaModel {
                /// <summary>
                /// 按需实例最小个数。
                /// </summary>
                [NameInMap("OnDemandBaseCapacity")]
                [Validation(Required=false)]
                public int? OnDemandBaseCapacity { get; set; }

                /// <summary>
                /// 按需实例百分比。
                /// </summary>
                [NameInMap("OnDemandPercentageAboveBaseCapacity")]
                [Validation(Required=false)]
                public int? OnDemandPercentageAboveBaseCapacity { get; set; }

                /// <summary>
                /// 抢占实例类型池规模。
                /// </summary>
                [NameInMap("SpotInstancePools")]
                [Validation(Required=false)]
                public int? SpotInstancePools { get; set; }

                /// <summary>
                /// 是否使用按量补偿。
                /// </summary>
                [NameInMap("SpotInstanceRemedy")]
                [Validation(Required=false)]
                public bool? SpotInstanceRemedy { get; set; }

            }

            /// <summary>
            /// 策略类型。
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// 节点下线策略。
        /// </summary>
        [NameInMap("NodeOfflinePolicy")]
        [Validation(Required=false)]
        public ScalingGroupConfigNodeOfflinePolicy NodeOfflinePolicy { get; set; }
        public class ScalingGroupConfigNodeOfflinePolicy : TeaModel {
            /// <summary>
            /// 下线模式,是否为优雅下线。
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// 下线超时时间,单位毫秒。
            /// </summary>
            [NameInMap("TimeoutMs")]
            [Validation(Required=false)]
            public long? TimeoutMs { get; set; }

        }

        /// <summary>
        /// 私有池选项	。
        /// </summary>
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public ScalingGroupConfigPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class ScalingGroupConfigPrivatePoolOptions : TeaModel {
            /// <summary>
            /// 私有池id。
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 实例启动的私有池容量选项。。
            /// </summary>
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }

        }

        /// <summary>
        /// 伸缩组节点最大个数。
        /// </summary>
        [NameInMap("ScalingMaxSize")]
        [Validation(Required=false)]
        public int? ScalingMaxSize { get; set; }

        /// <summary>
        /// 伸缩组节点最小个数。
        /// </summary>
        [NameInMap("ScalingMinSize")]
        [Validation(Required=false)]
        public int? ScalingMinSize { get; set; }

        /// <summary>
        /// 抢占式Spot实例策略。
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// 系统盘类型。
        /// </summary>
        [NameInMap("SysDiskCategory")]
        [Validation(Required=false)]
        public string SysDiskCategory { get; set; }

        /// <summary>
        /// 系统盘大小,单位GB。
        /// </summary>
        [NameInMap("SysDiskSize")]
        [Validation(Required=false)]
        public long? SysDiskSize { get; set; }

        /// <summary>
        /// 伸缩活动触发模式。
        /// </summary>
        [NameInMap("TriggerMode")]
        [Validation(Required=false)]
        public string TriggerMode { get; set; }

    }

}
