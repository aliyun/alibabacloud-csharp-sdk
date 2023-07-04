// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVpcRouteEntrySummaryResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the routes in the route tables.
        /// </summary>
        [NameInMap("RouteEntrySummarys")]
        [Validation(Required=false)]
        public List<GetVpcRouteEntrySummaryResponseBodyRouteEntrySummarys> RouteEntrySummarys { get; set; }
        public class GetVpcRouteEntrySummaryResponseBodyRouteEntrySummarys : TeaModel {
            /// <summary>
            /// The information about the routes of different types in one route table.
            /// </summary>
            [NameInMap("EntrySummarys")]
            [Validation(Required=false)]
            public List<GetVpcRouteEntrySummaryResponseBodyRouteEntrySummarysEntrySummarys> EntrySummarys { get; set; }
            public class GetVpcRouteEntrySummaryResponseBodyRouteEntrySummarysEntrySummarys : TeaModel {
                /// <summary>
                /// The number of entries returned.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The type of the route. Valid values:
                /// 
                /// *   **All**: all route types
                /// *   **Custom**: a custom route
                /// *   **System**: a system route
                /// *   **BGP**: a BGP route
                /// *   **CEN**: a CEN route
                /// </summary>
                [NameInMap("RouteEntryType")]
                [Validation(Required=false)]
                public string RouteEntryType { get; set; }

            }

            /// <summary>
            /// The ID of the route table.
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

    }

}
