// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// The application configurations. You can specify a maximum of 1,000 items.
        /// </summary>
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public List<ApplicationConfig> ApplicationConfigs { get; set; }

        /// <summary>
        /// The applications. You can specify a maximum of 100 items.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<Application> Applications { get; set; }

        /// <summary>
        /// The bootstrap actions. You can specify a maximum of 10 items.
        /// </summary>
        [NameInMap("BootstrapScripts")]
        [Validation(Required=false)]
        public List<Script> BootstrapScripts { get; set; }

        /// <summary>
        /// The idempotent client token. If you call the same ClientToken multiple times, the returned results are the same. Only one cluster can be created with the same ClientToken.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The name of the cluster. The name must be 1 to 128 characters in length. It must start with a letter and cannot start with http:// or https://. It can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// The type of the cluster. Valid values:
        /// 
        /// *   DATALAKE: data lake
        /// *   OLAP: online analytical processing (OLAP)
        /// *   DATAFLOW: Dataflow
        /// *   DATASERVING: DataServing
        /// *   CUSTOM: a custom hybrid cluster.
        /// *   HADOOP: the old data lake. We recommend that you use the new data lake.
        /// 
        /// If you create an EMR cluster for the first time after 17:00 (UTC +8) on December 19, 2022, you cannot select the HADOOP, DATA_SCIENCE, PRESTO, or ZOOKEEPER cluster type.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The deployment mode of master nodes in the cluster. Valid values:
        /// 
        /// *   NORMAL: regular mode. This is the default value. A cluster that contains only one master node is created.
        /// *   HA: high availability (HA) mode. A cluster that contains three master nodes is created.
        /// </summary>
        [NameInMap("DeployMode")]
        [Validation(Required=false)]
        public string DeployMode { get; set; }

        /// <summary>
        /// The attributes of all ECS instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeAttributes")]
        [Validation(Required=false)]
        public NodeAttributes NodeAttributes { get; set; }

        /// <summary>
        /// The node groups. You can specify a maximum of 100 items.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<NodeGroupConfig> NodeGroups { get; set; }

        /// <summary>
        /// The billing cycle of the instance. Valid values:
        /// 
        /// *   PayAsYouGo: pay-as-you-go
        /// *   Subscription: subscription
        /// 
        /// Default value: PayAsYouGo.
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The version of EMR. You can view the EMR release version on the EMR cluster purchase page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReleaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// The ID of the resource group to which to assign the ENI.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The security mode of the cluster. Valid values:
        /// 
        /// *   NORMAL: disables Kerberos authentication for the cluster. This is the default value.
        /// *   KERBEROS: enables Kerberos authentication for the cluster.
        /// </summary>
        [NameInMap("SecurityMode")]
        [Validation(Required=false)]
        public string SecurityMode { get; set; }

        /// <summary>
        /// The subscription configurations. This parameter is required only if you set the PaymentType parameter to Subscription.
        /// </summary>
        [NameInMap("SubscriptionConfig")]
        [Validation(Required=false)]
        public SubscriptionConfig SubscriptionConfig { get; set; }

        /// <summary>
        /// The tags. You can specify a maximum of 20 items.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
