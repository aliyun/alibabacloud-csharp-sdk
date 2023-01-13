// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteTablePropagationsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token for returning the next page when the data is returned in more than one page.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The list of route learning correlations.
        /// </summary>
        [NameInMap("TransitRouterPropagations")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteTablePropagationsResponseBodyTransitRouterPropagations> TransitRouterPropagations { get; set; }
        public class ListTransitRouterRouteTablePropagationsResponseBodyTransitRouterPropagations : TeaModel {
            /// <summary>
            /// The ID of the next hop.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The type of next hop. Valid values:
            /// 
            /// *   **VPC**: a virtual private cloud (VPC)
            /// *   **CCN**: a Cloud Connect Network (CCN) instance
            /// *   **VBR**: a VBR
            /// *   **TR**: a transit router
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The state of the route learning correlation. Valid values:
            /// 
            /// *   **Enabling**
            /// *   **Disabling**
            /// *   **Active**
            /// *   **Deleted**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the network instance connection.
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// The ID of the route table of the Enterprise Edition transit router.
            /// </summary>
            [NameInMap("TransitRouterRouteTableId")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableId { get; set; }

        }

    }

}
