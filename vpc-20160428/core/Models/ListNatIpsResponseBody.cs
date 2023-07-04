// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListNatIpsResponseBody : TeaModel {
        /// <summary>
        /// The list of IP addresses of the NAT gateway.
        /// </summary>
        [NameInMap("NatIps")]
        [Validation(Required=false)]
        public List<ListNatIpsResponseBodyNatIps> NatIps { get; set; }
        public class ListNatIpsResponseBodyNatIps : TeaModel {
            /// <summary>
            /// Indicates whether the IP address is the default IP address of the NAT gateway. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// The ID of the Virtual Private Cloud (VPC) NAT gateway to which the IP address is assigned.
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// The IP address.
            /// </summary>
            [NameInMap("NatIp")]
            [Validation(Required=false)]
            public string NatIp { get; set; }

            /// <summary>
            /// The CIDR block to which the IP address belongs.
            /// </summary>
            [NameInMap("NatIpCidr")]
            [Validation(Required=false)]
            public string NatIpCidr { get; set; }

            /// <summary>
            /// The description of the IP address.
            /// </summary>
            [NameInMap("NatIpDescription")]
            [Validation(Required=false)]
            public string NatIpDescription { get; set; }

            /// <summary>
            /// The ID of the IP address.
            /// </summary>
            [NameInMap("NatIpId")]
            [Validation(Required=false)]
            public string NatIpId { get; set; }

            /// <summary>
            /// The name of the IP address.
            /// </summary>
            [NameInMap("NatIpName")]
            [Validation(Required=false)]
            public string NatIpName { get; set; }

            /// <summary>
            /// The status of the IP address. Valid values:
            /// 
            /// *   **Available**: available
            /// *   **Deleted**: deleted
            /// *   **Deleting**: deleting
            /// *   **Creating**: creating
            /// *   **Associated**: specified in an SNAT or DNAT entry
            /// *   **Associating**: being specified in an SNAT or DNAT entry
            /// </summary>
            [NameInMap("NatIpStatus")]
            [Validation(Required=false)]
            public string NatIpStatus { get; set; }

        }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If the value of **NextToken** is not returned, it indicates that no next query is to be sent.
        /// *   If the value of **NextToken** is returned, the value indicates the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of IP addresses that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
