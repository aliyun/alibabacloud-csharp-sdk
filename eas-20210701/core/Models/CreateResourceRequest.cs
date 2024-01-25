// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateResourceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable auto-renewal. Valid values: false (default)
        /// 
        /// *   true
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   PrePaid: the subscription billing method.
        /// *   PostPaid: the pay-as-you-go billing method.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The number of ECS instances.
        /// </summary>
        [NameInMap("EcsInstanceCount")]
        [Validation(Required=false)]
        public int? EcsInstanceCount { get; set; }

        /// <summary>
        /// The type of the Elastic Compute Service (ECS) instance.
        /// </summary>
        [NameInMap("EcsInstanceType")]
        [Validation(Required=false)]
        public string EcsInstanceType { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 自运维资源组配置选项
        /// </summary>
        [NameInMap("SelfManagedResourceOptions")]
        [Validation(Required=false)]
        public CreateResourceRequestSelfManagedResourceOptions SelfManagedResourceOptions { get; set; }
        public class CreateResourceRequestSelfManagedResourceOptions : TeaModel {
            /// <summary>
            /// 自运维集群Id
            /// </summary>
            [NameInMap("ExternalClusterId")]
            [Validation(Required=false)]
            public string ExternalClusterId { get; set; }

            /// <summary>
            /// 节点的标签键值对集合
            /// </summary>
            [NameInMap("NodeMatchLabels")]
            [Validation(Required=false)]
            public Dictionary<string, string> NodeMatchLabels { get; set; }

            /// <summary>
            /// 节点污点的容忍度列表
            /// </summary>
            [NameInMap("NodeTolerations")]
            [Validation(Required=false)]
            public List<CreateResourceRequestSelfManagedResourceOptionsNodeTolerations> NodeTolerations { get; set; }
            public class CreateResourceRequestSelfManagedResourceOptionsNodeTolerations : TeaModel {
                /// <summary>
                /// 效果
                /// </summary>
                [NameInMap("effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// 键名
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// 键名和键值的关系
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// 键值
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// 授予云服务PAI-EAS相关权限的RAM角色名称
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        /// <summary>
        /// The size of the system disk. Unit: GiB. Valid values: 200 to 2000. Default value: 200.
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// The zone to which the instance belongs.
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
