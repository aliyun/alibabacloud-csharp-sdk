// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRouteEntryListResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the route.
        /// </summary>
        [NameInMap("RouteEntrys")]
        [Validation(Required=false)]
        public List<DescribeEnsRouteEntryListResponseBodyRouteEntrys> RouteEntrys { get; set; }
        public class DescribeEnsRouteEntryListResponseBodyRouteEntrys : TeaModel {
            /// <summary>
            /// Enter a description for the route.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The destination CIDR block of the route.
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// The information about the next hop.
            /// </summary>
            [NameInMap("NextHops")]
            [Validation(Required=false)]
            public List<DescribeEnsRouteEntryListResponseBodyRouteEntrysNextHops> NextHops { get; set; }
            public class DescribeEnsRouteEntryListResponseBodyRouteEntrysNextHops : TeaModel {
                /// <summary>
                /// The ID of the next hop.
                /// </summary>
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                /// <summary>
                /// The type of the next hop. Valid values:
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

            }

            /// <summary>
            /// The ID of the route.
            /// </summary>
            [NameInMap("RouteEntryId")]
            [Validation(Required=false)]
            public string RouteEntryId { get; set; }

            /// <summary>
            /// The name of the route.
            /// </summary>
            [NameInMap("RouteEntryName")]
            [Validation(Required=false)]
            public string RouteEntryName { get; set; }

            /// <summary>
            /// The ID of the route table.
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

            /// <summary>
            /// The status of the route entry. Valid values:
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The type of the route entry.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
