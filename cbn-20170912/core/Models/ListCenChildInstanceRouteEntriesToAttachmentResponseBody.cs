// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListCenChildInstanceRouteEntriesToAttachmentResponseBody : TeaModel {
        /// <summary>
        /// The token that determines the start point of the next query. Valid values:
        /// 
        /// *   If **NextToken** is not returned, it indicates that no additional results exist.
        /// *   If **NextToken** was returned in the previous query, specify the value to obtain the next set of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The detailed information about the route.
        /// </summary>
        [NameInMap("RouteEntry")]
        [Validation(Required=false)]
        public List<ListCenChildInstanceRouteEntriesToAttachmentResponseBodyRouteEntry> RouteEntry { get; set; }
        public class ListCenChildInstanceRouteEntriesToAttachmentResponseBodyRouteEntry : TeaModel {
            /// <summary>
            /// The ID of the CEN instance.
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// The ID of the route table configured on the network instance.
            /// </summary>
            [NameInMap("ChildInstanceRouteTableId")]
            [Validation(Required=false)]
            public string ChildInstanceRouteTableId { get; set; }

            /// <summary>
            /// The destination CIDR block of the route.
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// Indicates whether the route is hosted. If the parameter is empty, the route is not hosted. A value of TR indicates that the route is hosted on a transit router.
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// The status of the route. Valid values:
            /// 
            /// *   **Available**: The route is available.
            /// *   **Pending**: The route is being configured.
            /// *   **Modifying**: the route is being modified.
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

        }

    }

}
