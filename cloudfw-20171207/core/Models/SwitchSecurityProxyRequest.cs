// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class SwitchSecurityProxyRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The route entry list for routing to be redirected or un-redirected. Maximum number of entries: 10,000. When RouteAction (divert or undivert) is specified, a non-empty list must be provided and used according to the incremental semantics. Each entry must include the RouteTableId, DestinationCidr, NextHopId, and NextHopType fields, and the combination of RouteTableId and DestinationCidr must be unique. In the Gateway Load Balancer (GWLB) architecture, when committed together with Switch=open, this parameter is used to specify the route entry for which traffic redirection is enabled in the current request. If no list is provided, the saved list is used. If no active list exists, a parameter error is returned.</para>
        /// </summary>
        [NameInMap("NatRouteEntryList")]
        [Validation(Required=false)]
        public List<SwitchSecurityProxyRequestNatRouteEntryList> NatRouteEntryList { get; set; }
        public class SwitchSecurityProxyRequestNatRouteEntryList : TeaModel {
            /// <summary>
            /// <para>The destination CIDR block of the route entry. When RouteAction is specified, only the default route 0.0.0.0/0 is supported. If other CIDR blocks are passed, a parameter error is returned.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("DestinationCidr")]
            [Validation(Required=false)]
            public string DestinationCidr { get; set; }

            /// <summary>
            /// <para>The ID of the NAT gateway to which the route entry pointed before traffic redirection. You can obtain the ID by calling the DescribeSecurityProxyResources operation. When RouteAction is specified, this value must be consistent with the NAT gateway involved in the current operation. When traffic redirection is disabled, you must still pass this NAT gateway ID instead of the current next hop ID of the firewall.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-bp1a2b3c4d5e6f7g8h9i0</para>
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// <para>The next hop type of the route entry before traffic redirection. When RouteAction is specified, this value is fixed to NatGateway and must be passed in pairs with NextHopId. If other values are passed, a parameter error is returned.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NatGateway</para>
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// <para>The ID of the route table to which the route entry belongs. The route table must exist in the user&quot;s VPC. This parameter and DestinationCidr are used together to locate a route. If the route does not exist, the task fails and a message indicating that the route entry does not exist is returned.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-bp1a2b3c4d5e6f7g8h9i0</para>
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the NAT firewall.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proxy-natbf******</para>
        /// </summary>
        [NameInMap("ProxyId")]
        [Validation(Required=false)]
        public string ProxyId { get; set; }

        /// <summary>
        /// <para>Makes incremental traffic redirection changes to the route entry passed in this request. Other redirected route tables in the list are not affected. Valid values: divert (enables traffic redirection for the passed route entry) and undivert (shutdown of traffic redirection for the passed route entry). This parameter is active only when the firewall is in the traffic redirection state (normal). This parameter and Switch are mutually exclusive and cannot be both set to non-empty values at the same time. If this parameter is not specified or is set to an empty string, the incremental semantics are not used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>divert</para>
        /// </summary>
        [NameInMap("RouteAction")]
        [Validation(Required=false)]
        public string RouteAction { get; set; }

        /// <summary>
        /// <para>The security protection switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>open: Enabled.</description></item>
        /// <item><description>close: Disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("Switch")]
        [Validation(Required=false)]
        public string Switch { get; set; }

    }

}
