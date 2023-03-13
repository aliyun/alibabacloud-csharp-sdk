// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterCidrResponseBody : TeaModel {
        /// <summary>
        /// The CIDR blocks of the transit router.
        /// </summary>
        [NameInMap("CidrLists")]
        [Validation(Required=false)]
        public List<ListTransitRouterCidrResponseBodyCidrLists> CidrLists { get; set; }
        public class ListTransitRouterCidrResponseBodyCidrLists : TeaModel {
            /// <summary>
            /// The CIDR block of the transit router.
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
            /// The value is set to **IPv4**, which indicates that the CIDR block is of the IPv4 type.
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
            /// Indicates whether the system is allowed to automatically add a route to the route table of the transit router.
            /// 
            /// *   **true**: yes.
            /// 
            ///         A value of true indicates that if you create a private VPN connection and add a route learning policy for the VPC connection, the system automatically adds the following route to the route table of the transit router that is in route learning relationship with the VPN connection:
            ///           A blackhole route whose destination CIDR block is the CIDR block of the transit router. The CIDR block of the transit router refers to the CIDR block from which gateway IP addresses are allocated to IPsec-VPN connections. 
            ///           The blackhole route is advertised only to the route tables of VBRs that are connected to the transit router. 
            /// 
            /// *   **false**: no.
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
