// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListGatewayRouteTableEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of route entries in the gateway route table.</para>
        /// </summary>
        [NameInMap("GatewayRouteEntryModels")]
        [Validation(Required=false)]
        public List<ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModels> GatewayRouteEntryModels { get; set; }
        public class ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModels : TeaModel {
            /// <summary>
            /// <para>The description of the route entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the route entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.5</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The name of the route entry.</para>
            /// <para>The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The instance ID of the next hop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp11gcl0sm85t9bi****</para>
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// <para>The next hop type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>EcsInstance</b>: ECS instance.</description></item>
            /// <item><description><b>NetworkInterface</b>: elastic network interfaces (ENIs).</description></item>
            /// <item><description><b>Local</b>: local.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EcsInstance</para>
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// <para>The next hop information.</para>
            /// </summary>
            [NameInMap("NextHops")]
            [Validation(Required=false)]
            public List<ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModelsNextHops> NextHops { get; set; }
            public class ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModelsNextHops : TeaModel {
                /// <summary>
                /// <para>Indicates whether the route is available. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: unavailable.</description></item>
                /// <item><description><b>1</b>: available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public string Enabled { get; set; }

                /// <summary>
                /// <para>The instance ID of the next hop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpn-bp10zyaph5cc8b7c7****</para>
                /// </summary>
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                /// <summary>
                /// <para>The next hop type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Instance</b> (default): ECS instance.</description></item>
                /// <item><description><b>HaVip</b>: high-availability virtual IP address (HaVip).</description></item>
                /// <item><description><b>VpnGateway</b>: VPN gateway.</description></item>
                /// <item><description><b>NatGateway</b>: NAT gateway.</description></item>
                /// <item><description><b>NetworkInterface</b>: secondary elastic network interfaces (ENIs).</description></item>
                /// <item><description><b>RouterInterface</b>: vRouter interface.</description></item>
                /// <item><description><b>IPv6Gateway</b>: IPv6 gateway.</description></item>
                /// <item><description><b>Attachment</b>: transit router.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Instance</para>
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                /// <summary>
                /// <para>The weight of the route entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public string Weight { get; set; }

            }

            /// <summary>
            /// <para>The status of the route entry.</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b>: being configured.</description></item>
            /// <item><description><b>Available</b>: available.</description></item>
            /// <item><description><b>Modifying</b>: being modified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The pagination token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no subsequent query exists.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
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
        public string TotalCount { get; set; }

    }

}
