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
        /// The ID of the next hop of the custom route entry. You can specify up to 50 next hop IDs.
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
            [NameInMap("DstCidrBlock")]
            [Validation(Required=false)]
            public string DstCidrBlock { get; set; }

            /// <summary>
            /// The description of the custom route entry. You can specify up to 50 descriptions.
            /// 
            /// The description must be 1 to 256 characters in length, and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public int? IpVersion { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The number of custom route entries that were successfully added.
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            /// <summary>
            /// The number of custom route entries that failed to be added.
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// The name of the custom route entry that you want to add. You can specify up to 50 names.
            /// 
            /// The name must be 1 to 128 characters in length, and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

    }

}
