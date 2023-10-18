// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnPbrRouteEntryPriorityRequest : TeaModel {
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
        /// The new priority of the policy-based route. Valid values: **1** to **100**.
        /// 
        /// A smaller value indicates a higher priority.
        /// </summary>
        [NameInMap("NewPriority")]
        [Validation(Required=false)]
        public int? NewPriority { get; set; }

        /// <summary>
        /// The next hop of the policy-based route.
        /// </summary>
        [NameInMap("NextHop")]
        [Validation(Required=false)]
        public string NextHop { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The original priority of the policy-based route. Valid values: **1** to **100**.
        /// 
        /// A smaller value indicates a higher priority.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The ID of the region where the VPN gateway is created.
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
        /// The weight of the policy-based route. Valid values:
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
