// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagRouteListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE6642D4-21EB-4168-9BF9-F217953F9892</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The routes.</para>
        /// </summary>
        [NameInMap("Routes")]
        [Validation(Required=false)]
        public List<DescribeSagRouteListResponseBodyRoutes> Routes { get; set; }
        public class DescribeSagRouteListResponseBodyRoutes : TeaModel {
            /// <summary>
            /// <para>The list of CIDR blocks that overlap with each other.</para>
            /// </summary>
            [NameInMap("ConflictCidrs")]
            [Validation(Required=false)]
            public List<string> ConflictCidrs { get; set; }

            /// <summary>
            /// <para>The cost of the route.</para>
            /// <para>The number on the left side of the forward slash (/) indicates the administrative distance (AD) of the routing protocol.</para>
            /// <para>The number on the right side of the forward slash (/) indicates the metric value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[110/11]</para>
            /// </summary>
            [NameInMap("Cost")]
            [Validation(Required=false)]
            public string Cost { get; set; }

            /// <summary>
            /// <para>The destination CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6.XX.XX.6/32</para>
            /// </summary>
            [NameInMap("DestinationCidr")]
            [Validation(Required=false)]
            public string DestinationCidr { get; set; }

            /// <summary>
            /// <para>The next hop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XX.XX.1</para>
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            /// <summary>
            /// <para>The name of the port. If the port name is -1, data is transferred through a VPN tunnel to Alibaba Cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            /// <summary>
            /// <para>The routing protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>STATIC</b>: a static routing protocol.</description></item>
            /// <item><description><b>OSPF</b>: the Open Shortest Path First (OSPF) dynamic routing protocol.</description></item>
            /// <item><description><b>BGP</b>: the Border Gateway Protocol (BGP) dynamic routing protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STATIC</para>
            /// </summary>
            [NameInMap("RouteProtocol")]
            [Validation(Required=false)]
            public string RouteProtocol { get; set; }

        }

    }

}
