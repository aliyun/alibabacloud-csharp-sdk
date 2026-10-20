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
            /// <para>The time when the node was created. The time follows the ISO 8601 standard and includes the time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-16T07:28:00Z</para>
            /// </summary>
            [NameInMap("creation_time")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The error message returned when the node was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error***</para>
            /// </summary>
            [NameInMap("error_message")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The time when the node expires. The time follows the ISO 8601 standard and includes the time zone.</para>
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
            /// <para>The role of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Master: the master node of the cluster.</description></item>
            /// <item><description>Worker: the worker node of the cluster.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Worker</para>
            /// </summary>
            [NameInMap("instance_role")]
            [Validation(Required=false)]
            public string InstanceRole { get; set; }

            /// <summary>
            /// <para>The ECS instance status of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Pending</c>: the instance is being created.</description></item>
            /// <item><description><c>Running</c>: the instance is running.</description></item>
            /// <item><description><c>Starting</c>: the instance is starting.</description></item>
            /// <item><description><c>Stopping</c>: the instance is stopping.</description></item>
            /// <item><description><c>Stopped</c>: the instance is stopped.</description></item>
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
            /// <para>Specifies whether the node is an Alibaba Cloud instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: the node is an Alibaba Cloud instance.</description></item>
            /// <item><description><c>false</c>: the node is not an Alibaba Cloud instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("is_aliyun_node")]
            [Validation(Required=false)]
            public bool? IsAliyunNode { get; set; }

            /// <summary>
            /// <para>The name of the node, which is the node identifier in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chengdu.192.168xx.xx</para>
            /// </summary>
            [NameInMap("node_name")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>Specifies whether the node is ready. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Ready</c>: the node is ready.</description></item>
            /// <item><description><c>NotReady</c>: the node is not ready.</description></item>
            /// <item><description><c>Unknown</c>: the status is unknown.</description></item>
            /// <item><description><c>Offline</c>: the node is offline.</description></item>
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
            /// <para>The method used to initialize the node, such as manual creation or creation by Resource Orchestration Service (ROS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ess</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The type of the spot instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NoSpot: the instance is not a spot instance.</description></item>
            /// <item><description>SpotWithPriceLimit: the instance is a spot instance with a maximum price limit.</description></item>
            /// <item><description>SpotAsPriceGo: the instance is a spot instance whose price is automatically set based on the current market price.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>The running state of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>pending</c>: the node is being created.</description></item>
            /// <item><description><c>running</c>: the node is running.</description></item>
            /// <item><description><c>starting</c>: the node is starting.</description></item>
            /// <item><description><c>stopping</c>: the node is stopping.</description></item>
            /// <item><description><c>stopped</c>: the node is stopped.</description></item>
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
            /// <para>The maximum number of records to return per page.</para>
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
