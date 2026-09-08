// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterCidrResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of transit router CIDR blocks.</para>
        /// </summary>
        [NameInMap("CidrLists")]
        [Validation(Required=false)]
        public List<ListTransitRouterCidrResponseBodyCidrLists> CidrLists { get; set; }
        public class ListTransitRouterCidrResponseBodyCidrLists : TeaModel {
            /// <summary>
            /// <para>The transit router CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.0/24</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <para>The description of the transit router CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the transit router CIDR block.</para>
            /// <para>The value is <b>IPv4</b> only, which indicates that the transit router CIDR block is of the IPv4 type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("Family")]
            [Validation(Required=false)]
            public string Family { get; set; }

            /// <summary>
            /// <para>The name of the transit router CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the system is allowed to automatically add a route for the transit router CIDR block to the transit router route table.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: allowed.</para>
            /// <para>  If the value of this parameter is <b>true</b>, after you create a VPN connection of the private gateway type and create a route learning relationship for the VPN connection, the system automatically adds a route entry to the transit router route table that has a route learning relationship with the VPN connection:</para>
            /// <para>The route entry is a blackhole route whose destination CIDR block is the transit router CIDR block from which gateway IP addresses have been allocated to the IPsec connection.</para>
            /// <para>The blackhole route is propagated only to the route tables of VBR instances associated with the transit router.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: not allowed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PublishCidrRoute")]
            [Validation(Required=false)]
            public bool? PublishCidrRoute { get; set; }

            /// <summary>
            /// <para>The ID of the transit router CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cidr-0zv0q9crqpntzz****</para>
            /// </summary>
            [NameInMap("TransitRouterCidrId")]
            [Validation(Required=false)]
            public string TransitRouterCidrId { get; set; }

            /// <summary>
            /// <para>The ID of the transit router instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-p0w3x8c9em72a40nw****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0876E54E-3E36-5C31-89F0-9EE8A9266F9A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
