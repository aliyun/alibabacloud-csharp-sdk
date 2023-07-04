// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateGatewayRouteTableEntryAttributeRequest : TeaModel {
        /// <summary>
        /// The destination CIDR block of the route entry.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The next hop ID of the route entry after the route entry is modified.
        /// 
        /// *   If you set **NextHopType** to **Instance**, specify an ECS instance ID for the **NextHopId** parameter.
        /// *   If you set **NextHopType** to **NetworkInterface**, specify an ENI ID for the **NextHopId** parameter.
        /// *   If you set **NextHopType** to **Local**, leave the **NextHopId** parameter empty, which specifies a local next hop.
        /// 
        /// >  If you want to modify a route entry whose next hop type is **Instance** or **NetworkInterface**, you must first change the value of the **NextHopType** parameter to **Local**. Then, change the value of **NextHopType** to **Instance** or **NetworkInterface** and specify the **NextHopId** parameter. When you modify a route entry whose next hop type is Instance or NetworkInterface, you cannot directly specify a different ENI ID or ECS instance ID for the NextHopId parameter.
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// The next hop type of the route entry after the route entry is modified. Valid values:
        /// 
        /// *   **EcsInstance**: an Elastic Compute Service (ECS) instance
        /// *   **NetworkInterface**: an elastic network interface (ENI)
        /// *   **Local**: a local next hop
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to check the request without performing the operation. Valid values:
        /// 
        /// *   **true**: checks the request but does not modify the route entry. The system checks the required parameters, request syntax, and limits. If the request fails to pass the check, an error message is returned. If the request passes the check, the `DryRunOperation` error code is returned.
        /// *   **false** (default): sends the request. If the request passes the check, a 2xx HTTP status code is returned and the route entry is modified.
        /// </summary>
        [NameInMap("IPv4GatewayRouteTableId")]
        [Validation(Required=false)]
        public string IPv4GatewayRouteTableId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the gateway route table.
        /// 
        /// The description must be 2 to 256 characters in length. The description must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// The name of the gateway route table.
        /// 
        /// The name must be 2 to 128 characters in length and can contain letter, digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter.
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
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among all requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the value of **RequestId** as the value of **ClientToken**. The value of **RequestId** may be different for each API request.
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

    }

}
