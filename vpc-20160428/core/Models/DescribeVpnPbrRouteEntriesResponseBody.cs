// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnPbrRouteEntriesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VpnPbrRouteEntries")]
        [Validation(Required=false)]
        public DescribeVpnPbrRouteEntriesResponseBodyVpnPbrRouteEntries VpnPbrRouteEntries { get; set; }
        public class DescribeVpnPbrRouteEntriesResponseBodyVpnPbrRouteEntries : TeaModel {
            [NameInMap("VpnPbrRouteEntry")]
            [Validation(Required=false)]
            public List<DescribeVpnPbrRouteEntriesResponseBodyVpnPbrRouteEntriesVpnPbrRouteEntry> VpnPbrRouteEntry { get; set; }
            public class DescribeVpnPbrRouteEntriesResponseBodyVpnPbrRouteEntriesVpnPbrRouteEntry : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("NextHop")]
                [Validation(Required=false)]
                public string NextHop { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("RouteDest")]
                [Validation(Required=false)]
                public string RouteDest { get; set; }

                [NameInMap("RouteSource")]
                [Validation(Required=false)]
                public string RouteSource { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("VpnInstanceId")]
                [Validation(Required=false)]
                public string VpnInstanceId { get; set; }

                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

    }

}
