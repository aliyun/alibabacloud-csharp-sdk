// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNatGatewaysResponseBody : TeaModel {
        /// <summary>
        /// Details about the NAT gateways.
        /// </summary>
        [NameInMap("NatGateways")]
        [Validation(Required=false)]
        public List<DescribeNatGatewaysResponseBodyNatGateways> NatGateways { get; set; }
        public class DescribeNatGatewaysResponseBodyNatGateways : TeaModel {
            /// <summary>
            /// The time when the NAT gateway was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The ID of the ENS node.
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// The name of the NAT gateway.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the NAT gateway.
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// The ID of the network.
            /// </summary>
            [NameInMap("NetworkId")]
            [Validation(Required=false)]
            public string NetworkId { get; set; }

            /// <summary>
            /// The type of the NAT gateway.
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// The ID of the vSwitch.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of NAT gateways that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
