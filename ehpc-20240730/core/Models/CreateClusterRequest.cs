// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class CreateClusterRequest : TeaModel {
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public List<CreateClusterRequestAdditionalPackages> AdditionalPackages { get; set; }
        public class CreateClusterRequestAdditionalPackages : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>mpich</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4.0.3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("Addons")]
        [Validation(Required=false)]
        public List<CreateClusterRequestAddons> Addons { get; set; }
        public class CreateClusterRequestAddons : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Login</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;{\\&quot;EipResource\\&quot;: {\\&quot;AutoCreate\\&quot;: true}, \\&quot;EcsResources\\&quot;: [{\\&quot;InstanceType\\&quot;: \\&quot;ecs.c7.xlarge\\&quot;, \\&quot;ImageId\\&quot;: \\&quot;centos_7_6_x64_20G_alibase_20211130.vhd\\&quot;, \\&quot;SystemDisk\\&quot;: {\\&quot;Category\\&quot;: \\&quot;cloud_essd\\&quot;, \\&quot;Size\\&quot;: 40, \\&quot;Level\\&quot;: \\&quot;PL0\\&quot;}, \\&quot;EnableHT\\&quot;: true, \\&quot;InstanceChargeType\\&quot;: \\&quot;PostPaid\\&quot;, \\&quot;SpotStrategy\\&quot;: \\&quot;NoSpot\\&quot;}]}&quot;</para>
            /// </summary>
            [NameInMap("ResourcesSpec")]
            [Validation(Required=false)]
            public string ResourcesSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;[{\\&quot;ServiceName\\&quot;: \\&quot;SSH\\&quot;, \\&quot;ServiceAccessType\\&quot;: null, \\&quot;ServiceAccessUrl\\&quot;: null, \\&quot;NetworkACL\\&quot;: [{\\&quot;IpProtocol\\&quot;: \\&quot;TCP\\&quot;, \\&quot;Port\\&quot;: 22, \\&quot;SourceCidrIp\\&quot;: \\&quot;0.0.0.0/0\\&quot;}]}, {\\&quot;ServiceName\\&quot;: \\&quot;VNC\\&quot;, \\&quot;ServiceAccessType\\&quot;: null, \\&quot;ServiceAccessUrl\\&quot;: null, \\&quot;NetworkACL\\&quot;: [{\\&quot;IpProtocol\\&quot;: \\&quot;TCP\\&quot;, \\&quot;Port\\&quot;: 12016, \\&quot;SourceCidrIp\\&quot;: \\&quot;0.0.0.0/0\\&quot;}]}, {\\&quot;ServiceName\\&quot;: \\&quot;CLIENT\\&quot;, \\&quot;ServiceAccessType\\&quot;: \\&quot;URL\\&quot;, \\&quot;ServiceAccessUrl\\&quot;: \\&quot;\\&quot;, \\&quot;NetworkACL\\&quot;: [{\\&quot;IpProtocol\\&quot;: \\&quot;TCP\\&quot;, \\&quot;Port\\&quot;: 12011, \\&quot;SourceCidrIp\\&quot;: \\&quot;0.0.0.0/0\\&quot;}]}]&quot;</para>
            /// </summary>
            [NameInMap("ServicesSpec")]
            [Validation(Required=false)]
            public string ServicesSpec { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>2.1.0</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ClusterCategory")]
        [Validation(Required=false)]
        public string ClusterCategory { get; set; }

        [NameInMap("ClusterCredentials")]
        [Validation(Required=false)]
        public CreateClusterRequestClusterCredentials ClusterCredentials { get; set; }
        public class CreateClusterRequestClusterCredentials : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ali0824</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

        }

        [NameInMap("ClusterCustomConfiguration")]
        [Validation(Required=false)]
        public CreateClusterRequestClusterCustomConfiguration ClusterCustomConfiguration { get; set; }
        public class CreateClusterRequestClusterCustomConfiguration : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>E-HPC cn-hangzhou</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>http://*****</para>
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>slurm22.05.8-cluster-20240718</para>
        /// </summary>
        [NameInMap("ClusterDescription")]
        [Validation(Required=false)]
        public string ClusterDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Integrated</para>
        /// </summary>
        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>slurm22.05.8-cluster-20240718</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-f8za5p0mwzgdu3wgx****</para>
        /// </summary>
        [NameInMap("ClusterVSwitchId")]
        [Validation(Required=false)]
        public string ClusterVSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-m5efjevmclc0xdmys****</para>
        /// </summary>
        [NameInMap("ClusterVpcId")]
        [Validation(Required=false)]
        public string ClusterVpcId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsEnterpriseSecurityGroup")]
        [Validation(Required=false)]
        public bool? IsEnterpriseSecurityGroup { get; set; }

        [NameInMap("Manager")]
        [Validation(Required=false)]
        public CreateClusterRequestManager Manager { get; set; }
        public class CreateClusterRequestManager : TeaModel {
            [NameInMap("DNS")]
            [Validation(Required=false)]
            public CreateClusterRequestManagerDNS DNS { get; set; }
            public class CreateClusterRequestManagerDNS : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>NIS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2.31</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("DirectoryService")]
            [Validation(Required=false)]
            public CreateClusterRequestManagerDirectoryService DirectoryService { get; set; }
            public class CreateClusterRequestManagerDirectoryService : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>NIS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2.31</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("ManagerNode")]
            [Validation(Required=false)]
            public NodeTemplate ManagerNode { get; set; }

            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public CreateClusterRequestManagerScheduler Scheduler { get; set; }
            public class CreateClusterRequestManagerScheduler : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>SLURM</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22.05.8</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MaxCoreCount")]
        [Validation(Required=false)]
        public int? MaxCoreCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MaxCount")]
        [Validation(Required=false)]
        public int? MaxCount { get; set; }

        [NameInMap("Queues")]
        [Validation(Required=false)]
        public List<QueueTemplate> Queues { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sg-bp13n61xsydodfyg****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("SharedStorages")]
        [Validation(Required=false)]
        public List<SharedStorageTemplate> SharedStorages { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTags> Tags { get; set; }
        public class CreateClusterRequestTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ClusterId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ehpc-hz-******</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
