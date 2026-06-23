// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of node details.</para>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<DescribeClusterNodesResponseBodyNodes> Nodes { get; set; }
        public class DescribeClusterNodesResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>The time when the node was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-16T07:28:00Z</para>
            /// </summary>
            [NameInMap("creation_time")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The error message generated when the node was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error***</para>
            /// </summary>
            [NameInMap("error_message")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The time when the node expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2099-12-31T15:59:00Z</para>
            /// </summary>
            [NameInMap("expired_time")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The hostname of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iZ2vcckdmxp7u0urj2k****</para>
            /// </summary>
            [NameInMap("host_name")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The ID of the system image used by the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20241218.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The billing method of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PrePaid</c>: subscription.</description></item>
            /// <item><description><c>PostPaid</c>: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>The instance ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2vcckdmxp7u0urj2****</para>
            /// </summary>
            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the node in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>worker-k8s-for-cs-c5cdf7e3938bc4f8eb0e44b21a80f****</para>
            /// </summary>
            [NameInMap("instance_name")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The role type of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Master: a master node of the cluster.</description></item>
            /// <item><description>Worker: a worker node of the cluster.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Worker</para>
            /// </summary>
            [NameInMap("instance_role")]
            [Validation(Required=false)]
            public string InstanceRole { get; set; }

            /// <summary>
            /// <para>The ECS status of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Pending</c>: being created.</description></item>
            /// <item><description><c>Running</c>: running.</description></item>
            /// <item><description><c>Starting</c>: being started.</description></item>
            /// <item><description><c>Stopping</c>: being stopped.</description></item>
            /// <item><description><c>Stopped</c>: stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("instance_status")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The node specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5.xlarge</para>
            /// </summary>
            [NameInMap("instance_type")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The name of the ECS instance family to which the node belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5</para>
            /// </summary>
            [NameInMap("instance_type_family")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            /// <summary>
            /// <para>The IP addresses of the node.</para>
            /// </summary>
            [NameInMap("ip_address")]
            [Validation(Required=false)]
            public List<string> IpAddress { get; set; }

            /// <summary>
            /// <para>Indicates whether the node is an Alibaba Cloud instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: The node is an Alibaba Cloud instance.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The node is not an Alibaba Cloud instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("is_aliyun_node")]
            [Validation(Required=false)]
            public bool? IsAliyunNode { get; set; }

            /// <summary>
            /// <para>The node name, which is the identifier of the node in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chengdu.192.168xx.xx</para>
            /// </summary>
            [NameInMap("node_name")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>Indicates whether the node is ready. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Ready</c>: The node is ready.</para>
            /// </description></item>
            /// <item><description><para><c>NotReady</c>: The node is not ready.</para>
            /// </description></item>
            /// <item><description><para><c>Unknown</c>: The node status is unknown.</para>
            /// </description></item>
            /// <item><description><para><c>Offline</c>: The node is offline.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ready</para>
            /// </summary>
            [NameInMap("node_status")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            /// <summary>
            /// <para>The node pool ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np0794239424a84eb7a95327369d56****</para>
            /// </summary>
            [NameInMap("nodepool_id")]
            [Validation(Required=false)]
            public string NodepoolId { get; set; }

            /// <summary>
            /// <para>The method used to initialize the node, such as manual creation or Resource Orchestration Service (ROS) creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ess</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The spot instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NoSpot: a non-spot instance.</description></item>
            /// <item><description>SpotWithPriceLimit: a spot instance with a price limit.</description></item>
            /// <item><description>SpotAsPriceGo: a spot instance priced at the market price at the time of purchase.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>The running status of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>pending</c>: being created.</para>
            /// </description></item>
            /// <item><description><para><c>running</c>: running.</para>
            /// </description></item>
            /// <item><description><para><c>starting</c>: being started.</para>
            /// </description></item>
            /// <item><description><para><c>stopping</c>: being stopped.</para>
            /// </description></item>
            /// <item><description><para><c>stopped</c>: stopped.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public DescribeClusterNodesResponseBodyPage Page { get; set; }
        public class DescribeClusterNodesResponseBodyPage : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The maximum number of records that can be displayed on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
