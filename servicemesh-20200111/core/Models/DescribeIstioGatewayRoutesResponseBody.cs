// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeIstioGatewayRoutesResponseBody : TeaModel {
        /// <summary>
        /// The routing rules.
        /// </summary>
        [NameInMap("ManagementRoutes")]
        [Validation(Required=false)]
        public List<DescribeIstioGatewayRoutesResponseBodyManagementRoutes> ManagementRoutes { get; set; }
        public class DescribeIstioGatewayRoutesResponseBodyManagementRoutes : TeaModel {
            /// <summary>
            /// The name of the ASM gateway.
            /// </summary>
            [NameInMap("ASMGatewayName")]
            [Validation(Required=false)]
            public string ASMGatewayName { get; set; }

            /// <summary>
            /// The description of the routing rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DestinationHost")]
            [Validation(Required=false)]
            public List<string> DestinationHost { get; set; }

            [NameInMap("DestinationSubSet")]
            [Validation(Required=false)]
            public List<string> DestinationSubSet { get; set; }

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The priority of the routing rule. The value of this parameter is an integer. A smaller value indicates a higher priority.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The name of the routing rule.
            /// </summary>
            [NameInMap("RouteName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }

            /// <summary>
            /// The path that is used to match request URLs.
            /// </summary>
            [NameInMap("RoutePath")]
            [Validation(Required=false)]
            public string RoutePath { get; set; }

            /// <summary>
            /// The status of the routing rule. Valid values:
            /// 
            /// *   `0`: The routing rule is valid.
            /// *   `1`: The routing rule is invalid.
            /// *   `2`: An error occurs during the creation or update of the routing rule.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
