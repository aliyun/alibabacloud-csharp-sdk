// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeForwardTableEntriesResponseBody : TeaModel {
        /// <summary>
        /// The details of DNAT entries.
        /// </summary>
        [NameInMap("ForwardTableEntries")]
        [Validation(Required=false)]
        public DescribeForwardTableEntriesResponseBodyForwardTableEntries ForwardTableEntries { get; set; }
        public class DescribeForwardTableEntriesResponseBodyForwardTableEntries : TeaModel {
            [NameInMap("ForwardTableEntry")]
            [Validation(Required=false)]
            public List<DescribeForwardTableEntriesResponseBodyForwardTableEntriesForwardTableEntry> ForwardTableEntry { get; set; }
            public class DescribeForwardTableEntriesResponseBodyForwardTableEntriesForwardTableEntry : TeaModel {
                /// <summary>
                /// *   The EIPs that can be accessed over the Internet when you query DNAT entries of Internet NAT gateways.
                /// *   The NAT IP addresses that can be accessed by external networks when you query DNAT entries of VPC NAT gateways.
                /// </summary>
                [NameInMap("ExternalIp")]
                [Validation(Required=false)]
                public string ExternalIp { get; set; }

                /// <summary>
                /// *   The external port or port range that is used for port forwarding when you query DNAT entries of Internet NAT gateways.
                /// *   The port that is used when the NAT IP address can be accessed by external networks when you query DNAT entries of VPC NAT gateways.
                /// </summary>
                [NameInMap("ExternalPort")]
                [Validation(Required=false)]
                public string ExternalPort { get; set; }

                /// <summary>
                /// The ID of the DNAT entry.
                /// </summary>
                [NameInMap("ForwardEntryId")]
                [Validation(Required=false)]
                public string ForwardEntryId { get; set; }

                /// <summary>
                /// The name of the DNAT entry.
                /// </summary>
                [NameInMap("ForwardEntryName")]
                [Validation(Required=false)]
                public string ForwardEntryName { get; set; }

                /// <summary>
                /// The ID of the DNAT table to which the DNAT entry belongs.
                /// </summary>
                [NameInMap("ForwardTableId")]
                [Validation(Required=false)]
                public string ForwardTableId { get; set; }

                /// <summary>
                /// The private IP address.
                /// 
                /// *   The private IP address of the ECS instance that uses DNAT entries to communicate with the Internet when you query DNAT entries of Internet NAT gateways.
                /// *   The private IP address that uses DNAT entries when you query DNAT entries of VPC NAT gateways.
                /// </summary>
                [NameInMap("InternalIp")]
                [Validation(Required=false)]
                public string InternalIp { get; set; }

                /// <summary>
                /// *   The internal port or port range that is used for port forwarding when you query DNAT entries of Internet NAT gateways.
                /// *   The destination ECS instance port to be mapped when you query DNAT entries of VPC NAT gateways.
                /// </summary>
                [NameInMap("InternalPort")]
                [Validation(Required=false)]
                public string InternalPort { get; set; }

                /// <summary>
                /// The protocol. Valid values:
                /// 
                /// *   **TCP**
                /// *   **UDP**
                /// *   **Any**
                /// </summary>
                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                /// <summary>
                /// The ID of the NAT gateway to which the DNAT entry belongs.
                /// </summary>
                [NameInMap("NatGatewayId")]
                [Validation(Required=false)]
                public string NatGatewayId { get; set; }

                /// <summary>
                /// The status of the DNAT entry. Valid values:
                /// 
                /// *   **Pending**
                /// *   **Available**
                /// *   **Deleting**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
