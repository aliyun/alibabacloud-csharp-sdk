// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BF3995A6-FA4F-4C74-B90F-89ECF4BFF4D5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VpnRouteCounts")]
        [Validation(Required=false)]
        public DescribeVpnRouteEntriesResponseBodyVpnRouteCounts VpnRouteCounts { get; set; }
        public class DescribeVpnRouteEntriesResponseBodyVpnRouteCounts : TeaModel {
            [NameInMap("VpnRouteCount")]
            [Validation(Required=false)]
            public List<DescribeVpnRouteEntriesResponseBodyVpnRouteCountsVpnRouteCount> VpnRouteCount { get; set; }
            public class DescribeVpnRouteEntriesResponseBodyVpnRouteCountsVpnRouteCount : TeaModel {
                [NameInMap("RouteCount")]
                [Validation(Required=false)]
                public int? RouteCount { get; set; }

                [NameInMap("RouteEntryType")]
                [Validation(Required=false)]
                public string RouteEntryType { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

        }

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

                [NameInMap("NextHopTunnelId")]
                [Validation(Required=false)]
                public string NextHopTunnelId { get; set; }

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
