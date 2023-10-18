// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnPbrRouteEntryWeightRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The new weight of the policy-based route. Valid values:
        /// 
        /// *   **100**: The IPsec-VPN connection associated with the policy-based route serves as an active connection.
        /// *   **0**: The IPsec-VPN connection associated with the policy-based route serves as a standby connection.
        /// </summary>
        [NameInMap("NewWeight")]
        [Validation(Required=false)]
        public int? NewWeight { get; set; }

        /// <summary>
        /// The next hop of the policy-based route.
        /// </summary>
        [NameInMap("NextHop")]
        [Validation(Required=false)]
        public string NextHop { get; set; }

        /// <summary>
        /// The tunneling protocol. The value is set to **Ipsec**, which indicates the IPsec tunneling protocol.
        /// </summary>
        [NameInMap("OverlayMode")]
        [Validation(Required=false)]
        public string OverlayMode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The priority of the policy-based route.
        /// 
        /// *   If the route was not assigned a priority, this parameter is optional.
        /// 
        /// *   If the route was assigned a priority, this parameter is optional.
        /// 
        ///         If you specify this parameter, set the value to the priority that was assigned to the policy-based route. Otherwise, the operation fails.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The ID of the region where the VPN gateway is created. You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
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
        /// The destination CIDR block of the policy-based route.
        /// </summary>
        [NameInMap("RouteDest")]
        [Validation(Required=false)]
        public string RouteDest { get; set; }

        /// <summary>
        /// The source CIDR block of the policy-based route.
        /// </summary>
        [NameInMap("RouteSource")]
        [Validation(Required=false)]
        public string RouteSource { get; set; }

        /// <summary>
        /// The ID of the VPN gateway.
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// The original weight of the policy-based route. Valid values:
        /// 
        /// *   **100**: The IPsec-VPN connection associated with the policy-based route serves as an active connection.
        /// *   **0**: The IPsec-VPN connection associated with the policy-based route serves as a standby connection.
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
