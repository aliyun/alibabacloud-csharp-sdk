// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterCidrResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the CIDR block.</para>
        /// </summary>
        [NameInMap("CidrLists")]
        [Validation(Required=false)]
        public List<ListTransitRouterCidrResponseBodyCidrLists> CidrLists { get; set; }
        public class ListTransitRouterCidrResponseBodyCidrLists : TeaModel {
            /// <summary>
            /// <para>The CIDR block of the transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.0/24</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <para>The description of the CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the CIDR block.</para>
            /// <para>The value is <b>IPv4</b>, which indicates that the CIDR block is of the IPv4 type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("Family")]
            [Validation(Required=false)]
            public string Family { get; set; }

            /// <summary>
            /// <para>The name of the CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the system is allowed to automatically add a route to the route table of the transit router. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b></para>
            /// <para>A value of <b>true</b> indicates that after you create a private VPN connection and enable route learning for the connection, the system automatically adds a blackhole route to the route table of the transit router to which the VPN connection is attached.</para>
            /// <para>The destination CIDR block of the blackhole route is the CIDR block of the transit router. The CIDR block of the transit router refers to the CIDR block from which gateway IP addresses are allocated to IPsec-VPN connections.</para>
            /// <para>The blackhole route is advertised only to the route table of the virtual border router (VBR) that is connected to the transit router.</para>
            /// </description></item>
            /// <item><description><para><b>false</b></para>
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
            /// <para>The transit router ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-p0w3x8c9em72a40nw****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0876E54E-3E36-5C31-89F0-9EE8A9266F9A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
