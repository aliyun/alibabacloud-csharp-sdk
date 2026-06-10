// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// <para>A list of software to install in the cluster. You can specify up to 10 packages.</para>
        /// </summary>
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public List<CreateClusterRequestAdditionalPackages> AdditionalPackages { get; set; }
        public class CreateClusterRequestAdditionalPackages : TeaModel {
            /// <summary>
            /// <para>The name of the software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mpich</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version of the software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.0.3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The configuration of the custom service component for the cluster. Only one component is supported.</para>
        /// </summary>
        [NameInMap("Addons")]
        [Validation(Required=false)]
        public List<CreateClusterRequestAddons> Addons { get; set; }
        public class CreateClusterRequestAddons : TeaModel {
            /// <summary>
            /// <para>The name of the custom service component.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Login</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The resource configuration of the custom service component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\\&quot;EipResource\\&quot;: {\\&quot;AutoCreate\\&quot;: true}, \\&quot;EcsResources\\&quot;: [{\\&quot;InstanceType\\&quot;: \\&quot;ecs.c7.xlarge\\&quot;, \\&quot;ImageId\\&quot;: \\&quot;centos_7_6_x64_20G_alibase_20211130.vhd\\&quot;, \\&quot;SystemDisk\\&quot;: {\\&quot;Category\\&quot;: \\&quot;cloud_essd\\&quot;, \\&quot;Size\\&quot;: 40, \\&quot;Level\\&quot;: \\&quot;PL0\\&quot;}, \\&quot;EnableHT\\&quot;: true, \\&quot;InstanceChargeType\\&quot;: \\&quot;PostPaid\\&quot;, \\&quot;SpotStrategy\\&quot;: \\&quot;NoSpot\\&quot;}]}&quot;</para>
            /// </summary>
            [NameInMap("ResourcesSpec")]
            [Validation(Required=false)]
            public string ResourcesSpec { get; set; }

            /// <summary>
            /// <para>The service configuration of the custom service component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;[{\\&quot;ServiceName\\&quot;: \\&quot;SSH\\&quot;, \\&quot;ServiceAccessType\\&quot;: null, \\&quot;ServiceAccessUrl\\&quot;: null, \\&quot;NetworkACL\\&quot;: [{\\&quot;IpProtocol\\&quot;: \\&quot;TCP\\&quot;, \\&quot;Port\\&quot;: 22, \\&quot;SourceCidrIp\\&quot;: \\&quot;0.0.0.0/0\\&quot;}]}, {\\&quot;ServiceName\\&quot;: \\&quot;VNC\\&quot;, \\&quot;ServiceAccessType\\&quot;: null, \\&quot;ServiceAccessUrl\\&quot;: null, \\&quot;NetworkACL\\&quot;: [{\\&quot;IpProtocol\\&quot;: \\&quot;TCP\\&quot;, \\&quot;Port\\&quot;: 12016, \\&quot;SourceCidrIp\\&quot;: \\&quot;0.0.0.0/0\\&quot;}]}, {\\&quot;ServiceName\\&quot;: \\&quot;CLIENT\\&quot;, \\&quot;ServiceAccessType\\&quot;: \\&quot;URL\\&quot;, \\&quot;ServiceAccessUrl\\&quot;: \\&quot;\\&quot;, \\&quot;NetworkACL\\&quot;: [{\\&quot;IpProtocol\\&quot;: \\&quot;TCP\\&quot;, \\&quot;Port\\&quot;: 12011, \\&quot;SourceCidrIp\\&quot;: \\&quot;0.0.0.0/0\\&quot;}]}]&quot;</para>
            /// </summary>
            [NameInMap("ServicesSpec")]
            [Validation(Required=false)]
            public string ServicesSpec { get; set; }

            /// <summary>
            /// <para>The version of the custom service component.</para>
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
        public CreateClusterRequestClusterCredentials ClusterCredentials { get; set; }
        public class CreateClusterRequestClusterCredentials : TeaModel {
            /// <summary>
            /// <para>The key pair name. The name must be 2 to 128 characters long, start with a letter or a Chinese character, and not start with <c>http://</c> or <c>https://</c>. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
            /// <remarks>
            /// <para>To use an ECS key pair, see <a href="https://help.aliyun.com/document_detail/51793.html">Create a key pair</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ali0824</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The root password of the login node. The password must be 8 to 20 characters long and include characters from at least three of the following categories: uppercase letters, lowercase letters, digits, and special characters. The supported special characters are: <c>() ~ ! @ # $ % ^ &amp; * - = + { } [ ] : ; ‘ &lt; &gt; , . ? /</c></para>
            /// <remarks>
            /// <para>Use HTTPS when calling the API to prevent password exposure.</para>
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
        /// <para>The post-processing script for the cluster.</para>
        /// </summary>
        [NameInMap("ClusterCustomConfiguration")]
        [Validation(Required=false)]
        public CreateClusterRequestClusterCustomConfiguration ClusterCustomConfiguration { get; set; }
        public class CreateClusterRequestClusterCustomConfiguration : TeaModel {
            /// <summary>
            /// <para>The execution parameters for the post-processing script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>E-HPC cn-hangzhou</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// <para>The download URL for the post-processing script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://*****</para>
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

        }

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
        public CreateClusterRequestManager Manager { get; set; }
        public class CreateClusterRequestManager : TeaModel {
            /// <summary>
            /// <para>Configuration for the DNS service.</para>
            /// </summary>
            [NameInMap("DNS")]
            [Validation(Required=false)]
            public CreateClusterRequestManagerDNS DNS { get; set; }
            public class CreateClusterRequestManagerDNS : TeaModel {
                /// <summary>
                /// <para>The DNS service type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NIS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The DNS service version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.31</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>Configuration for the directory service.</para>
            /// </summary>
            [NameInMap("DirectoryService")]
            [Validation(Required=false)]
            public CreateClusterRequestManagerDirectoryService DirectoryService { get; set; }
            public class CreateClusterRequestManagerDirectoryService : TeaModel {
                /// <summary>
                /// <para>The directory service type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NIS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The directory service version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.31</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>Hardware configuration for the manager node.</para>
            /// </summary>
            [NameInMap("ManagerNode")]
            [Validation(Required=false)]
            public NodeTemplate ManagerNode { get; set; }

            /// <summary>
            /// <para>Configuration for the scheduler.</para>
            /// </summary>
            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public CreateClusterRequestManagerScheduler Scheduler { get; set; }
            public class CreateClusterRequestManagerScheduler : TeaModel {
                /// <summary>
                /// <para>The scheduler type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>SLURM</para>
                /// </description></item>
                /// <item><description><para>PBS</para>
                /// </description></item>
                /// <item><description><para>OPENGRIDSCHEDULER</para>
                /// </description></item>
                /// <item><description><para>LSF_PLUGIN</para>
                /// </description></item>
                /// <item><description><para>PBS_PLUGIN</para>
                /// </description></item>
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
        public List<QueueTemplate> Queues { get; set; }

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
        public List<SharedStorageTemplate> SharedStorages { get; set; }

        /// <summary>
        /// <para>The list of tags to add to the cluster. You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTags> Tags { get; set; }
        public class CreateClusterRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key. The key cannot be an empty string. The key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ClusterId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be an empty string. The value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
