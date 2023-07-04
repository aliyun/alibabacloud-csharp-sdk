// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DeleteRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// The number of route entries that failed to be deleted.
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// The information about the route entry that failed to be deleted.
        /// </summary>
        [NameInMap("FailedRouteEntries")]
        [Validation(Required=false)]
        public List<DeleteRouteEntriesResponseBodyFailedRouteEntries> FailedRouteEntries { get; set; }
        public class DeleteRouteEntriesResponseBodyFailedRouteEntries : TeaModel {
            /// <summary>
            /// The destination CIDR block of the route entry that failed to be deleted. IPv4 and IPv6 CIDR blocks are supported.
            /// </summary>
            [NameInMap("DstCidrBlock")]
            [Validation(Required=false)]
            public string DstCidrBlock { get; set; }

            /// <summary>
            /// The error code.
            /// </summary>
            [NameInMap("FailedCode")]
            [Validation(Required=false)]
            public string FailedCode { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("FailedMessage")]
            [Validation(Required=false)]
            public string FailedMessage { get; set; }

            /// <summary>
            /// The ID of the next hop that failed to be deleted.
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            /// <summary>
            /// The ID of the route entry that failed to be deleted.
            /// </summary>
            [NameInMap("RouteEntryId")]
            [Validation(Required=false)]
            public string RouteEntryId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of route entries that were deleted.
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

    }

}
