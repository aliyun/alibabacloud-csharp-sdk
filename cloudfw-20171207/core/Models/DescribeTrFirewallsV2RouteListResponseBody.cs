// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallsV2RouteListResponseBody : TeaModel {
        /// <summary>
        /// <para>The route tables of Cloud Firewall.</para>
        /// </summary>
        [NameInMap("FirewallRouteDetailList")]
        [Validation(Required=false)]
        public List<DescribeTrFirewallsV2RouteListResponseBodyFirewallRouteDetailList> FirewallRouteDetailList { get; set; }
        public class DescribeTrFirewallsV2RouteListResponseBodyFirewallRouteDetailList : TeaModel {
            /// <summary>
            /// <para>The destination address of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.0/25</para>
            /// </summary>
            [NameInMap("TrFirewallRouteDestination")]
            [Validation(Required=false)]
            public string TrFirewallRouteDestination { get; set; }

            /// <summary>
            /// <para>The ID of the next hop for the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-hnxab1y0pxn16p****</para>
            /// </summary>
            [NameInMap("TrFirewallRouteNexthop")]
            [Validation(Required=false)]
            public string TrFirewallRouteNexthop { get; set; }

            /// <summary>
            /// <para>The ID of the routing policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>policy-04ecbbc6720d4f90****</para>
            /// </summary>
            [NameInMap("TrFirewallRoutePolicyId")]
            [Validation(Required=false)]
            public string TrFirewallRoutePolicyId { get; set; }

            /// <summary>
            /// <para>The ID of the route table to which the route entry belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-2zeockxxxorv0mnhz****</para>
            /// </summary>
            [NameInMap("TrFirewallRouteTableId")]
            [Validation(Required=false)]
            public string TrFirewallRouteTableId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABF190A2-B4D0-53F6-995A-5690A721F91C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
