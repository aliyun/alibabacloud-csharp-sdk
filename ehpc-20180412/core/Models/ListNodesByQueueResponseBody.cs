// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListNodesByQueueResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of nodes.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public ListNodesByQueueResponseBodyNodes Nodes { get; set; }
        public class ListNodesByQueueResponseBodyNodes : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<ListNodesByQueueResponseBodyNodesNodeInfo> NodeInfo { get; set; }
            public class ListNodesByQueueResponseBodyNodesNodeInfo : TeaModel {
                /// <summary>
                /// <para>The time when the node was added to the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-18T13:24:29.000Z</para>
                /// </summary>
                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public string AddTime { get; set; }

                /// <summary>
                /// <para>The mode in which the node is created. Valid values:</para>
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
                /// <para>Indicates whether the node was created by using E-HPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CreatedByEhpc")]
                [Validation(Required=false)]
                public bool? CreatedByEhpc { get; set; }

                /// <summary>
                /// <para>Indicates whether the subscription node has expired. If the node is a pay-as-you-go node, false is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// <para>The time when the subscription instance expires. If the node is a pay-as-you-go node, a null value is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-09-18T13:24:29.000Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>compute0</para>
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// <para>Indicates whether Hyper-Threading (HT) is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HtEnabled")]
                [Validation(Required=false)]
                public bool? HtEnabled { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp13p7vlcb1uihfv****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos_7_02_64_20G_alibase_20170818****</para>
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
                /// <para>The private IP address of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>172.168.**.**</c></para>
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// <para>The location where the node is deployed. Valid values:</para>
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
                /// <para>The public IP address of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>10.34.**.**</c></para>
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
                /// <para>The preemption policy of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NoSpot: The instance is created as a pay-as-you-go instance.</description></item>
                /// <item><description>SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.</description></item>
                /// <item><description>SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.</description></item>
                /// </list>
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
                /// <item><description>uninit: The node is not initialized.</description></item>
                /// <item><description>init: The node is being initialized.</description></item>
                /// <item><description>ready: The node is ready.</description></item>
                /// <item><description>running: The cluster is running.</description></item>
                /// <item><description>exception: An exception occurred on the node.</description></item>
                /// <item><description>untracking: The node is not added to the cluster.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>untracking</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The number of all resources in the cluster.</para>
                /// </summary>
                [NameInMap("TotalResources")]
                [Validation(Required=false)]
                public ListNodesByQueueResponseBodyNodesNodeInfoTotalResources TotalResources { get; set; }
                public class ListNodesByQueueResponseBodyNodesNodeInfoTotalResources : TeaModel {
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
                    /// <para>The total number of GPU cards. Unit: cards.</para>
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
                public ListNodesByQueueResponseBodyNodesNodeInfoUsedResources UsedResources { get; set; }
                public class ListNodesByQueueResponseBodyNodesNodeInfoUsedResources : TeaModel {
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
                    /// <para>The total number of GPU cards. Unit: cards.</para>
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
                    /// <para>1</para>
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
                /// <para>The version of the E-HPC client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.64</para>
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
                /// <para>The zone ID of the node.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B405FF19-2D5F-4489-A84C-BC15CC1B24BD</para>
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
