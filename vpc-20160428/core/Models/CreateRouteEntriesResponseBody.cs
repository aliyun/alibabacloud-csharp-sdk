// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// The number of custom route entries that failed to be added.
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// The details about the custom route entry that failed to be added.
        /// </summary>
        [NameInMap("FailedRouteEntries")]
        [Validation(Required=false)]
        public List<CreateRouteEntriesResponseBodyFailedRouteEntries> FailedRouteEntries { get; set; }
        public class CreateRouteEntriesResponseBodyFailedRouteEntries : TeaModel {
            /// <summary>
            /// The destination CIDR block of the custom route entry that failed to be added.
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
            /// The ID of the next hop of the custom route entry that failed to be added.
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the ID of the custom route entry that was successfully added.
        /// </summary>
        [NameInMap("RouteEntryIds")]
        [Validation(Required=false)]
        public List<string> RouteEntryIds { get; set; }

        /// <summary>
        /// The number of custom route entries that were successfully added.
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

    }

}
