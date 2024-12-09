// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the nodes.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<ListNodesResponseBodyNodes> Nodes { get; set; }
        public class ListNodesResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>The time when the node was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T06:22:02.000Z</para>
            /// </summary>
            [NameInMap("AddTime")]
            [Validation(Required=false)]
            public string AddTime { get; set; }

            [NameInMap("DeploymentSetId")]
            [Validation(Required=false)]
            public string DeploymentSetId { get; set; }

            /// <summary>
            /// <para>The time when the node expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T06:22:02.000Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The hostname of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edas.cn-shanghai.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

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
            /// <para>The instance ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp15707mys2rsy0j****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The image ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>centos_7_06_64_20G_alibase_20190711.vhd</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The instance type of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The VPC IP address of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para><c>172.16.**.**</c></para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// <para>Indicates whether deletion protection is enabled for the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("KeepAlive")]
            [Validation(Required=false)]
            public bool? KeepAlive { get; set; }

            /// <summary>
            /// <para>The public IP address of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para><c>172.16.**.**</c></para>
            /// </summary>
            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }

            /// <summary>
            /// <para>The name of the queue to which the node belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autoque3</para>
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The bidding policy of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NoSpot: The instances of the compute node are pay-as-you-go instances.</description></item>
            /// <item><description>SpotWithPriceLimit: The instances are created as preemptible instances with a user-defined maximum hourly price.</description></item>
            /// <item><description>SpotAsPriceGo: The node is a preemptible instance for which the market price at the time of purchase is automatically used as the bidding price.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>The node state in the scheduler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("StateInSched")]
            [Validation(Required=false)]
            public string StateInSched { get; set; }

            /// <summary>
            /// <para>The node state. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>uninit: The node is being installed.</description></item>
            /// <item><description>initing: The node is being initialized.</description></item>
            /// <item><description>running: The node is running.</description></item>
            /// <item><description>releasing: The node is being released.</description></item>
            /// <item><description>stopped: The node is stopped.</description></item>
            /// <item><description>exception: The node has run into an exception.</description></item>
            /// <item><description>untracking: The node is not added to the cluster.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The hardware configurations of the node.</para>
            /// </summary>
            [NameInMap("TotalResources")]
            [Validation(Required=false)]
            public ListNodesResponseBodyNodesTotalResources TotalResources { get; set; }
            public class ListNodesResponseBodyNodesTotalResources : TeaModel {
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
                /// <para>The amount of memory. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

            }

            /// <summary>
            /// <para>The vSwitch ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1e47optm9g58zcu****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
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

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
