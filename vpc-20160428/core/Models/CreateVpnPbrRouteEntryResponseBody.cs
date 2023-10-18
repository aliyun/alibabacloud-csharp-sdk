// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnPbrRouteEntryResponseBody : TeaModel {
        /// <summary>
        /// The time when the policy-based route was created.
        /// 
        /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// The description of the policy-based route.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The next hop of the policy-based route.
        /// </summary>
        [NameInMap("NextHop")]
        [Validation(Required=false)]
        public string NextHop { get; set; }

        /// <summary>
        /// The tunneling protocol. The value is **Ipsec**.
        /// </summary>
        [NameInMap("OverlayMode")]
        [Validation(Required=false)]
        public string OverlayMode { get; set; }

        /// <summary>
        /// The priority of the policy-based route.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// The status of the policy-based route. Valid values:
        /// 
        /// *   **published**: advertised to the VPC route table.
        /// *   **normal**: not advertised to the VPC route table.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The VPN gateway ID.
        /// </summary>
        [NameInMap("VpnInstanceId")]
        [Validation(Required=false)]
        public string VpnInstanceId { get; set; }

        /// <summary>
        /// The weight of the policy-based route. Valid values:
        /// 
        /// *   **100**: The IPsec-VPN connection associated with the policy-based route serves as an active connection.
        /// *   **0**: The IPsec-VPN connection associated with the policy-based route serves as a standby connection.
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
