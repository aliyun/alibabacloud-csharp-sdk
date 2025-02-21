// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// <para>The application configurations. Number of elements in the array: 1 to 1000.</para>
        /// </summary>
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public List<ApplicationConfig> ApplicationConfigs { get; set; }

        /// <summary>
        /// <para>The services. Number of elements in the array: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<Application> Applications { get; set; }

        /// <summary>
        /// <para>The bootstrap actions. Number of elements in the array: 1 to 10.</para>
        /// </summary>
        [NameInMap("BootstrapScripts")]
        [Validation(Required=false)]
        public List<Script> BootstrapScripts { get; set; }

        /// <summary>
        /// <para>The idempotent client token. If you call the same ClientToken multiple times, the returned results are the same. Only one cluster can be created with the same ClientToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7D960FA-6DBA-5E07-8746-A63E3E4D****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the cluster. The name must be 1 to 128 characters in length. It must start with a letter and cannot start with http:// or https://. It can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emrtest</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The type of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATALAKE: data lake</description></item>
        /// <item><description>OLAP: online analytical processing (OLAP)</description></item>
        /// <item><description>DATAFLOW: Dataflow</description></item>
        /// <item><description>DATASERVING: DataServing</description></item>
        /// <item><description>CUSTOM: a custom hybrid cluster.</description></item>
        /// <item><description>HADOOP: the old data lake. We recommend that you use the new data lake.</description></item>
        /// </list>
        /// <para>If you create an EMR cluster for the first time after 17:00 (UTC +8) on December 19, 2022, you cannot select the HADOOP, DATA_SCIENCE, PRESTO, or ZOOKEEPER cluster type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATALAKE</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable release protection for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables release protection for the cluster.</description></item>
        /// <item><description>false: disables release protection for the cluster.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The deployment mode of master nodes in the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: regular mode. This is the default value. A cluster that contains only one master node is created.</description></item>
        /// <item><description>HA: high availability (HA) mode. A cluster that contains three master nodes is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HA</para>
        /// </summary>
        [NameInMap("DeployMode")]
        [Validation(Required=false)]
        public string DeployMode { get; set; }

        /// <summary>
        /// <para>The cluster description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Emr cluster for ETL</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The attributes of all ECS instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeAttributes")]
        [Validation(Required=false)]
        public NodeAttributes NodeAttributes { get; set; }

        /// <summary>
        /// <para>The node groups. Number of elements in the array: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<NodeGroupConfig> NodeGroups { get; set; }

        /// <summary>
        /// <para>The billing cycle of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo: pay-as-you-go</description></item>
        /// <item><description>Subscription: subscription</description></item>
        /// </list>
        /// <para>Default value: PayAsYouGo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The EMR version. You can query available E-MapReduce (EMR) versions in the EMR console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EMR-5.8.0</para>
        /// </summary>
        [NameInMap("ReleaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which to assign the ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzabjyop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The security mode of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: disables Kerberos authentication for the cluster. This is the default value.</description></item>
        /// <item><description>KERBEROS: enables Kerberos authentication for the cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("SecurityMode")]
        [Validation(Required=false)]
        public string SecurityMode { get; set; }

        /// <summary>
        /// <para>The subscription configurations. This parameter takes effect only if you set the PaymentType parameter to Subscription.</para>
        /// </summary>
        [NameInMap("SubscriptionConfig")]
        [Validation(Required=false)]
        public SubscriptionConfig SubscriptionConfig { get; set; }

        /// <summary>
        /// <para>The tags. Number of elements in the array: 0 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7D960FA-6DBA-5E07-8746-A63E3E4D****</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
