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

        /// <summary>
        /// <para>The list of route entries.</para>
        /// </summary>
        [NameInMap("VpnRouteEntries")]
        [Validation(Required=false)]
        public DescribeVpnRouteEntriesResponseBodyVpnRouteEntries VpnRouteEntries { get; set; }
        public class DescribeVpnRouteEntriesResponseBodyVpnRouteEntries : TeaModel {
            [NameInMap("VpnRouteEntry")]
            [Validation(Required=false)]
            public List<DescribeVpnRouteEntriesResponseBodyVpnRouteEntriesVpnRouteEntry> VpnRouteEntry { get; set; }
            public class DescribeVpnRouteEntriesResponseBodyVpnRouteEntriesVpnRouteEntry : TeaModel {
                /// <summary>
                /// <para>The AS path of the route entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65501,65001,60011</para>
                /// </summary>
                [NameInMap("AsPath")]
                [Validation(Required=false)]
                public string AsPath { get; set; }

                /// <summary>
                /// <para>The community attributes of the route entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65001:1000,65501:2000</para>
                /// </summary>
                [NameInMap("Community")]
                [Validation(Required=false)]
                public string Community { get; set; }

                /// <summary>
                /// <para>The timestamp when the route entry was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1563874074000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The next hop of the route entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vco-bp1tui07ob10fmuro****</para>
                /// </summary>
                [NameInMap("NextHop")]
                [Validation(Required=false)]
                public string NextHop { get; set; }

                /// <summary>
                /// <para>The ID of the tunnel associated with the next hop. </para>
                /// <remarks>
                /// <para>This parameter is returned only if the VPN gateway supports the dual-tunnel mode.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>tun-36cfgpwjn58axj****</para>
                /// </summary>
                [NameInMap("NextHopTunnelId")]
                [Validation(Required=false)]
                public string NextHopTunnelId { get; set; }

                /// <summary>
                /// <para>The destination CIDR block of the route entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/24</para>
                /// </summary>
                [NameInMap("RouteDest")]
                [Validation(Required=false)]
                public string RouteDest { get; set; }

                /// <summary>
                /// <para>The type of the route entry. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Custom</b>: custom</description></item>
                /// <item><description><b>System</b>: system</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>System</para>
                /// </summary>
                [NameInMap("RouteEntryType")]
                [Validation(Required=false)]
                public string RouteEntryType { get; set; }

                /// <summary>
                /// <para>The source CIDR block of the route entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.10.0/24</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The status of the route entry. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>published</b>: advertised</description></item>
                /// <item><description><b>normal</b>: not advertised</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The ID of the VPN gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpn-bp1cmw7jh1nfe43m9****</para>
                /// </summary>
                [NameInMap("VpnInstanceId")]
                [Validation(Required=false)]
                public string VpnInstanceId { get; set; }

                /// <summary>
                /// <para>The weight of the route entry. Valid values: <b>0</b> and <b>100</b>.</para>
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

}
