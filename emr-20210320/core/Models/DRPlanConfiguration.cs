// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class DRPlanConfiguration : TeaModel {
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public List<ApplicationConfig> ApplicationConfigs { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<Application> Applications { get; set; }

        [NameInMap("BootstrapScripts")]
        [Validation(Required=false)]
        public List<Script> BootstrapScripts { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        [NameInMap("DeployMode")]
        [Validation(Required=false)]
        public string DeployMode { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("LogCollectStrategy")]
        [Validation(Required=false)]
        public string LogCollectStrategy { get; set; }

        [NameInMap("ManagedScalingPolicy")]
        [Validation(Required=false)]
        public DRPlanConfigurationManagedScalingPolicy ManagedScalingPolicy { get; set; }
        public class DRPlanConfigurationManagedScalingPolicy : TeaModel {
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public ManagedScalingConstraints Constraints { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeAttributes")]
        [Validation(Required=false)]
        public NodeAttributes NodeAttributes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<NodeGroupConfig> NodeGroups { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ReleaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SecurityMode")]
        [Validation(Required=false)]
        public string SecurityMode { get; set; }

        [NameInMap("SubscriptionConfig")]
        [Validation(Required=false)]
        public SubscriptionConfig SubscriptionConfig { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DRPlanConfigurationTags> Tags { get; set; }
        public class DRPlanConfigurationTags : TeaModel {
            /// <summary>
            /// <para>The tag key. This parameter is required. The key can be up to 128 characters in length and cannot be an empty string. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>department</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. This parameter is optional. The value can be up to 128 characters in length and can be an empty string. It cannot start with <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IT</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
