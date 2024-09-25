// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVcoRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of the returned page.</para>
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
        /// <para>E18980E8-C8C2-31BD-8156-AE2BBDEC87E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of routes.</para>
        /// </summary>
        [NameInMap("VcoRouteEntries")]
        [Validation(Required=false)]
        public List<DescribeVcoRouteEntriesResponseBodyVcoRouteEntries> VcoRouteEntries { get; set; }
        public class DescribeVcoRouteEntriesResponseBodyVcoRouteEntries : TeaModel {
            /// <summary>
            /// <para>The list of autonomous system (AS) numbers that the BGP route goes through.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[12000]</para>
            /// </summary>
            [NameInMap("AsPath")]
            [Validation(Required=false)]
            public string AsPath { get; set; }

            /// <summary>
            /// <para>The community value carried by the BGP route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65535:65510</para>
            /// </summary>
            [NameInMap("Community")]
            [Validation(Required=false)]
            public string Community { get; set; }

            /// <summary>
            /// <para>The timestamp when the route was created.</para>
            /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1658217008000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The next hop of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vco-p0w2jpkhi2eeop6q6****</para>
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.0/24</para>
            /// </summary>
            [NameInMap("RouteDest")]
            [Validation(Required=false)]
            public string RouteDest { get; set; }

            /// <summary>
            /// <para>The route type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>custom</b>: a destination-based route</description></item>
            /// <item><description><b>bgp</b>: a BGP route</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("RouteEntryType")]
            [Validation(Required=false)]
            public string RouteEntryType { get; set; }

            /// <summary>
            /// <para>The source of the BGP route. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CLOUD</b>: indicates that the current BGP route is learned by the IPsec-VPN connection from the transit router.</description></item>
            /// <item><description><b>VPN_BGP</b>: indicates that the current BGP route is learned by the IPsec-VPN connection from the data center.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CLOUD</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The status of the route.</para>
            /// <list type="bullet">
            /// <item><description><b>published</b>: indicates that the current route is advertised to the transit router.</description></item>
            /// <item><description><b>Active</b>: indicates that the current BGP route is available.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>published</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The ID of the IPsec-VPN connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vco-p0w2jpkhi2eeop6q6****</para>
            /// </summary>
            [NameInMap("VpnConnectionId")]
            [Validation(Required=false)]
            public string VpnConnectionId { get; set; }

            /// <summary>
            /// <para>The weight of the destination-based route. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: a low priority</description></item>
            /// <item><description><b>100</b>: a high priority</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

    }

}
