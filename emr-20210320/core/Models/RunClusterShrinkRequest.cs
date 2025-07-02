// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class RunClusterShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application configurations. Number of elements in the array: 1 to 1000.</para>
        /// </summary>
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public string ApplicationConfigsShrink { get; set; }

        /// <summary>
        /// <para>The list of services. Number of elements in the array: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public string ApplicationsShrink { get; set; }

        /// <summary>
        /// <para>The array of bootstrap scripts. Number of elements in the array: 1 to 10.</para>
        /// </summary>
        [NameInMap("BootstrapScripts")]
        [Validation(Required=false)]
        public string BootstrapScriptsShrink { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. The same ClientToken value for multiple calls to the RunCluster operation results in identical responses. Only one cluster can be created by using the same ClientToken value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7D960FA-6DBA-5E07-8746-A63E3E4D****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cluster name. The name must be 1 to 128 characters in length. The name must start with a letter but cannot start with http:// or https://. The name can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
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
        /// <item><description>DATALAKE</description></item>
        /// <item><description>OLAP</description></item>
        /// <item><description>DATAFLOW</description></item>
        /// <item><description>DATASERVING</description></item>
        /// <item><description>CUSTOM</description></item>
        /// <item><description>HADOOP: We recommend that you set this parameter to DATALAKE rather than HADOOP.</description></item>
        /// </list>
        /// <para>If the first time you create an EMR cluster is after 17:00 (UTC+8) on December 19, 2022, you cannot create a Hadoop, Data Science, Presto, or ZooKeeper cluster.</para>
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
        /// <item><description>HA: high availability mode. A cluster that contains at least three master nodes is created.</description></item>
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
        /// <para>The node attributes. The basic attributes of all ECS nodes in the cluster.</para>
        /// </summary>
        [NameInMap("NodeAttributes")]
        [Validation(Required=false)]
        public string NodeAttributesShrink { get; set; }

        /// <summary>
        /// <para>The array of configurations of the node groups. Number of elements in the array: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public string NodeGroupsShrink { get; set; }

        /// <summary>
        /// <para>The billing method of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo</description></item>
        /// <item><description>Subscription</description></item>
        /// </list>
        /// <para>Default value: PayAsYouGo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("Promotions")]
        [Validation(Required=false)]
        public string PromotionsShrink { get; set; }

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
        /// <para>The EMR version. You can query available EMR versions in the EMR console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EMR-5.16.0</para>
        /// </summary>
        [NameInMap("ReleaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
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
        /// <item><description>NORMAL: regular mode. Kerberos authentication is disabled. This is the default value.</description></item>
        /// <item><description>KERBEROS: Kerberos mode. Kerberos authentication is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("SecurityMode")]
        [Validation(Required=false)]
        public string SecurityMode { get; set; }

        /// <summary>
        /// <para>The subscription configurations. This parameter is required when the PaymentType parameter is set to Subscription.</para>
        /// </summary>
        [NameInMap("SubscriptionConfig")]
        [Validation(Required=false)]
        public string SubscriptionConfigShrink { get; set; }

        /// <summary>
        /// <para>The tag. Number of elements in the array: 0 to 20.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
