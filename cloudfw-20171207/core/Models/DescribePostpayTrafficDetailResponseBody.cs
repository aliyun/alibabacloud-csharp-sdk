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
        /// The traffic statistics.
        /// </summary>
        [NameInMap("TrafficList")]
        [Validation(Required=false)]
        public List<DescribePostpayTrafficDetailResponseBodyTrafficList> TrafficList { get; set; }
        public class DescribePostpayTrafficDetailResponseBodyTrafficList : TeaModel {
            /// <summary>
            /// The inbound network throughput, which indicates the total number of bytes that are received. Unit: bytes.
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
            /// The type of the asset. This value takes effect only for the Internet firewall.
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

            /// <summary>
            /// The resource ID. The resource ID for the Internet firewall is the public IP address that is protected the Internet firewall, and the resource ID for a NAT firewall is the instance ID of the NAT firewall.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The total inbound and outbound network throughput, which indicates the total number of bytes that are sent and received. Unit: bytes.
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
            /// *   **NatGateway_TRAFFIC**: traffic for the NAT firewall
            /// </summary>
            [NameInMap("TrafficType")]
            [Validation(Required=false)]
            public string TrafficType { get; set; }

        }

    }

}
