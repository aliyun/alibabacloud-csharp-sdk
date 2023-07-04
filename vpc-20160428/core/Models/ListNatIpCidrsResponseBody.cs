// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListNatIpCidrsResponseBody : TeaModel {
        /// <summary>
        /// The CIDR blocks of the NAT gateway.
        /// </summary>
        [NameInMap("NatIpCidrs")]
        [Validation(Required=false)]
        public List<ListNatIpCidrsResponseBodyNatIpCidrs> NatIpCidrs { get; set; }
        public class ListNatIpCidrsResponseBodyNatIpCidrs : TeaModel {
            /// <summary>
            /// The time when the CIDR block was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// Indicates whether the CIDR block is the default CIDR block of the NAT gateway. Valid values:
            /// 
            /// *   **true**: The CIDR block is the default CIDR block of the NAT gateway.
            /// *   **false**: The CIDR block is not the default CIDR block of the NAT gateway.
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// The ID of the VPC NAT gateway.
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// The CIDR block of the NAT gateway.
            /// </summary>
            [NameInMap("NatIpCidr")]
            [Validation(Required=false)]
            public string NatIpCidr { get; set; }

            /// <summary>
            /// The description of the CIDR block of the NAT gateway.
            /// </summary>
            [NameInMap("NatIpCidrDescription")]
            [Validation(Required=false)]
            public string NatIpCidrDescription { get; set; }

            /// <summary>
            /// The ID of the CIDR block of the NAT gateway.
            /// </summary>
            [NameInMap("NatIpCidrId")]
            [Validation(Required=false)]
            public string NatIpCidrId { get; set; }

            /// <summary>
            /// The name of the CIDR block of the NAT gateway.
            /// </summary>
            [NameInMap("NatIpCidrName")]
            [Validation(Required=false)]
            public string NatIpCidrName { get; set; }

            /// <summary>
            /// The status of the CIDR block of the NAT gateway. If **Available** is returned, it indicates that the CIDR block is available.
            /// </summary>
            [NameInMap("NatIpCidrStatus")]
            [Validation(Required=false)]
            public string NatIpCidrStatus { get; set; }

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
        /// The number of CIDR blocks that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
