// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingGroupConfig : TeaModel {
        /// <summary>
        /// <para>数据盘类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DataDiskCategory")]
        [Validation(Required=false)]
        public string DataDiskCategory { get; set; }

        /// <summary>
        /// <para>数据盘个数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("DataDiskCount")]
        [Validation(Required=false)]
        public int? DataDiskCount { get; set; }

        /// <summary>
        /// <para>数据盘大小,单位GB。</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public long? DataDiskSize { get; set; }

        /// <summary>
        /// <para>默认冷却时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DefaultCoolDownTime")]
        [Validation(Required=false)]
        public long? DefaultCoolDownTime { get; set; }

        /// <summary>
        /// <para>抢占实例列表。</para>
        /// </summary>
        [NameInMap("InstanceTypeList")]
        [Validation(Required=false)]
        public List<ScalingGroupConfigInstanceTypeList> InstanceTypeList { get; set; }
        public class ScalingGroupConfigInstanceTypeList : TeaModel {
            /// <summary>
            /// <para>Ecs类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>抢占价格上限,可空。</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.79</para>
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

        }

        /// <summary>
        /// <para>资源可用性策略(成本优化参数)。</para>
        /// </summary>
        [NameInMap("MultiAvailablePolicy")]
        [Validation(Required=false)]
        public ScalingGroupConfigMultiAvailablePolicy MultiAvailablePolicy { get; set; }
        public class ScalingGroupConfigMultiAvailablePolicy : TeaModel {
            /// <summary>
            /// <para>资源可用性策略(成本优化参数)。</para>
            /// </summary>
            [NameInMap("PolicyParam")]
            [Validation(Required=false)]
            public ScalingGroupConfigMultiAvailablePolicyPolicyParam PolicyParam { get; set; }
            public class ScalingGroupConfigMultiAvailablePolicyPolicyParam : TeaModel {
                /// <summary>
                /// <para>按需实例最小个数。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OnDemandBaseCapacity")]
                [Validation(Required=false)]
                public int? OnDemandBaseCapacity { get; set; }

                /// <summary>
                /// <para>按需实例百分比。</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("OnDemandPercentageAboveBaseCapacity")]
                [Validation(Required=false)]
                public int? OnDemandPercentageAboveBaseCapacity { get; set; }

                /// <summary>
                /// <para>抢占实例类型池规模。</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("SpotInstancePools")]
                [Validation(Required=false)]
                public int? SpotInstancePools { get; set; }

                /// <summary>
                /// <para>是否使用按量补偿。</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SpotInstanceRemedy")]
                [Validation(Required=false)]
                public bool? SpotInstanceRemedy { get; set; }

            }

            /// <summary>
            /// <para>策略类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIORITY</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>节点下线策略。</para>
        /// </summary>
        [NameInMap("NodeOfflinePolicy")]
        [Validation(Required=false)]
        public ScalingGroupConfigNodeOfflinePolicy NodeOfflinePolicy { get; set; }
        public class ScalingGroupConfigNodeOfflinePolicy : TeaModel {
            /// <summary>
            /// <para>下线模式,是否为优雅下线。</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>下线超时时间,单位毫秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("TimeoutMs")]
            [Validation(Required=false)]
            public long? TimeoutMs { get; set; }

        }

        /// <summary>
        /// <para>私有池选项	。</para>
        /// </summary>
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public ScalingGroupConfigPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class ScalingGroupConfigPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>私有池id。</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>实例启动的私有池容量选项。。</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }

        }

        /// <summary>
        /// <para>伸缩组节点最大个数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ScalingMaxSize")]
        [Validation(Required=false)]
        public int? ScalingMaxSize { get; set; }

        /// <summary>
        /// <para>伸缩组节点最小个数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScalingMinSize")]
        [Validation(Required=false)]
        public int? ScalingMinSize { get; set; }

        /// <summary>
        /// <para>抢占式Spot实例策略。</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>系统盘类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("SysDiskCategory")]
        [Validation(Required=false)]
        public string SysDiskCategory { get; set; }

        /// <summary>
        /// <para>系统盘大小,单位GB。</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("SysDiskSize")]
        [Validation(Required=false)]
        public long? SysDiskSize { get; set; }

        /// <summary>
        /// <para>伸缩活动触发模式。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ByLoad</para>
        /// </summary>
        [NameInMap("TriggerMode")]
        [Validation(Required=false)]
        public string TriggerMode { get; set; }

    }

}
