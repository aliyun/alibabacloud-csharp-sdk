// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnPbrRouteEntryAttributeRequest : TeaModel {
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
        /// 
        /// If you do not specify this parameter, the priority of the policy-based route is not modified.
        /// 
        /// >  You must specify at least one of **NewPriority** and **NewWeight**.
        /// </summary>
        [NameInMap("NewPriority")]
        [Validation(Required=false)]
        public int? NewPriority { get; set; }

        /// <summary>
        /// The new weight of the policy-based route. Valid values:
        /// 
        /// *   **100**: The IPsec-VPN connection associated with the policy-based route serves as the active connection.
        /// *   **0**: The IPsec-VPN connection associated with the policy-based route serves as the standby connection.
        /// 
        /// If you do not specify this parameter, the weight of the policy-based route is not modified.
        /// 
        /// >  You must specify at least one of **NewPriority** and **NewWeight**.
        /// </summary>
        [NameInMap("NewWeight")]
        [Validation(Required=false)]
        public int? NewWeight { get; set; }

        /// <summary>
        /// The next hop of the policy-based route.
        /// 
        /// This parameter is required.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The region ID of the VPN gateway.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouteDest")]
        [Validation(Required=false)]
        public string RouteDest { get; set; }

        /// <summary>
        /// The source CIDR block of the policy-based route.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouteSource")]
        [Validation(Required=false)]
        public string RouteSource { get; set; }

        /// <summary>
        /// The ID of the VPN gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// The original weight of the policy-based route. Valid values:
        /// 
        /// *   **100**: The IPsec-VPN connection associated with the policy-based route serves as an active connection.
        /// *   **0**: The IPsec-VPN connection associated with the policy-based route serves as a standby connection.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
