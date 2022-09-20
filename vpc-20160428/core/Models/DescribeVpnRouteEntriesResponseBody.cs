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
                [NameInMap("AsPath")]
                [Validation(Required=false)]
                public string AsPath { get; set; }

                [NameInMap("Community")]
                [Validation(Required=false)]
                public string Community { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("NextHop")]
                [Validation(Required=false)]
                public string NextHop { get; set; }

                [NameInMap("RouteDest")]
                [Validation(Required=false)]
                public string RouteDest { get; set; }

                [NameInMap("RouteEntryType")]
                [Validation(Required=false)]
                public string RouteEntryType { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

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
