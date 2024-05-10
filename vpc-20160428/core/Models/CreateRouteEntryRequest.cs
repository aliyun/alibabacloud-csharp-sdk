// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouteEntryRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that the value is unique among different requests. The ClientToken value can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the custom route entry.
        /// 
        /// The description must be 1 to 256 characters in length, and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The destination CIDR block of the custom route entry. Both IPv4 and IPv6 CIDR blocks are supported. Make sure that the destination CIDR block meets the following requirements:
        /// 
        /// *   The destination CIDR block is not 100.64.0.0/10 or a subset of 100.64.0.0/10.
        /// *   The destination CIDR block of the custom route entry is different from the destination CIDR blocks of other route entries in the same route table.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// The ID of the next hop.
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// The next hop list.
        /// </summary>
        [NameInMap("NextHopList")]
        [Validation(Required=false)]
        public List<CreateRouteEntryRequestNextHopList> NextHopList { get; set; }
        public class CreateRouteEntryRequestNextHopList : TeaModel {
            /// <summary>
            /// The ID of the next hop of the ECMP route.
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// The type of next hop of the ECMP route entry. Set the value to **RouterInterface**.
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// The weight of the next hop of the ECMP route entry.
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// The type of next hop of the custom route entry. Valid values:
        /// 
        /// *   **Instance**: an Elastic Compute Service (ECS) instance. This is the default value.
        /// *   **HaVip**: a high-availability virtual IP address (HAVIP).
        /// *   **RouterInterface**: a router interface.
        /// *   **NetworkInterface**: an elastic network interface (ENI).
        /// *   **VpnGateway**: a VPN gateway.
        /// *   **IPv6Gateway**: an IPv6 gateway.
        /// *   **NatGateway**: a NAT gateway.
        /// *   **Attachment**: a transit router.
        /// *   **VpcPeer**: a VPC peering connection.
        /// </summary>
        [NameInMap("NextHopType")]
        [Validation(Required=false)]
        public string NextHopType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the route table.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The name of the custom route entry that you want to add.
        /// 
        /// The name must be 1 to 128 characters in length, and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("RouteEntryName")]
        [Validation(Required=false)]
        public string RouteEntryName { get; set; }

        /// <summary>
        /// The ID of the route table to which you want to add a custom route entry.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

    }

}
