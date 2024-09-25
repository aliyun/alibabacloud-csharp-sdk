// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnPbrRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BE01CD7-5A50-472D-AC14-CA181C5C03BE</para>
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
        /// <para>The list of policy-based routes.</para>
        /// </summary>
        [NameInMap("VpnPbrRouteEntries")]
        [Validation(Required=false)]
        public DescribeVpnPbrRouteEntriesResponseBodyVpnPbrRouteEntries VpnPbrRouteEntries { get; set; }
        public class DescribeVpnPbrRouteEntriesResponseBodyVpnPbrRouteEntries : TeaModel {
            [NameInMap("VpnPbrRouteEntry")]
            [Validation(Required=false)]
            public List<DescribeVpnPbrRouteEntriesResponseBodyVpnPbrRouteEntriesVpnPbrRouteEntry> VpnPbrRouteEntry { get; set; }
            public class DescribeVpnPbrRouteEntriesResponseBodyVpnPbrRouteEntriesVpnPbrRouteEntry : TeaModel {
                /// <summary>
                /// <para>The time when the policy-based route was created. Unit: millisecond.</para>
                /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1492747187000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The next hop of the policy-based route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vco-bp15oes1py4i66rmd****</para>
                /// </summary>
                [NameInMap("NextHop")]
                [Validation(Required=false)]
                public string NextHop { get; set; }

                /// <summary>
                /// <para>The ID of the tunnel associated with the next hop of the policy-based route.</para>
                /// <para>This parameter is returned only if the VPN gateway supports IPsec-VPN connections in dual-tunnel mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tun-opsqc4d97wni2****</para>
                /// </summary>
                [NameInMap("NextHopTunnelId")]
                [Validation(Required=false)]
                public string NextHopTunnelId { get; set; }

                /// <summary>
                /// <para>The priority of the policy-based route.</para>
                /// <para>A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The destination CIDR block of the policy-based route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/24</para>
                /// </summary>
                [NameInMap("RouteDest")]
                [Validation(Required=false)]
                public string RouteDest { get; set; }

                /// <summary>
                /// <para>The source CIDR block of the policy-based route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.0/24</para>
                /// </summary>
                [NameInMap("RouteSource")]
                [Validation(Required=false)]
                public string RouteSource { get; set; }

                /// <summary>
                /// <para>The status of the policy-based route. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>published</b>: advertised to the VPC route table.</description></item>
                /// <item><description><b>normal</b>: not advertised to the VPC route table.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>published</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The ID of the VPN gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpn-bp1a3kqjiiq9legfx****</para>
                /// </summary>
                [NameInMap("VpnInstanceId")]
                [Validation(Required=false)]
                public string VpnInstanceId { get; set; }

                /// <summary>
                /// <para>The weight of the policy-based route.</para>
                /// <para>For a VPN gateway that supports IPsec-VPN connections in single-tunnel mode, the weight of a policy-based route indicates the priority of the route.</para>
                /// <list type="bullet">
                /// <item><description><b>100</b>: a high priority If multiple policy-based routes with the same source CIDR block and destination CIDR block exist, the IPsec-VPN connection associated with the policy-based route is the active connection.</description></item>
                /// <item><description><b>0</b>: a low priority If multiple policy-based routes with the same source CIDR block and destination CIDR block exist, the IPsec-VPN connection associated with the policy-based route is the standby connection.</description></item>
                /// </list>
                /// <remarks>
                /// <para> For a VPN gateway that does not support IPsec-VPN connections in single-tunnel mode, this parameter does not take effect.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

    }

}
