// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListGatewayRouteTableEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the routes in the gateway route table.</para>
        /// </summary>
        [NameInMap("GatewayRouteEntryModels")]
        [Validation(Required=false)]
        public List<ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModels> GatewayRouteEntryModels { get; set; }
        public class ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModels : TeaModel {
            /// <summary>
            /// <para>The name of the route entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.5</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The name of the route entry.</para>
            /// <para>The name must be 2 to 128 characters in length and can contain letter, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the next hop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp11gcl0sm85t9bi****</para>
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// <para>The type of the next hop. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>EcsInstance</b>: Elastic Compute Service (ECS) instance</description></item>
            /// <item><description><b>NetworkInterface</b>: elastic network interfaces (ENIs).</description></item>
            /// <item><description><b>Local</b>: local next hop</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EcsInstance</para>
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// <para>The information about the next hop.</para>
            /// </summary>
            [NameInMap("NextHops")]
            [Validation(Required=false)]
            public List<ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModelsNextHops> NextHops { get; set; }
            public class ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModelsNextHops : TeaModel {
                /// <summary>
                /// <para>Indicates whether the route is available. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: unavailable</description></item>
                /// <item><description><b>1</b>: available</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public string Enabled { get; set; }

                /// <summary>
                /// <para>The ID of the next hop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpn-bp10zyaph5cc8b7c7****</para>
                /// </summary>
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                /// <summary>
                /// <para>The type of the next hop. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Instance</b> (default): an ECS instance</description></item>
                /// <item><description><b>HaVip</b>: a high-availability virtual IP address (HAVIP).</description></item>
                /// <item><description><b>VpnGateway</b>: a VPN gateway</description></item>
                /// <item><description><b>NatGateway</b>: a NAT gateway</description></item>
                /// <item><description><b>NetworkInterface</b>: a secondary ENI</description></item>
                /// <item><description><b>RouterInterface</b>: a router interface</description></item>
                /// <item><description><b>IPv6Gateway</b>: an IPv6 gateway</description></item>
                /// <item><description><b>Attachment</b>: a transit router</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Instance</para>
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                /// <summary>
                /// <para>The weight of the route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public string Weight { get; set; }

            }

            /// <summary>
            /// <para>The status of the route entry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b></description></item>
            /// <item><description><b>Available</b></description></item>
            /// <item><description><b>Modifying</b></description></item>
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
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is used to retrieve a new page of results.</description></item>
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
