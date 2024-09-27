// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the nodes in the cluster.</para>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<DescribeClusterNodesResponseBodyNodes> Nodes { get; set; }
        public class DescribeClusterNodesResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>The time when the node was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-08-25T11:25:35+08:00</para>
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
            /// <para>The expiration date of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2099-12-31T23:59:00+08:00</para>
            /// </summary>
            [NameInMap("expired_time")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The name of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iZ2vcckdmxp7u0urj2k****</para>
            /// </summary>
            [NameInMap("host_name")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The ID of the system image that is used by the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_2_1903_x64_20G_alibase_20200529.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The billing method of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PrePaid</c>: the subscription billing method. If the value is PrePaid, make sure that you have a sufficient balance or credit in your account. Otherwise, an <c>InvalidPayMethod</c> error is returned.</description></item>
            /// <item><description><c>PostPaid</c>: the pay-as-you-go billing method.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2vcckdmxp7u0urj2****</para>
            /// </summary>
            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance on which the node is deployed.</para>
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
            /// <item><description>Master: master node</description></item>
            /// <item><description>Worker: worker node</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Worker</para>
            /// </summary>
            [NameInMap("instance_role")]
            [Validation(Required=false)]
            public string InstanceRole { get; set; }

            /// <summary>
            /// <para>The status of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("instance_status")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The type of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5.xlarge</para>
            /// </summary>
            [NameInMap("instance_type")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The ECS instance family of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5</para>
            /// </summary>
            [NameInMap("instance_type_family")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            /// <summary>
            /// <para>The IP address of the node.</para>
            /// </summary>
            [NameInMap("ip_address")]
            [Validation(Required=false)]
            public List<string> IpAddress { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance on which the node is deployed is provided by Alibaba Cloud. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: The instance is provided by Alibaba Cloud.</description></item>
            /// <item><description><c>false</c>: The instance is not provided by Alibaba Cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("is_aliyun_node")]
            [Validation(Required=false)]
            public bool? IsAliyunNode { get; set; }

            /// <summary>
            /// <para>The name of the node. This name is the identifier of the node in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chengdu.192.168.0.36</para>
            /// </summary>
            [NameInMap("node_name")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>Indicates whether the node is ready. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Ready</c>: The node is ready.</description></item>
            /// <item><description><c>NotReady</c>: The node is not ready.</description></item>
            /// <item><description><c>Unknown</c>: The status of the node is unknown.</description></item>
            /// <item><description><c>Offline</c>: The node is offline.</description></item>
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
            /// <para>Indicates how the node is initialized. A node can be manually created or created by using Resource Orchestration Service (ROS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ess_attach</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The type of preemptible instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NoSpot: a non-preemptible instance.</description></item>
            /// <item><description>SpotWithPriceLimit: a preemptible instance that is configured with the highest bid price.</description></item>
            /// <item><description>SpotAsPriceGo: a preemptible instance for which the system automatically bids based on the current market price.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>The status of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>pending</c>: The node is being created.</description></item>
            /// <item><description><c>running</c>: The node is running.</description></item>
            /// <item><description><c>starting</c>: The node is being started.</description></item>
            /// <item><description><c>stopping</c>: The node is being stopped.</description></item>
            /// <item><description><c>stopped</c>: The node is stopped.</description></item>
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
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
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
