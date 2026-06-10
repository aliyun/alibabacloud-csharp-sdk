// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class CreateClusterShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A list of software to install in the cluster. You can specify up to 10 packages.</para>
        /// </summary>
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public string AdditionalPackagesShrink { get; set; }

        /// <summary>
        /// <para>The configuration of the custom service component for the cluster. Only one component is supported.</para>
        /// </summary>
        [NameInMap("Addons")]
        [Validation(Required=false)]
        public string AddonsShrink { get; set; }

        /// <summary>
        /// <para>The version of the E-HPC client. By default, the latest version is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.1.0</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <para>The edition of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard</para>
        /// </description></item>
        /// <item><description><para>Serverless</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ClusterCategory")]
        [Validation(Required=false)]
        public string ClusterCategory { get; set; }

        /// <summary>
        /// <para>The security credentials for the cluster.</para>
        /// </summary>
        [NameInMap("ClusterCredentials")]
        [Validation(Required=false)]
        public string ClusterCredentialsShrink { get; set; }

        /// <summary>
        /// <para>The post-processing script for the cluster.</para>
        /// </summary>
        [NameInMap("ClusterCustomConfiguration")]
        [Validation(Required=false)]
        public string ClusterCustomConfigurationShrink { get; set; }

        /// <summary>
        /// <para>The description of the cluster. The description must be 2 to 128 characters long and can contain letters, Chinese characters, digits, hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>slurm22.05.8-cluster-20240718</para>
        /// </summary>
        [NameInMap("ClusterDescription")]
        [Validation(Required=false)]
        public string ClusterDescription { get; set; }

        /// <summary>
        /// <para>The cluster\&quot;s deployment type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Integrated: An integrated cluster.</para>
        /// </description></item>
        /// <item><description><para>Hybrid: A hybrid cloud cluster.</para>
        /// </description></item>
        /// <item><description><para>Custom: A custom cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Integrated</para>
        /// </summary>
        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// <para>The name of the cluster. The name must be 2 to 128 characters long and can contain letters, Chinese characters, digits, hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>slurm22.05.8-cluster-20240718</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The ID of the VSwitch for the cluster. The VSwitch must be in the VPC specified by <c>ClusterVpcId</c>.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/448581.html">DescribeVpcs</a> operation to find available VPCs and VSwitches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-f8za5p0mwzgdu3wgx****</para>
        /// </summary>
        [NameInMap("ClusterVSwitchId")]
        [Validation(Required=false)]
        public string ClusterVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC for the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-m5efjevmclc0xdmys****</para>
        /// </summary>
        [NameInMap("ClusterVpcId")]
        [Validation(Required=false)]
        public string ClusterVpcId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the cluster. This feature prevents the cluster from being deleted via the console or the <a href="https://help.aliyun.com/document_detail/424406.html">DeleteCluster</a> operation.</para>
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

        [NameInMap("GrowInterval")]
        [Validation(Required=false)]
        public int? GrowInterval { get; set; }

        [NameInMap("IdleInterval")]
        [Validation(Required=false)]
        public int? IdleInterval { get; set; }

        /// <summary>
        /// <para>Specifies whether to use an enterprise security group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The system automatically creates and uses an enterprise security group.</para>
        /// </description></item>
        /// <item><description><para>false: The system automatically creates and uses a security group.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information about how to select a security group type, see <a href="https://help.aliyun.com/document_detail/605897.html">Security groups and enterprise security groups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsEnterpriseSecurityGroup")]
        [Validation(Required=false)]
        public bool? IsEnterpriseSecurityGroup { get; set; }

        /// <summary>
        /// <para>Configuration for the cluster manager node.</para>
        /// </summary>
        [NameInMap("Manager")]
        [Validation(Required=false)]
        public string ManagerShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores that the cluster can manage across all compute nodes. Valid values: 0 to 100,000.</para>
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
        /// <para>Configuration for the cluster queues. You can specify up to 8 queues.</para>
        /// </summary>
        [NameInMap("Queues")]
        [Validation(Required=false)]
        public string QueuesShrink { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to find resource group IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the security group for the cluster.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/25556.html">DescribeSecurityGroups</a> operation to find available security groups in the current region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp13n61xsydodfyg****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>Configuration for the cluster\&quot;s shared storage.</para>
        /// </summary>
        [NameInMap("SharedStorages")]
        [Validation(Required=false)]
        public string SharedStoragesShrink { get; set; }

        /// <summary>
        /// <para>The list of tags to add to the cluster. You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
