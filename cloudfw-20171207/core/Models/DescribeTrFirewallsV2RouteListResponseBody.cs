// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallsV2RouteListResponseBody : TeaModel {
        /// <summary>
        /// The route tables of Cloud Firewall.
        /// </summary>
        [NameInMap("FirewallRouteDetailList")]
        [Validation(Required=false)]
        public List<DescribeTrFirewallsV2RouteListResponseBodyFirewallRouteDetailList> FirewallRouteDetailList { get; set; }
        public class DescribeTrFirewallsV2RouteListResponseBodyFirewallRouteDetailList : TeaModel {
            /// <summary>
            /// The destination address of the route.
            /// </summary>
            [NameInMap("TrFirewallRouteDestination")]
            [Validation(Required=false)]
            public string TrFirewallRouteDestination { get; set; }

            /// <summary>
            /// The ID of the next hop for the route.
            /// </summary>
            [NameInMap("TrFirewallRouteNexthop")]
            [Validation(Required=false)]
            public string TrFirewallRouteNexthop { get; set; }

            /// <summary>
            /// The ID of the routing policy.
            /// </summary>
            [NameInMap("TrFirewallRoutePolicyId")]
            [Validation(Required=false)]
            public string TrFirewallRoutePolicyId { get; set; }

            /// <summary>
            /// The ID of the route table to which the route entry belongs.
            /// </summary>
            [NameInMap("TrFirewallRouteTableId")]
            [Validation(Required=false)]
            public string TrFirewallRouteTableId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
