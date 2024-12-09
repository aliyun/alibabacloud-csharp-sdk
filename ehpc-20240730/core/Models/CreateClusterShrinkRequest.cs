// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class CreateClusterShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of software that you want to install in the cluster. Valid values of N: 0 to 10.</para>
        /// </summary>
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public string AdditionalPackagesShrink { get; set; }

        /// <summary>
        /// <para>The configurations of the custom addons in the cluster. Only one addon is supported.</para>
        /// </summary>
        [NameInMap("Addons")]
        [Validation(Required=false)]
        public string AddonsShrink { get; set; }

        /// <summary>
        /// <para>The client version. By default, the latest version is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.1.0</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <para>The cluster type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard</description></item>
        /// <item><description>Serverless</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ClusterCategory")]
        [Validation(Required=false)]
        public string ClusterCategory { get; set; }

        /// <summary>
        /// <para>The access credentials of the cluster.</para>
        /// </summary>
        [NameInMap("ClusterCredentials")]
        [Validation(Required=false)]
        public string ClusterCredentialsShrink { get; set; }

        /// <summary>
        /// <para>The post-processing script of the cluster.</para>
        /// </summary>
        [NameInMap("ClusterCustomConfiguration")]
        [Validation(Required=false)]
        public string ClusterCustomConfigurationShrink { get; set; }

        /// <summary>
        /// <para>The cluster description. The description must be 1 to 128 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>slurm22.05.8-cluster-20240718</para>
        /// </summary>
        [NameInMap("ClusterDescription")]
        [Validation(Required=false)]
        public string ClusterDescription { get; set; }

        /// <summary>
        /// <para>The deployment mode of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Integrated</description></item>
        /// <item><description>Hybrid</description></item>
        /// <item><description>Custom</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Integrated</para>
        /// </summary>
        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// <para>The cluster name. The name must be 1 to 128 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>slurm22.05.8-cluster-20240718</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch that you want the cluster to use. The vSwitch must reside in the VPC that is specified by the <c>ClusterVpcId</c> parameter.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/448581.html">DescribeVpcs</a> operation to query information about the created VPCs and vSwitches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-f8za5p0mwzgdu3wgx****</para>
        /// </summary>
        [NameInMap("ClusterVSwitchId")]
        [Validation(Required=false)]
        public string ClusterVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) in which the cluster resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-m5efjevmclc0xdmys****</para>
        /// </summary>
        [NameInMap("ClusterVpcId")]
        [Validation(Required=false)]
        public string ClusterVpcId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the cluster. Deletion protection decides whether the cluster can be deleted in the console or by calling the <a href="https://help.aliyun.com/document_detail/424406.html">DeleteCluster</a> operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
        /// <para>Specifies whether to use an advanced security group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: automatically creates and uses an advanced security group.</description></item>
        /// <item><description>false: automatically creates and uses a basic security group.</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/605897.html">Basic security groups and advanced security groups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsEnterpriseSecurityGroup")]
        [Validation(Required=false)]
        public bool? IsEnterpriseSecurityGroup { get; set; }

        /// <summary>
        /// <para>The configurations of the cluster management node.</para>
        /// </summary>
        [NameInMap("Manager")]
        [Validation(Required=false)]
        public string ManagerShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of vCPUs that can be used by compute nodes in the cluster. Valid values: 0 to 100,000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MaxCoreCount")]
        [Validation(Required=false)]
        public int? MaxCoreCount { get; set; }

        /// <summary>
        /// <para>The maximum number of compute nodes that the cluster can manage. Valid values: 0 to 5,000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MaxCount")]
        [Validation(Required=false)]
        public int? MaxCount { get; set; }

        /// <summary>
        /// <para>The configurations of the queues in the cluster. The number of queues can be 0 to 8.</para>
        /// </summary>
        [NameInMap("Queues")]
        [Validation(Required=false)]
        public string QueuesShrink { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the cluster belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to obtain the IDs of the resource groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the cluster belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/25556.html">DescribeSecurityGroups</a> operation to query available security groups in the current region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp13n61xsydodfyg****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The configurations of shared storage in the cluster.</para>
        /// </summary>
        [NameInMap("SharedStorages")]
        [Validation(Required=false)]
        public string SharedStoragesShrink { get; set; }

        /// <summary>
        /// <para>The tags of the cluster.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
