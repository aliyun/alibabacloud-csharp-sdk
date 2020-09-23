// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodesResponseBody : TeaModel {
        /// <summary>
        /// 节点信息列表。
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<DescribeClusterNodesResponseBodyNodes> Nodes { get; set; }
        public class DescribeClusterNodesResponseBodyNodes : TeaModel {
            /// <summary>
            /// 节点创建时间。
            /// </summary>
            [NameInMap("creation_time")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// 错误信息说明。
            /// </summary>
            [NameInMap("error_message")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// 节点过期时间。
            /// </summary>
            [NameInMap("expired_time")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// 节点主机名。
            /// </summary>
            [NameInMap("host_name")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// 节点使用的镜像ID。
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// 节点付费类型。
            /// </summary>
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// 节点实例ID。
            /// </summary>
            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// 节点实例名称。
            /// </summary>
            [NameInMap("instance_name")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// 节点实例角色类型，Master或Worker。
            /// </summary>
            [NameInMap("instance_role")]
            [Validation(Required=false)]
            public string InstanceRole { get; set; }

            /// <summary>
            /// 节点实例状态，
            /// </summary>
            [NameInMap("instance_status")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// 节点实例类型。
            /// </summary>
            [NameInMap("instance_type")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// 节点实例所属ECS实例簇名称。
            /// </summary>
            [NameInMap("instance_type_family")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            /// <summary>
            /// 节点IP地址。
            /// </summary>
            [NameInMap("ip_address")]
            [Validation(Required=false)]
            public List<string> IpAddress { get; set; }

            /// <summary>
            /// 节点是否为aliyun实例。
            /// </summary>
            [NameInMap("is_aliyun_node")]
            [Validation(Required=false)]
            public bool? IsAliyunNode { get; set; }

            /// <summary>
            /// 节点名称，该名称是k8s专用名称。
            /// </summary>
            [NameInMap("node_name")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// 节点状态，是否Ready。
            /// </summary>
            [NameInMap("node_status")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            /// <summary>
            /// 节点所属的节点池ID。
            /// </summary>
            [NameInMap("nodepool_id")]
            [Validation(Required=false)]
            public string NodepoolId { get; set; }

            /// <summary>
            /// 节点通过什么方式创建出来的，例如：ROS。
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// ECS运行状态，例如：running。
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// 分页信息。
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public DescribeClusterNodesResponseBodyPage Page { get; set; }
        public class DescribeClusterNodesResponseBodyPage : TeaModel {
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
