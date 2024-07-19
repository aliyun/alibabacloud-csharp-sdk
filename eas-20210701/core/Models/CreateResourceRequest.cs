// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateResourceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable auto-renewal. Valid values:
        /// 
        /// *   false (default)
        /// *   true
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// The billing method. Valid values:
        /// 
        /// *   PrePaid: the subscription billing method.
        /// *   PostPaid: the pay-as-you-go billing method.
        /// 
        /// >  This parameter is required when the ResourceType parameter is set to Dedicated.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The number of ECS instances.
        /// 
        /// >  This parameter is required when the ResourceType parameter is set to Dedicated.
        /// </summary>
        [NameInMap("EcsInstanceCount")]
        [Validation(Required=false)]
        public int? EcsInstanceCount { get; set; }

        /// <summary>
        /// The type of the Elastic Compute Service (ECS) instance.
        /// 
        /// >  This parameter is required when the ResourceType parameter is set to Dedicated.
        /// </summary>
        [NameInMap("EcsInstanceType")]
        [Validation(Required=false)]
        public string EcsInstanceType { get; set; }

        /// <summary>
        /// The type of the resource group. Valid values:
        /// 
        /// *   Dedicated: the dedicated resource group.
        /// *   SelfManaged: the self-managed resource group.
        /// 
        /// >  If you use a self-managed resource group, you must configure a whitelist.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The configurations of the self-managed resource group.
        /// </summary>
        [NameInMap("SelfManagedResourceOptions")]
        [Validation(Required=false)]
        public CreateResourceRequestSelfManagedResourceOptions SelfManagedResourceOptions { get; set; }
        public class CreateResourceRequestSelfManagedResourceOptions : TeaModel {
            /// <summary>
            /// The ID of the self-managed cluster.
            /// </summary>
            [NameInMap("ExternalClusterId")]
            [Validation(Required=false)]
            public string ExternalClusterId { get; set; }

            /// <summary>
            /// The tag key-value pairs for nodes.
            /// </summary>
            [NameInMap("NodeMatchLabels")]
            [Validation(Required=false)]
            public Dictionary<string, string> NodeMatchLabels { get; set; }

            /// <summary>
            /// Tolerations for nodes.
            /// </summary>
            [NameInMap("NodeTolerations")]
            [Validation(Required=false)]
            public List<CreateResourceRequestSelfManagedResourceOptionsNodeTolerations> NodeTolerations { get; set; }
            public class CreateResourceRequestSelfManagedResourceOptionsNodeTolerations : TeaModel {
                /// <summary>
                /// The result.
                /// 
                /// Valid values:
                /// 
                /// *   PreferNoSchedule
                /// *   NoSchedule
                /// *   NoExecute
                /// </summary>
                [NameInMap("effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// The key name.
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The relationship between key names and key values.
                /// 
                /// Valid values:
                /// 
                /// *   Equal
                /// *   Exists
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// The key value.
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The name of the RAM user to which the permissions on Elastic Algorithm Service of Platform for AI (PAI-EAS) are granted.
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
        /// The ID of the zone in which the instance resides.
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
