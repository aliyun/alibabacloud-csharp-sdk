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
        /// The routes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<CreateRouteEntriesRequestRouteEntries> RouteEntries { get; set; }
        public class CreateRouteEntriesRequestRouteEntries : TeaModel {
            /// <summary>
            /// The description of the custom route. You can specify at most 50 descriptions.
            /// 
            /// The description must be 1 to 256 characters in length and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The destination CIDR block of the custom route. IPv4 CIDR blocks, IPv6 CIDR blocks, and prefix lists are supported. You can enter up to 50 destination CIDR blocks. Make sure that the following requirements are met:
            /// 
            /// *   The destination CIDR block cannot point to 100.64.0.0/10 or belong to 100.64.0.0/10.
            /// *   The destination CIDR block of each route in the route table is unique.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DstCidrBlock")]
            [Validation(Required=false)]
            public string DstCidrBlock { get; set; }

            /// <summary>
            /// The IP version. Valid values: You can specify at most 50 IP versions. Valid values:
            /// 
            /// *   **4**: IPv4
            /// *   **6**: IPv6
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public int? IpVersion { get; set; }

            /// <summary>
            /// The name of the custom route that you want to add. You can specify at most 50 names.
            /// 
            /// The name must be 1 to 128 characters in length and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the next hop for the custom route. You can specify at most 50 instance IDs.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            /// <summary>
            /// The type of next hop. You can specify at most 50 next hop types. Valid values:
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
            /// *   **Ipv4Gateway**: IPv4 gateway.
            /// *   **GatewayEndpoint**: gateway endpoint.
            /// *   **CenBasic**: CEN does not support transfer routers.
            /// *   **Ecr**: Express Connect Router (ECR).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// The ID of the route table to which you want to add custom route s. You can specify at most 50 route table IDs.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

    }

}
