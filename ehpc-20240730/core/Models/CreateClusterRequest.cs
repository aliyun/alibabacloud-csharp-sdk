// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// <para>The list of software that you want to install in the cluster. Valid values of N: 0 to 10.</para>
        /// </summary>
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public List<CreateClusterRequestAdditionalPackages> AdditionalPackages { get; set; }
        public class CreateClusterRequestAdditionalPackages : TeaModel {
            /// <summary>
            /// <para>The name of the software that you want to install in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mpich</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version of the software that you want to install in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.0.3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The configurations of the custom addons in the cluster. Only one addon is supported.</para>
        /// </summary>
        [NameInMap("Addons")]
        [Validation(Required=false)]
        public List<CreateClusterRequestAddons> Addons { get; set; }
        public class CreateClusterRequestAddons : TeaModel {
            /// <summary>
            /// <para>The addon name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Login</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The resource configurations of the addon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\\&quot;EipResource\\&quot;: {\\&quot;AutoCreate\\&quot;: true}, \\&quot;EcsResources\\&quot;: [{\\&quot;InstanceType\\&quot;: \\&quot;ecs.c7.xlarge\\&quot;, \\&quot;ImageId\\&quot;: \\&quot;centos_7_6_x64_20G_alibase_20211130.vhd\\&quot;, \\&quot;SystemDisk\\&quot;: {\\&quot;Category\\&quot;: \\&quot;cloud_essd\\&quot;, \\&quot;Size\\&quot;: 40, \\&quot;Level\\&quot;: \\&quot;PL0\\&quot;}, \\&quot;EnableHT\\&quot;: true, \\&quot;InstanceChargeType\\&quot;: \\&quot;PostPaid\\&quot;, \\&quot;SpotStrategy\\&quot;: \\&quot;NoSpot\\&quot;}]}&quot;</para>
            /// </summary>
            [NameInMap("ResourcesSpec")]
            [Validation(Required=false)]
            public string ResourcesSpec { get; set; }

            /// <summary>
            /// <para>The service configurations of the addon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;[{\\&quot;ServiceName\\&quot;: \\&quot;SSH\\&quot;, \\&quot;ServiceAccessType\\&quot;: null, \\&quot;ServiceAccessUrl\\&quot;: null, \\&quot;NetworkACL\\&quot;: [{\\&quot;IpProtocol\\&quot;: \\&quot;TCP\\&quot;, \\&quot;Port\\&quot;: 22, \\&quot;SourceCidrIp\\&quot;: \\&quot;0.0.0.0/0\\&quot;}]}, {\\&quot;ServiceName\\&quot;: \\&quot;VNC\\&quot;, \\&quot;ServiceAccessType\\&quot;: null, \\&quot;ServiceAccessUrl\\&quot;: null, \\&quot;NetworkACL\\&quot;: [{\\&quot;IpProtocol\\&quot;: \\&quot;TCP\\&quot;, \\&quot;Port\\&quot;: 12016, \\&quot;SourceCidrIp\\&quot;: \\&quot;0.0.0.0/0\\&quot;}]}, {\\&quot;ServiceName\\&quot;: \\&quot;CLIENT\\&quot;, \\&quot;ServiceAccessType\\&quot;: \\&quot;URL\\&quot;, \\&quot;ServiceAccessUrl\\&quot;: \\&quot;\\&quot;, \\&quot;NetworkACL\\&quot;: [{\\&quot;IpProtocol\\&quot;: \\&quot;TCP\\&quot;, \\&quot;Port\\&quot;: 12011, \\&quot;SourceCidrIp\\&quot;: \\&quot;0.0.0.0/0\\&quot;}]}]&quot;</para>
            /// </summary>
            [NameInMap("ServicesSpec")]
            [Validation(Required=false)]
            public string ServicesSpec { get; set; }

            /// <summary>
            /// <para>The addon version.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

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
        public CreateClusterRequestClusterCredentials ClusterCredentials { get; set; }
        public class CreateClusterRequestClusterCredentials : TeaModel {
            /// <summary>
            /// <para>The name of the key pair. The name must be 2 to 128 characters in length. The name must start with a letter but cannot start with <c>http://</c> or <c>https://</c>. The name can contain digits, letters, colons (:), underscores (_), and hyphens (-).</para>
            /// <remarks>
            /// <para> For more information, see <a href="https://help.aliyun.com/document_detail/51793.html">Create a key pair</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ali0824</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The password for the root user to log on to the node. The password must be 8 to 20 characters in length, and must contain at least 3 of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported: <c>() ~ ! @ # $ % ^ &amp; * - = + { } [ ] : ; \\&quot; &lt; &gt; , . ? /</c></para>
            /// <remarks>
            /// <para> We recommend that you use HTTPS to call the API operation to prevent password leakage.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

        }

        /// <summary>
        /// <para>The post-processing script of the cluster.</para>
        /// </summary>
        [NameInMap("ClusterCustomConfiguration")]
        [Validation(Required=false)]
        public CreateClusterRequestClusterCustomConfiguration ClusterCustomConfiguration { get; set; }
        public class CreateClusterRequestClusterCustomConfiguration : TeaModel {
            /// <summary>
            /// <para>The runtime parameters of the script after the cluster is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>E-HPC cn-hangzhou</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// <para>The URL that is used to download the post-processing script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://*****</para>
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

        }

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
        public CreateClusterRequestManager Manager { get; set; }
        public class CreateClusterRequestManager : TeaModel {
            /// <summary>
            /// <para>The configurations of the domain name resolution service.</para>
            /// </summary>
            [NameInMap("DNS")]
            [Validation(Required=false)]
            public CreateClusterRequestManagerDNS DNS { get; set; }
            public class CreateClusterRequestManagerDNS : TeaModel {
                /// <summary>
                /// <para>The domain name resolution type.</para>
                /// <para>Valid value:</para>
                /// <list type="bullet">
                /// <item><description>NIS</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NIS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The version of the domain name resolution service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.31</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The configurations of the domain account service.</para>
            /// </summary>
            [NameInMap("DirectoryService")]
            [Validation(Required=false)]
            public CreateClusterRequestManagerDirectoryService DirectoryService { get; set; }
            public class CreateClusterRequestManagerDirectoryService : TeaModel {
                /// <summary>
                /// <para>The type of the domain account.</para>
                /// <para>Valid value:</para>
                /// <list type="bullet">
                /// <item><description>NIS</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NIS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The version of the domain account service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.31</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The hardware configurations of the management node.</para>
            /// </summary>
            [NameInMap("ManagerNode")]
            [Validation(Required=false)]
            public NodeTemplate ManagerNode { get; set; }

            /// <summary>
            /// <para>The configurations of the scheduler service.</para>
            /// </summary>
            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public CreateClusterRequestManagerScheduler Scheduler { get; set; }
            public class CreateClusterRequestManagerScheduler : TeaModel {
                /// <summary>
                /// <para>The scheduler type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SLURM</description></item>
                /// <item><description>PBS</description></item>
                /// <item><description>OPENGRIDSCHEDULER</description></item>
                /// <item><description>LSF_PLUGIN</description></item>
                /// <item><description>PBS_PLUGIN</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SLURM</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The scheduler version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22.05.8</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

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
        /// <para>The queues in the cluster. The number of queues can be 0 to 8.</para>
        /// </summary>
        [NameInMap("Queues")]
        [Validation(Required=false)]
        public List<QueueTemplate> Queues { get; set; }

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
        /// <para>The shared storage resources of the cluster.</para>
        /// </summary>
        [NameInMap("SharedStorages")]
        [Validation(Required=false)]
        public List<SharedStorageTemplate> SharedStorages { get; set; }

        /// <summary>
        /// <para>The tags of the cluster.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTags> Tags { get; set; }
        public class CreateClusterRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ClusterId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ehpc-hz-******</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
