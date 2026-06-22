// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class RunClusterShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application configurations. The number of array elements N can range from 1 to 1000.</para>
        /// </summary>
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public string ApplicationConfigsShrink { get; set; }

        /// <summary>
        /// <para>The list of applications. The number of array elements N can range from 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public string ApplicationsShrink { get; set; }

        /// <summary>
        /// <para>The array of bootstrap scripts. The number of array elements N can range from 1 to 10.</para>
        /// </summary>
        [NameInMap("BootstrapScripts")]
        [Validation(Required=false)]
        public string BootstrapScriptsShrink { get; set; }

        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. Multiple calls with the same client token return the same result and create only one cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7D960FA-6DBA-5E07-8746-A63E3E4D****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cluster name. The name must be 1 to 128 characters in length. It must start with a letter or a Chinese character. It cannot start with http\:// or https\://. It can contain Chinese characters, letters, digits, colons (:), underscores (_), periods (.), or hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emrtest</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The cluster type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DATALAKE: new data lake.</para>
        /// </description></item>
        /// <item><description><para>OLAP: data analytics.</para>
        /// </description></item>
        /// <item><description><para>DATAFLOW: real-time data stream.</para>
        /// </description></item>
        /// <item><description><para>DATASERVING: DataService Studio.</para>
        /// </description></item>
        /// <item><description><para>CUSTOM: custom cluster.</para>
        /// </description></item>
        /// <item><description><para>HADOOP: legacy data lake. This value is not recommended. Use the new data lake cluster type instead.</para>
        /// </description></item>
        /// </list>
        /// <para>If you create an EMR cluster for the first time after 17:00 (UTC+8) on December 19, 2022, you cannot select HADOOP, DATA_SCIENCE, PRESTO, or ZOOKEEPER as the cluster type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATALAKE</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables deletion protection.</para>
        /// </description></item>
        /// <item><description><para>false: Disables deletion protection.</para>
        /// </description></item>
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
        /// <para>The deployment mode of applications in the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NORMAL (default): non-high availability deployment. The cluster has one master node.</para>
        /// </description></item>
        /// <item><description><para>HA: high availability (HA) deployment. This deployment mode requires at least three master nodes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HA</para>
        /// </summary>
        [NameInMap("DeployMode")]
        [Validation(Required=false)]
        public string DeployMode { get; set; }

        /// <summary>
        /// <para>The description of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Emr cluster for ETL</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The node attributes. These are the basic attributes of all ECS nodes in the cluster.</para>
        /// </summary>
        [NameInMap("NodeAttributes")]
        [Validation(Required=false)]
        public string NodeAttributesShrink { get; set; }

        /// <summary>
        /// <para>The array of node group configurations. The number of array elements N can range from 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public string NodeGroupsShrink { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PayAsYouGo: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para>Subscription: subscription.</para>
        /// </description></item>
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
        /// <para>The EMR release version. You can find the EMR release version on the EMR cluster purchase page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EMR-5.16.0</para>
        /// </summary>
        [NameInMap("ReleaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzabjyop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The Kerberos security mode of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NORMAL (default): normal mode. Kerberos is disabled.</para>
        /// </description></item>
        /// <item><description><para>KERBEROS: Kerberos mode. Kerberos is enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("SecurityMode")]
        [Validation(Required=false)]
        public string SecurityMode { get; set; }

        /// <summary>
        /// <para>The subscription configurations. This parameter is required if you set PaymentType to Subscription.</para>
        /// </summary>
        [NameInMap("SubscriptionConfig")]
        [Validation(Required=false)]
        public string SubscriptionConfigShrink { get; set; }

        /// <summary>
        /// <para>The tags. The number of array elements N can range from 0 to 20.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
