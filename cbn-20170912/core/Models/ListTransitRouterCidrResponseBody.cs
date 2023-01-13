// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterCidrResponseBody : TeaModel {
        /// <summary>
        /// The information about the CIDR block.
        /// </summary>
        [NameInMap("CidrLists")]
        [Validation(Required=false)]
        public List<ListTransitRouterCidrResponseBodyCidrLists> CidrLists { get; set; }
        public class ListTransitRouterCidrResponseBodyCidrLists : TeaModel {
            /// <summary>
            /// The CIDR block.
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// The description of the CIDR block.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The type of the CIDR block.
            /// 
            /// Set the value to **IPv4**, which indicates that the CIDR block is of the IPv4 type.
            /// </summary>
            [NameInMap("Family")]
            [Validation(Required=false)]
            public string Family { get; set; }

            /// <summary>
            /// The name of the CIDR block.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Indicates whether to allow the system to automatically add routes that point to the CIDR block to the route table of the transit router.
            /// 
            /// *   **true**: yes
            /// 
            ///     A value of **true** specifies that after you create a private VPN connection and enable route learning for the connection, the system automatically adds a blackhole route to the route table of the transit route to which the VPN connection is attached.
            /// 
            ///     The destination CIDR block of the blackhole route is the CIDR block of the transit router. The CIDR block of the transit router refers to the CIDR block from which gateway IP addresses are allocated to IPsec-VPN connections.
            /// 
            ///     The blackhole route is advertised only to the route table of the virtual border router (VBR) that is connected to the transit router.
            /// 
            /// *   **false**: no
            /// </summary>
            [NameInMap("PublishCidrRoute")]
            [Validation(Required=false)]
            public bool? PublishCidrRoute { get; set; }

            /// <summary>
            /// The ID of the CIDR block.
            /// </summary>
            [NameInMap("TransitRouterCidrId")]
            [Validation(Required=false)]
            public string TransitRouterCidrId { get; set; }

            /// <summary>
            /// The ID of the transit router.
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
