// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class DRPlanConfigurationDetail : TeaModel {
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public List<ApplicationConfig> ApplicationConfigs { get; set; }

        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<Application> Applications { get; set; }

        [NameInMap("BootstrapScripts")]
        [Validation(Required=false)]
        public List<Script> BootstrapScripts { get; set; }

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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeployMode")]
        [Validation(Required=false)]
        public string DeployMode { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LogCollectStrategy")]
        [Validation(Required=false)]
        public string LogCollectStrategy { get; set; }

        [NameInMap("ManagedScalingPolicy")]
        [Validation(Required=false)]
        public DRPlanConfigurationDetailManagedScalingPolicy ManagedScalingPolicy { get; set; }
        public class DRPlanConfigurationDetailManagedScalingPolicy : TeaModel {
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public ManagedScalingConstraints Constraints { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MetaStoreType")]
        [Validation(Required=false)]
        public string MetaStoreType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeAttributes")]
        [Validation(Required=false)]
        public NodeAttributes NodeAttributes { get; set; }

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

        [NameInMap("ScalingPolicies")]
        [Validation(Required=false)]
        public List<ScalingPolicy> ScalingPolicies { get; set; }

        [NameInMap("ScalingTimeZone")]
        [Validation(Required=false)]
        public string ScalingTimeZone { get; set; }

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
        public List<Tag> Tags { get; set; }

    }

}
