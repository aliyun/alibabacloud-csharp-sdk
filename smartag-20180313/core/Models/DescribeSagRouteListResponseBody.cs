// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagRouteListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE6642D4-21EB-4168-9BF9-F217953F9892</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of routes.</para>
        /// </summary>
        [NameInMap("Routes")]
        [Validation(Required=false)]
        public List<DescribeSagRouteListResponseBodyRoutes> Routes { get; set; }
        public class DescribeSagRouteListResponseBodyRoutes : TeaModel {
            /// <summary>
            /// <para>The list of conflicting CIDR blocks.</para>
            /// </summary>
            [NameInMap("ConflictCidrs")]
            [Validation(Required=false)]
            public List<string> ConflictCidrs { get; set; }

            /// <summary>
            /// <para>The routing cost value. The number to the left of the forward slash (/) indicates the administrative distance (AD) of the routing protocol. The number to the right of the forward slash (/) indicates the metric.</para>
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
            /// <para>The port name. A value of -1 indicates that data traffic enters Alibaba Cloud through a VPN connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            /// <summary>
            /// <para>The routing protocol type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>STATIC</b>: Static routing protocol.</description></item>
            /// <item><description><b>OSPF</b>: OSPF dynamic routing protocol.</description></item>
            /// <item><description><b>BGP</b>: BGP dynamic routing protocol.</description></item>
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
