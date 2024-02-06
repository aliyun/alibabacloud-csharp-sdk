// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeForwardTableEntriesResponseBody : TeaModel {
        /// <summary>
        /// Details of DNAT entries.
        /// </summary>
        [NameInMap("ForwardTableEntries")]
        [Validation(Required=false)]
        public List<DescribeForwardTableEntriesResponseBodyForwardTableEntries> ForwardTableEntries { get; set; }
        public class DescribeForwardTableEntriesResponseBodyForwardTableEntries : TeaModel {
            /// <summary>
            /// The EIP in the DNAT entry. The public IP address is used to access the Internet.
            /// </summary>
            [NameInMap("ExternalIp")]
            [Validation(Required=false)]
            public string ExternalIp { get; set; }

            /// <summary>
            /// The external port or port range that is used in port forwarding.
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
            /// The probe port of DNAT.
            /// </summary>
            [NameInMap("HealthCheckPort")]
            [Validation(Required=false)]
            public string HealthCheckPort { get; set; }

            /// <summary>
            /// The private IP address of the instance that uses the DNAT entry for Internet communication.
            /// </summary>
            [NameInMap("InternalIp")]
            [Validation(Required=false)]
            public string InternalIp { get; set; }

            /// <summary>
            /// The internal port or port range that is used for port forwarding.
            /// </summary>
            [NameInMap("InternalPort")]
            [Validation(Required=false)]
            public string InternalPort { get; set; }

            /// <summary>
            /// The protocol. Valid values:
            /// 
            /// *   **TCP**: forwards TCP packets.
            /// *   **UDP**: forwards UDP packets.
            /// *   **Any**: forwards all packets.
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// The ID of the NAT gateway.
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// The secondary EIP that is used to access the Internet.
            /// </summary>
            [NameInMap("StandbyExternalIp")]
            [Validation(Required=false)]
            public string StandbyExternalIp { get; set; }

            /// <summary>
            /// The status of the secondary EIP. Valid values:
            /// 
            /// *   Running
            /// *   Stopping
            /// *   Stopped
            /// *   Starting
            /// </summary>
            [NameInMap("StandbyStatus")]
            [Validation(Required=false)]
            public string StandbyStatus { get; set; }

            /// <summary>
            /// The status of the DNAT entry. Valid values:
            /// 
            /// *   Pending: The DNAT entry is being created or modified.
            /// *   Available: The DNAT entry is available.
            /// *   Deleting: The DNAT entry is being deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

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
        public string TotalCount { get; set; }

    }

}
