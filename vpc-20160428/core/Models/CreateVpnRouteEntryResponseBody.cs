// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnRouteEntryResponseBody : TeaModel {
        /// <summary>
        /// The timestamp when the destination-based route was created. Unit: milliseconds.
        /// 
        /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// The description of the destination-based route.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The next hop of the destination-based route.
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

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The destination CIDR block of the destination-based route.
        /// </summary>
        [NameInMap("RouteDest")]
        [Validation(Required=false)]
        public string RouteDest { get; set; }

        /// <summary>
        /// The status of the destination-based route.
        /// 
        /// *   **published**: advertised to the VPC route table.
        /// *   **normal**: not advertised to the VPC route table.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The ID of the VPN gateway.
        /// </summary>
        [NameInMap("VpnInstanceId")]
        [Validation(Required=false)]
        public string VpnInstanceId { get; set; }

        /// <summary>
        /// The weight of the destination-based route. Valid values:
        /// 
        /// *   **100**: a high priority
        /// *   **0**: a low priority
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
