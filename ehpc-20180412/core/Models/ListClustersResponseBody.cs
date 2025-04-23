// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of clusters.</para>
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public ListClustersResponseBodyClusters Clusters { get; set; }
        public class ListClustersResponseBodyClusters : TeaModel {
            [NameInMap("ClusterInfoSimple")]
            [Validation(Required=false)]
            public List<ListClustersResponseBodyClustersClusterInfoSimple> ClusterInfoSimple { get; set; }
            public class ListClustersResponseBodyClustersClusterInfoSimple : TeaModel {
                /// <summary>
                /// <para>The server type of the account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>nis</description></item>
                /// <item><description>ldap</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>nis</para>
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// <para>The operating system tag of the base image. The tag was used only by the management node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS_7.2_64</para>
                /// </summary>
                [NameInMap("BaseOsTag")]
                [Validation(Required=false)]
                public string BaseOsTag { get; set; }

                /// <summary>
                /// <para>The version of the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.64</para>
                /// </summary>
                [NameInMap("ClientVersion")]
                [Validation(Required=false)]
                public string ClientVersion { get; set; }

                /// <summary>
                /// <para>The maximum hourly price for the ECS instance under the compute node. The return value can be accurate to three decimal places.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.034</para>
                /// </summary>
                [NameInMap("ComputeSpotPriceLimit")]
                [Validation(Required=false)]
                public float? ComputeSpotPriceLimit { get; set; }

                /// <summary>
                /// <para>The bidding method of the compute nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NoSpot: The instances of the compute node are pay-as-you-go instances.</description></item>
                /// <item><description>SpotWithPriceLimit: The instances of the compute node are preemptible instances. These types of instances have a specified maximum hourly price.</description></item>
                /// <item><description>SpotAsPriceGo: The instances of the compute node are preemptible instances. The price of these instances is based on the current market price.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NoSpot</para>
                /// </summary>
                [NameInMap("ComputeSpotStrategy")]
                [Validation(Required=false)]
                public string ComputeSpotStrategy { get; set; }

                /// <summary>
                /// <para>The information about compute nodes.</para>
                /// </summary>
                [NameInMap("Computes")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersClusterInfoSimpleComputes Computes { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleComputes : TeaModel {
                    /// <summary>
                    /// <para>The number of abnormal nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ExceptionCount")]
                    [Validation(Required=false)]
                    public int? ExceptionCount { get; set; }

                    /// <summary>
                    /// <para>The number of normal nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NormalCount")]
                    [Validation(Required=false)]
                    public int? NormalCount { get; set; }

                    /// <summary>
                    /// <para>The number of nodes that are being used in the queue. This includes those that are being initialized, installed, or released.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("OperatingCount")]
                    [Validation(Required=false)]
                    public int? OperatingCount { get; set; }

                    /// <summary>
                    /// <para>The number of stopped nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("StoppedCount")]
                    [Validation(Required=false)]
                    public int? StoppedCount { get; set; }

                    /// <summary>
                    /// <para>The total number of nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public int? Total { get; set; }

                }

                /// <summary>
                /// <para>The number of compute nodes in the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The time when the instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-30T07:39:20.000Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The mode in which the cluster was deployed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Standard: An account node, a scheduling node, a logon node, and multiple compute nodes are separately deployed.</description></item>
                /// <item><description>Advanced: Two high availability (HA) account nodes, two HA scheduler nodes, one logon node, and multiple compute nodes are separately deployed.</description></item>
                /// <item><description>Simple: A management node, a logon node, and multiple compute nodes are deployed. The management node consists of an account node and a scheduling node. The logon node and compute nodes are separately deployed.</description></item>
                /// <item><description>Tiny: A management node and multiple compute nodes are deployed. The management node consists of an account node, a scheduling node, and a logon node. The compute nodes are separately deployed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("DeployMode")]
                [Validation(Required=false)]
                public string DeployMode { get; set; }

                /// <summary>
                /// <para>The description of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>clusterdescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The version of E-HPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("EhpcVersion")]
                [Validation(Required=false)]
                public string EhpcVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether plug-ins were used in the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Plug-ins are used.</description></item>
                /// <item><description>false: Plug-ins are not used.</description></item>
                /// </list>
                /// <para>Default value: false</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HasPlugin")]
                [Validation(Required=false)]
                public bool? HasPlugin { get; set; }

                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ehpc-hz-jeJki6****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The ID of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wi_1607_x64_dtc_zh_40G_alibase****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The type of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system: public image</description></item>
                /// <item><description>self: custom image</description></item>
                /// <item><description>others: shared image</description></item>
                /// <item><description>marketplace: Alibaba Cloud Marketplace image</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                /// <summary>
                /// <para>The billing method of the nodes in the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PostPaid: pay-as-you-go</description></item>
                /// <item><description>PrePaid: subscription</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// <para>The instance type of the compute nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.n1.tiny</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>Indicates whether a scaling group was enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: A scaling group is enabled.</description></item>
                /// <item><description>false: No scaling group is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsComputeEss")]
                [Validation(Required=false)]
                public bool? IsComputeEss { get; set; }

                /// <summary>
                /// <para>The location where the cluster was deployed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OnPremise: The cluster is deployed on a hybrid cloud.</description></item>
                /// <item><description>PublicCloud: The cluster is deployed on a public cloud.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PublicCloud</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The list of logon nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Id&quot;: &quot;i-bp13x4is8pvdhws7e****&quot;}</para>
                /// </summary>
                [NameInMap("LoginNodes")]
                [Validation(Required=false)]
                public string LoginNodes { get; set; }

                /// <summary>
                /// <para>The list of management nodes.</para>
                /// </summary>
                [NameInMap("Managers")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersClusterInfoSimpleManagers Managers { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleManagers : TeaModel {
                    /// <summary>
                    /// <para>The number of abnormal nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ExceptionCount")]
                    [Validation(Required=false)]
                    public int? ExceptionCount { get; set; }

                    /// <summary>
                    /// <para>The number of normal nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NormalCount")]
                    [Validation(Required=false)]
                    public int? NormalCount { get; set; }

                    /// <summary>
                    /// <para>The number of nodes that are being used in the queue. This includes those that are being initialized, installed, or released.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("OperatingCount")]
                    [Validation(Required=false)]
                    public int? OperatingCount { get; set; }

                    /// <summary>
                    /// <para>The number of stopped nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("StoppedCount")]
                    [Validation(Required=false)]
                    public int? StoppedCount { get; set; }

                    /// <summary>
                    /// <para>The total number of management nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public int? Total { get; set; }

                }

                /// <summary>
                /// <para>The name of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The prefix of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("NodePrefix")]
                [Validation(Required=false)]
                public string NodePrefix { get; set; }

                /// <summary>
                /// <para>The suffix of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("NodeSuffix")]
                [Validation(Required=false)]
                public string NodeSuffix { get; set; }

                /// <summary>
                /// <para>The operating system tag of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS_7.2_64</para>
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The resource group ID.You can call the ListResourceGroups operation to query the IDs of resource groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxazb4ph****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The type of the scheduler. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>pbs</description></item>
                /// <item><description>slurm</description></item>
                /// <item><description>opengridscheduler</description></item>
                /// <item><description>deadline</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pbs</para>
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                /// <summary>
                /// <para>The status of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>uninit: The cluster is not initialized.</description></item>
                /// <item><description>creating: The cluster is being created.</description></item>
                /// <item><description>init: The cluster is being initialized.</description></item>
                /// <item><description>running: The cluster is running.</description></item>
                /// <item><description>exception: The cluster encounters an exception.</description></item>
                /// <item><description>releasing: The cluster is being released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The statistics of all resources in the cluster.</para>
                /// </summary>
                [NameInMap("TotalResources")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersClusterInfoSimpleTotalResources TotalResources { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleTotalResources : TeaModel {
                    /// <summary>
                    /// <para>The number of CPU cores. Unit: cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// <para>The number of GPU cards. Unit: cards.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Gpu")]
                    [Validation(Required=false)]
                    public int? Gpu { get; set; }

                    /// <summary>
                    /// <para>The memory size. Unit: MiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1024</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                }

                /// <summary>
                /// <para>The number of consumed resources in the cluster.</para>
                /// </summary>
                [NameInMap("UsedResources")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersClusterInfoSimpleUsedResources UsedResources { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleUsedResources : TeaModel {
                    /// <summary>
                    /// <para>The number of CPU cores. Unit: cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// <para>The number of GPU cards. Unit: cards.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Gpu")]
                    [Validation(Required=false)]
                    public int? Gpu { get; set; }

                    /// <summary>
                    /// <para>The memory size. Unit: MiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1024</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1lfcjbfb099rrjn****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-b3f3edefefeep0760yju****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-c</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
