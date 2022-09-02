// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodesResponseBody : TeaModel {
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<DescribeClusterNodesResponseBodyNodes> Nodes { get; set; }
        public class DescribeClusterNodesResponseBodyNodes : TeaModel {
            [NameInMap("creation_time")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("error_message")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("expired_time")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("host_name")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("instance_name")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("instance_role")]
            [Validation(Required=false)]
            public string InstanceRole { get; set; }

            [NameInMap("instance_status")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("instance_type")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("instance_type_family")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            [NameInMap("ip_address")]
            [Validation(Required=false)]
            public List<string> IpAddress { get; set; }

            [NameInMap("is_aliyun_node")]
            [Validation(Required=false)]
            public bool? IsAliyunNode { get; set; }

            [NameInMap("node_name")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            [NameInMap("node_status")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            [NameInMap("nodepool_id")]
            [Validation(Required=false)]
            public string NodepoolId { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

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

        }

    }

}
