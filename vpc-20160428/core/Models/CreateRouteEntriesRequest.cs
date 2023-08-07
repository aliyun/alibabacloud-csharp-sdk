// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouteEntriesRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the route table is created.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
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

        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<CreateRouteEntriesRequestRouteEntries> RouteEntries { get; set; }
        public class CreateRouteEntriesRequestRouteEntries : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The destination CIDR block of the custom route entry. Both IPv4 and IPv6 CIDR blocks are supported. You can specify up to 50 destination CIDR blocks. Make sure that the destination CIDR block meets the following requirements:
            /// 
            /// *   The destination CIDR block is not 100.64.0.0/10 or a subset of 100.64.0.0/10.
            /// *   The destination CIDR block of the custom route entry is different from the destination CIDR blocks of other route entries in the same route table.
            /// </summary>
            [NameInMap("DstCidrBlock")]
            [Validation(Required=false)]
            public string DstCidrBlock { get; set; }

            /// <summary>
            /// The version of the IP protocol. You can specify up to 50 IP protocol versions. Valid values:
            /// 
            /// *   **IPv4**
            /// *   **IPv6**
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public int? IpVersion { get; set; }

            /// <summary>
            /// The name of the custom route entry that you want to add. You can specify up to 50 names.
            /// 
            /// The name must be 1 to 128 characters in length, and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the next hop of the custom route entry. You can specify up to 50 next hop IDs.
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            /// <summary>
            /// The type of next hop. You can specify up to 50 next hop types. Valid values:
            /// 
            /// *   **Instance**: Elastic Compute Service (ECS) instance. This is the default value.
            /// *   **HaVip**: high-availability virtual IP address (HAVIP).
            /// *   **RouterInterface**: router interface.
            /// *   **NetworkInterface**: elastic network interface (ENI).
            /// *   **VpnGateway**: VPN gateway.
            /// *   **IPv6Gateway**: IPv6 gateway.
            /// *   **NatGateway**: NAT gateway.
            /// *   **Attachment**: transit router.
            /// *   **VpcPeer**: VPC peering connection.
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// The ID of the route table to which you want to add the custom route entry. You can specify up to 50 route table IDs.
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

    }

}
