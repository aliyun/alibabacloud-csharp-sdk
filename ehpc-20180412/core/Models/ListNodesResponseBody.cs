// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of nodes.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public ListNodesResponseBodyNodes Nodes { get; set; }
        public class ListNodesResponseBodyNodes : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyNodesNodeInfo> NodeInfo { get; set; }
            public class ListNodesResponseBodyNodesNodeInfo : TeaModel {
                /// <summary>
                /// <para>The time when the node is added to the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-09T06:22:02.000Z</para>
                /// </summary>
                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public string AddTime { get; set; }

                /// <summary>
                /// <para>The mode in which the compute nodes are added. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>manual: The node is manually added.</description></item>
                /// <item><description>autoscale: The node is automatically added.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>manual</para>
                /// </summary>
                [NameInMap("CreateMode")]
                [Validation(Required=false)]
                public string CreateMode { get; set; }

                /// <summary>
                /// <para>Indicates whether the node is created by using E-HPC.</para>
                /// <list type="bullet">
                /// <item><description>true: The node is created by using E-HPC.</description></item>
                /// <item><description>false: The node is not created by using E-HPC.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CreatedByEhpc")]
                [Validation(Required=false)]
                public bool? CreatedByEhpc { get; set; }

                /// <summary>
                /// <para>Indicates whether the subscription node expired. For a pay-as-you-go node, false is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// <para>The time when the subscription node expires. For a pay-as-you-go node, a null value is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-09T06:22:02.000Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The name of the task node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-HostName</para>
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// <para>Indicates whether hyper-threading is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HtEnabled")]
                [Validation(Required=false)]
                public bool? HtEnabled { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp15707mys2rsy0j****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The ID of the custom image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos_7_06_64_20G_alibase_20190711.vhd</para>
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
                /// <para>The instance types of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.c5.large</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The IP address of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>172.16.**.**</c></para>
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// <para>The location where the node is deployed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OnPremise: The node is deployed on your data center.</description></item>
                /// <item><description>PublicCloud: The node is deployed on the public cloud.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PublicCloud</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The reason why the node is locked. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>financial: The instance is locked due to overdue payments.</description></item>
                /// <item><description>security: The node is locked for security reasons.</description></item>
                /// <item><description>recycling: The preemptible instance is locked and pending release.</description></item>
                /// <item><description>dedicatedhostfinancial: The ECS instance is locked due to overdue payments of the dedicated host.</description></item>
                /// </list>
                /// <para>By default, an empty string is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>financial</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The public IP address of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>172.16.**.**</c></para>
                /// </summary>
                [NameInMap("PublicIpAddress")]
                [Validation(Required=false)]
                public string PublicIpAddress { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The type of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Scheduler: primary scheduling node</description></item>
                /// <item><description>SchedulerBackup: secondary scheduling node</description></item>
                /// <item><description>Account: primary domain server node</description></item>
                /// <item><description>AccountBackup: secondary domain server node</description></item>
                /// <item><description>Login: logon node</description></item>
                /// <item><description>Compute: compute node</description></item>
                /// </list>
                /// <para>Scheduling nodes and domain server nodes are management nodes.</para>
                /// </summary>
                [NameInMap("Roles")]
                [Validation(Required=false)]
                public ListNodesResponseBodyNodesNodeInfoRoles Roles { get; set; }
                public class ListNodesResponseBodyNodesNodeInfoRoles : TeaModel {
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public List<string> Role { get; set; }

                }

                /// <summary>
                /// <para>The bidding method of the compute nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NoSpot</para>
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// <para>The status of the node displayed on the scheduler. The status varies with the scheduler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("StateInSched")]
                [Validation(Required=false)]
                public string StateInSched { get; set; }

                /// <summary>
                /// <para>The status of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>uninit: The node is being installed.</description></item>
                /// <item><description>exception: An exception occurred on the node.</description></item>
                /// <item><description>running: The node is running.</description></item>
                /// <item><description>initing: The node is being initialized.</description></item>
                /// <item><description>releasing: The node is being released.</description></item>
                /// <item><description>untracking: The node is not added to the cluster.</description></item>
                /// <item><description>stopped: The node is stopped.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The statistics of the resources used by the node.</para>
                /// </summary>
                [NameInMap("TotalResources")]
                [Validation(Required=false)]
                public ListNodesResponseBodyNodesNodeInfoTotalResources TotalResources { get; set; }
                public class ListNodesResponseBodyNodesNodeInfoTotalResources : TeaModel {
                    /// <summary>
                    /// <para>The number of vCPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// <para>The number of GPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Gpu")]
                    [Validation(Required=false)]
                    public int? Gpu { get; set; }

                    /// <summary>
                    /// <para>The memory capacity. Unit: GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1024</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                }

                /// <summary>
                /// <para>The usage of the compute nodes in the cluster. For other types of nodes, an empty value is returned.</para>
                /// </summary>
                [NameInMap("UsedResources")]
                [Validation(Required=false)]
                public ListNodesResponseBodyNodesNodeInfoUsedResources UsedResources { get; set; }
                public class ListNodesResponseBodyNodesNodeInfoUsedResources : TeaModel {
                    /// <summary>
                    /// <para>The number of vCPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// <para>The number of GPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Gpu")]
                    [Validation(Required=false)]
                    public int? Gpu { get; set; }

                    /// <summary>
                    /// <para>The memory capacity. Unit: GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1e47optm9g58zcu****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The version of the client that is used for the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.78</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The VPC ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1gnu8br4ay7beb2w****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number returned.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89A1AC0F-4A6C-4F3D-98F9-BEF9A823****</para>
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
