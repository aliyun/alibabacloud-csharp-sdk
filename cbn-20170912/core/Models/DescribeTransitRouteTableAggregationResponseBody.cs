// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeTransitRouteTableAggregationResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// A list of aggregate routes.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeTransitRouteTableAggregationResponseBodyData> Data { get; set; }
        public class DescribeTransitRouteTableAggregationResponseBodyData : TeaModel {
            /// <summary>
            /// The description of the aggregate route.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the aggregate route.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the aggregate route.
            /// 
            /// The valid value is **Static**, which indicates a static route. By default, aggregate routes advertised to a VPC are considered custom routes.
            /// </summary>
            [NameInMap("RouteType")]
            [Validation(Required=false)]
            public string RouteType { get; set; }

            /// <summary>
            /// The cope of networks to which the aggregate route is advertised.
            /// 
            /// The valid value is **VPC**, which indicates that the aggregate route is advertised to all virtual private clouds (VPCs) that are in associated forwarding correlation with the Enterprise Edition transit router and have route synchronization enabled.
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// The status of the advertisement of the aggregate route. Valid values:
            /// 
            /// *   **AllConfigured**: The aggregate route is advertised to all VPCs.
            /// *   **Configuring**: The aggregate route is being advertised.
            /// *   **ConfigFailed**: The aggregate route failed to be advertised.
            /// *   **PartialConfigured**: Failed to advertise the aggregate route to some VPCs.
            /// *   **Deleting**: The aggregate route is being deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the route table of the Enterprise Edition transit router.
            /// </summary>
            [NameInMap("TrRouteTableId")]
            [Validation(Required=false)]
            public string TrRouteTableId { get; set; }

            /// <summary>
            /// The destination CIDR block of the aggregate route.
            /// </summary>
            [NameInMap("TransitRouteTableAggregationCidr")]
            [Validation(Required=false)]
            public string TransitRouteTableAggregationCidr { get; set; }

        }

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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
