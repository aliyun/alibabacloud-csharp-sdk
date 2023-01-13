// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeRouteConflictResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The array of conflicting routes.
        /// </summary>
        [NameInMap("RouteConflicts")]
        [Validation(Required=false)]
        public DescribeRouteConflictResponseBodyRouteConflicts RouteConflicts { get; set; }
        public class DescribeRouteConflictResponseBodyRouteConflicts : TeaModel {
            [NameInMap("RouteConflict")]
            [Validation(Required=false)]
            public List<DescribeRouteConflictResponseBodyRouteConflictsRouteConflict> RouteConflict { get; set; }
            public class DescribeRouteConflictResponseBodyRouteConflictsRouteConflict : TeaModel {
                /// <summary>
                /// The destination CIDR block of the conflicting route.
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// The ID of the peer network instance on which conflicting routes are found.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The type of the peer network instance on which conflicting routes are found.
                /// 
                /// *   **VPC**
                /// *   **VBR**
                /// *   **CCN**
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The region ID of the peer network instance on which conflicting routes are found is deployed.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The cause of the route error. Valid values:
                /// 
                /// *   **conflict**: Routes have the same destination CIDR block.
                /// *   **overflow**: The number of routes in the route table configured on another network instance has reached the upper limit.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
