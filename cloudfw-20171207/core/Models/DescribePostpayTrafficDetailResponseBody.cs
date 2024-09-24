// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePostpayTrafficDetailResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The statistics on traffic.
        /// </summary>
        [NameInMap("TrafficList")]
        [Validation(Required=false)]
        public List<DescribePostpayTrafficDetailResponseBodyTrafficList> TrafficList { get; set; }
        public class DescribePostpayTrafficDetailResponseBodyTrafficList : TeaModel {
            /// <summary>
            /// The inbound network throughput, which indicates the total number of bytes that are received Unit: bytes.
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// The instance ID of the asset.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The asset type. This value takes effect only for the Internet firewall.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The outbound network throughput, which indicates the total number of bytes that are sent. Unit: bytes.
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            [NameInMap("ProtectionDuration")]
            [Validation(Required=false)]
            public long? ProtectionDuration { get; set; }

            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// The resource ID. The resource ID for the Internet firewall is the public IP address that is protected the Internet firewall, and the resource ID for a NAT firewall is the instance ID of the NAT firewall.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The total inbound and outbound network throughput, which indicates the total number of bytes that are received and sent. Unit: bytes.
            /// </summary>
            [NameInMap("TotalBytes")]
            [Validation(Required=false)]
            public long? TotalBytes { get; set; }

            /// <summary>
            /// The date on which the statistics are collected.
            /// </summary>
            [NameInMap("TrafficDay")]
            [Validation(Required=false)]
            public string TrafficDay { get; set; }

            /// <summary>
            /// The traffic type. Valid values:
            /// 
            /// *   **EIP_TRAFFIC**: traffic for the Internet firewall
            /// *   **NatGateway_TRAFFIC**: traffic for NAT firewalls
            /// *   **VPC_TRAFFIC**: traffic for VPC firewalls
            /// </summary>
            [NameInMap("TrafficType")]
            [Validation(Required=false)]
            public string TrafficType { get; set; }

        }

    }

}
