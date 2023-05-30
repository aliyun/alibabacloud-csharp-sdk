// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallsV2RouteListResponseBody : TeaModel {
        [NameInMap("FirewallRouteDetailList")]
        [Validation(Required=false)]
        public List<DescribeTrFirewallsV2RouteListResponseBodyFirewallRouteDetailList> FirewallRouteDetailList { get; set; }
        public class DescribeTrFirewallsV2RouteListResponseBodyFirewallRouteDetailList : TeaModel {
            [NameInMap("TrFirewallRouteDestination")]
            [Validation(Required=false)]
            public string TrFirewallRouteDestination { get; set; }

            [NameInMap("TrFirewallRouteNexthop")]
            [Validation(Required=false)]
            public string TrFirewallRouteNexthop { get; set; }

            [NameInMap("TrFirewallRoutePolicyId")]
            [Validation(Required=false)]
            public string TrFirewallRoutePolicyId { get; set; }

            [NameInMap("TrFirewallRouteTableId")]
            [Validation(Required=false)]
            public string TrFirewallRouteTableId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
