// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodesResponseBody : TeaModel {
        /// <summary>
        /// The details of the nodes that are returned.
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<DescribeClusterNodesResponseBodyNodes> Nodes { get; set; }
        public class DescribeClusterNodesResponseBodyNodes : TeaModel {
            /// <summary>
            /// The time when the node was created.
            /// </summary>
            [NameInMap("creation_time")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The error message that was generated when the node was created.
            /// </summary>
            [NameInMap("error_message")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The expiration time of the node.
            /// </summary>
            [NameInMap("expired_time")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The name of the host.
            /// </summary>
            [NameInMap("host_name")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The ID of the system image that is used by the node.
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The billing method of the instance on which the node is deployed. Valid values:
            /// 
            /// *   `PrePaid`: the subscription billing method. If the value is PrePaid, make sure that you have a sufficient balance or credit in your account. Otherwise, an `InvalidPayMethod` error is returned.
            /// *   `PostPaid`: the pay-as-you-go billing method.
            /// </summary>
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// The ID of the instance on which the node is deployed.
            /// </summary>
            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the instance on which the node is deployed.
            /// </summary>
            [NameInMap("instance_name")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The role of the node. Valid values:
            /// 
            /// *   Master: master node
            /// *   Worker: worker node
            /// </summary>
            [NameInMap("instance_role")]
            [Validation(Required=false)]
            public string InstanceRole { get; set; }

            /// <summary>
            /// The status of the node.
            /// </summary>
            [NameInMap("instance_status")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// The instance type of the node.
            /// </summary>
            [NameInMap("instance_type")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The Elastic Compute Service (ECS) instance family of the node.
            /// </summary>
            [NameInMap("instance_type_family")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            /// <summary>
            /// The IP address of the node.
            /// </summary>
            [NameInMap("ip_address")]
            [Validation(Required=false)]
            public List<string> IpAddress { get; set; }

            /// <summary>
            /// Indicates whether the instance on which the node is deployed is provided by Alibaba Cloud. Valid values:
            /// 
            /// *   `true`: The instance is provided by Alibaba Cloud.
            /// *   `false`: The instance is not provided by Alibaba Cloud.
            /// </summary>
            [NameInMap("is_aliyun_node")]
            [Validation(Required=false)]
            public bool? IsAliyunNode { get; set; }

            /// <summary>
            /// The name of the node. This name is the identifier of the node in the cluster.
            /// </summary>
            [NameInMap("node_name")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// Indicates whether the node is ready. Valid values:
            /// 
            /// *   `Ready`: The node is ready.
            /// *   `NotReady`: The node is not ready.
            /// *   `Unknown`: The status of the node is unknown.
            /// *   `Offline`: The node is offline.
            /// </summary>
            [NameInMap("node_status")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            /// <summary>
            /// The ID of the node pool.
            /// </summary>
            [NameInMap("nodepool_id")]
            [Validation(Required=false)]
            public string NodepoolId { get; set; }

            /// <summary>
            /// Indicates how the node is initialized. A node can be manually created or created by using Resource Orchestration Service (ROS).
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The type of the preemptible instance. Valid values:
            /// 
            /// *   NoSpot: a non-preemptible instance.
            /// *   SpotWithPriceLimit: a preemptible instance that is configured with the highest bid price.
            /// *   SpotAsPriceGo: a preemptible instance for which the system automatically bids based on the current market price.
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// The status of the node. Valid values:
            /// 
            /// *   `pending`: The node is being created.
            /// *   `running`: The node is running.
            /// *   `starting`: The node is being started.
            /// *   `stopping`: The node is being stopped.
            /// *   `stopped`: The node is stopped.
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The pagination details.
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public DescribeClusterNodesResponseBodyPage Page { get; set; }
        public class DescribeClusterNodesResponseBodyPage : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
