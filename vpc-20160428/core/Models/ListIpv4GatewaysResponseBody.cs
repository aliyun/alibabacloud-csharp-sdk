// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListIpv4GatewaysResponseBody : TeaModel {
        /// <summary>
        /// The list of IPv4 gateways.
        /// </summary>
        [NameInMap("Ipv4GatewayModels")]
        [Validation(Required=false)]
        public List<ListIpv4GatewaysResponseBodyIpv4GatewayModels> Ipv4GatewayModels { get; set; }
        public class ListIpv4GatewaysResponseBodyIpv4GatewayModels : TeaModel {
            /// <summary>
            /// Indicates whether the IPv4 gateway is activated. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// The time when the IPv4 gateway was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The description of the IPv4 gateway.
            /// </summary>
            [NameInMap("Ipv4GatewayDescription")]
            [Validation(Required=false)]
            public string Ipv4GatewayDescription { get; set; }

            /// <summary>
            /// The ID of the IPv4 gateway.
            /// </summary>
            [NameInMap("Ipv4GatewayId")]
            [Validation(Required=false)]
            public string Ipv4GatewayId { get; set; }

            /// <summary>
            /// The name of the IPv4 gateway.
            /// </summary>
            [NameInMap("Ipv4GatewayName")]
            [Validation(Required=false)]
            public string Ipv4GatewayName { get; set; }

            /// <summary>
            /// The ID of the route table associated with the IPv4 gateway.
            /// </summary>
            [NameInMap("Ipv4GatewayRouteTableId")]
            [Validation(Required=false)]
            public string Ipv4GatewayRouteTableId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the IPv4 gateway belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The status of the IPv4 gateway. Valid values:
            /// 
            /// *   **Creating**
            /// *   **Created**
            /// *   **Modifying**
            /// *   **Deleting**
            /// *   **Deleted**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The list of tags that are added to the resource group.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListIpv4GatewaysResponseBodyIpv4GatewayModelsTags> Tags { get; set; }
            public class ListIpv4GatewaysResponseBodyIpv4GatewayModelsTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the VPC with which the IPv4 gateways are associated.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If no value is returned for **NextToken**, no next queries are sent.
        /// *   If a value of **NextToken** is returned, the value is the token that is used for the subsequent query.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
