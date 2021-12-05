// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnRouteEntriesResponseBody : TeaModel {
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

        [NameInMap("VpnRouteEntries")]
        [Validation(Required=false)]
        public DescribeVpnRouteEntriesResponseBodyVpnRouteEntries VpnRouteEntries { get; set; }
        public class DescribeVpnRouteEntriesResponseBodyVpnRouteEntries : TeaModel {
            [NameInMap("VpnRouteEntry")]
            [Validation(Required=false)]
            public List<DescribeVpnRouteEntriesResponseBodyVpnRouteEntriesVpnRouteEntry> VpnRouteEntry { get; set; }
            public class DescribeVpnRouteEntriesResponseBodyVpnRouteEntriesVpnRouteEntry : TeaModel {
                public string AsPath { get; set; }
                public string Community { get; set; }
                public long? CreateTime { get; set; }
                public string NextHop { get; set; }
                public string RouteDest { get; set; }
                public string RouteEntryType { get; set; }
                public string Source { get; set; }
                public string State { get; set; }
                public string VpnInstanceId { get; set; }
                public int? Weight { get; set; }
            }
        };

    }

}
