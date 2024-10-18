// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of clusters.</para>
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<ListClustersResponseBodyClusters> Clusters { get; set; }
        public class ListClustersResponseBodyClusters : TeaModel {
            /// <summary>
            /// <para>The information about installed software in the cluster.</para>
            /// </summary>
            [NameInMap("AdditionalPackages")]
            [Validation(Required=false)]
            public List<ListClustersResponseBodyClustersAdditionalPackages> AdditionalPackages { get; set; }
            public class ListClustersResponseBodyClustersAdditionalPackages : TeaModel {
                /// <summary>
                /// <para>The software name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gromacs</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The software version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024.1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The information about the addons in the cluster.</para>
            /// </summary>
            [NameInMap("Addons")]
            [Validation(Required=false)]
            public List<ListClustersResponseBodyClustersAddons> Addons { get; set; }
            public class ListClustersResponseBodyClustersAddons : TeaModel {
                /// <summary>
                /// <para>The addon ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Login-1.0-W2g****</para>
                /// </summary>
                [NameInMap("AddonId")]
                [Validation(Required=false)]
                public string AddonId { get; set; }

                /// <summary>
                /// <para>The addon description.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The addon label.</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

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
                /// </summary>
                [NameInMap("ResourcesSpec")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersAddonsResourcesSpec ResourcesSpec { get; set; }
                public class ListClustersResponseBodyClustersAddonsResourcesSpec : TeaModel {
                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-bp1bg85d2q6laic8****</para>
                    /// </summary>
                    [NameInMap("EcsInstanceId")]
                    [Validation(Required=false)]
                    public string EcsInstanceId { get; set; }

                    /// <summary>
                    /// <para>The Elastic IP Address (EIP) ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eip-bp1vi9124tbx1g3kr****</para>
                    /// </summary>
                    [NameInMap("EipInstanceId")]
                    [Validation(Required=false)]
                    public string EipInstanceId { get; set; }

                }

                /// <summary>
                /// <para>The information about the addon services.</para>
                /// </summary>
                [NameInMap("ServicesSpec")]
                [Validation(Required=false)]
                public List<ListClustersResponseBodyClustersAddonsServicesSpec> ServicesSpec { get; set; }
                public class ListClustersResponseBodyClustersAddonsServicesSpec : TeaModel {
                    /// <summary>
                    /// <para>The service access type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>URL</para>
                    /// </summary>
                    [NameInMap("ServiceAccessType")]
                    [Validation(Required=false)]
                    public string ServiceAccessType { get; set; }

                    /// <summary>
                    /// <para>The service access URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://47.96.xx.xx:12008">https://47.96.xx.xx:12008</a></para>
                    /// </summary>
                    [NameInMap("ServiceAccessUrl")]
                    [Validation(Required=false)]
                    public string ServiceAccessUrl { get; set; }

                    /// <summary>
                    /// <para>The service name.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Web Portal</para>
                    /// </summary>
                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

                /// <summary>
                /// <para>The addon state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
            /// <para>The time when the cluster was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-06T12:43:01.000Z</para>
            /// </summary>
            [NameInMap("ClusterCreateTime")]
            [Validation(Required=false)]
            public string ClusterCreateTime { get; set; }

            /// <summary>
            /// <para>The logon credential type of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>password: requires passwords for logons.</description></item>
            /// <item><description>keypair: requires key pairs for logons.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ClusterCredentials")]
            [Validation(Required=false)]
            public List<string> ClusterCredentials { get; set; }

            /// <summary>
            /// <para>The post-processing script used by the cluster.</para>
            /// </summary>
            [NameInMap("ClusterCustomConfiguration")]
            [Validation(Required=false)]
            public ListClustersResponseBodyClustersClusterCustomConfiguration ClusterCustomConfiguration { get; set; }
            public class ListClustersResponseBodyClustersClusterCustomConfiguration : TeaModel {
                /// <summary>
                /// <para>The parameters of the post-processing script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public string Args { get; set; }

                /// <summary>
                /// <para>The link to the post-processing script.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxxxx">https://xxxxx</a></para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public string Script { get; set; }

            }

            /// <summary>
            /// <para>The cluster description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Demo</para>
            /// </summary>
            [NameInMap("ClusterDescription")]
            [Validation(Required=false)]
            public string ClusterDescription { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ehpc-hz-VMKe******</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The deployment type of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Integrated: public cloud</description></item>
            /// <item><description>Hybrid: hybrid cloud</description></item>
            /// <item><description>Custom: a custom cluster</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Integrated</para>
            /// </summary>
            [NameInMap("ClusterMode")]
            [Validation(Required=false)]
            public string ClusterMode { get; set; }

            /// <summary>
            /// <para>The time when the cluster was modified. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-06T12:43:01.000Z</para>
            /// </summary>
            [NameInMap("ClusterModifyTime")]
            [Validation(Required=false)]
            public string ClusterModifyTime { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>slurm22.05.8-cluster-20240227</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The cluster state. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>uninit: The cluster is being installed.</description></item>
            /// <item><description>creating: The cluster is being created.</description></item>
            /// <item><description>initing: The cluster is being initialized.</description></item>
            /// <item><description>running: The cluster is running.</description></item>
            /// <item><description>Releasing: The cluster is being released.</description></item>
            /// <item><description>stopping: The cluster is being stopped.</description></item>
            /// <item><description>stopped: The cluster is stopped.</description></item>
            /// <item><description>exception: The cluster has run into an exception.</description></item>
            /// <item><description>pending: The cluster is waiting to be configured.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("ClusterStatus")]
            [Validation(Required=false)]
            public string ClusterStatus { get; set; }

            /// <summary>
            /// <para>The vCPU-hour usage of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("ClusterUsedCoreTime")]
            [Validation(Required=false)]
            public float? ClusterUsedCoreTime { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch used by the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-f8za5p0mwzgdu3wgx****</para>
            /// </summary>
            [NameInMap("ClusterVSwitchId")]
            [Validation(Required=false)]
            public string ClusterVSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) used by the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-m5efjevmclc0xdmys****</para>
            /// </summary>
            [NameInMap("ClusterVpcId")]
            [Validation(Required=false)]
            public string ClusterVpcId { get; set; }

            /// <summary>
            /// <para>Indicates whether deletion protection is enabled for the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>The Elastic High Performance Computing (E-HPC) version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.0</para>
            /// </summary>
            [NameInMap("EhpcVersion")]
            [Validation(Required=false)]
            public string EhpcVersion { get; set; }

            /// <summary>
            /// <para>The configurations of the cluster management node.</para>
            /// </summary>
            [NameInMap("Manager")]
            [Validation(Required=false)]
            public ListClustersResponseBodyClustersManager Manager { get; set; }
            public class ListClustersResponseBodyClustersManager : TeaModel {
                /// <summary>
                /// <para>The configurations of the domain name resolution service.</para>
                /// </summary>
                [NameInMap("DNS")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersManagerDNS DNS { get; set; }
                public class ListClustersResponseBodyClustersManagerDNS : TeaModel {
                    /// <summary>
                    /// <para>The resolution type.</para>
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
                /// <para>The configurations of the directory service.</para>
                /// </summary>
                [NameInMap("DirectoryService")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersManagerDirectoryService DirectoryService { get; set; }
                public class ListClustersResponseBodyClustersManagerDirectoryService : TeaModel {
                    /// <summary>
                    /// <para>The type of the domain account.</para>
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
                /// <para>The configurations of the scheduler service.</para>
                /// </summary>
                [NameInMap("Scheduler")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersManagerScheduler Scheduler { get; set; }
                public class ListClustersResponseBodyClustersManagerScheduler : TeaModel {
                    /// <summary>
                    /// <para>The scheduler type.</para>
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
            /// <para>The maximum total number of vCPUs used by the compute nodes that can be managed by the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("MaxCoreCount")]
            [Validation(Required=false)]
            public long? MaxCoreCount { get; set; }

            /// <summary>
            /// <para>The maximum number of compute nodes that can be managed by the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("MaxCount")]
            [Validation(Required=false)]
            public long? MaxCount { get; set; }

            /// <summary>
            /// <para>The node statistics of the cluster.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public ListClustersResponseBodyClustersNodes Nodes { get; set; }
            public class ListClustersResponseBodyClustersNodes : TeaModel {
                /// <summary>
                /// <para>The number of malfunctioning compute nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AbnormalCounts")]
                [Validation(Required=false)]
                public int? AbnormalCounts { get; set; }

                /// <summary>
                /// <para>The number of compute nodes that are being created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CreatingCounts")]
                [Validation(Required=false)]
                public int? CreatingCounts { get; set; }

                /// <summary>
                /// <para>The number of running compute nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RunningCounts")]
                [Validation(Required=false)]
                public int? RunningCounts { get; set; }

            }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxazb4ph****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the security group used by the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp13n61xsydodfyg****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The user attribute information of the cluster.</para>
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public ListClustersResponseBodyClustersUsers Users { get; set; }
            public class ListClustersResponseBodyClustersUsers : TeaModel {
                /// <summary>
                /// <para>The number of ordinary users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("NormalCounts")]
                [Validation(Required=false)]
                public int? NormalCounts { get; set; }

                /// <summary>
                /// <para>The number of administrators.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SudoCounts")]
                [Validation(Required=false)]
                public int? SudoCounts { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
