// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetOpenStoreUsageResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The current request result.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetOpenStoreUsageResponseBodyResult Result { get; set; }
        public class GetOpenStoreUsageResponseBodyResult : TeaModel {
            /// <summary>
            /// The current OpenStore storage capacity (estimated value based on actual indexes). Unit: Byte.
            /// </summary>
            [NameInMap("currentUsage")]
            [Validation(Required=false)]
            public long? CurrentUsage { get; set; }

            /// <summary>
            /// The storage capacity of OpenStore yesterday. Unit: bytes.
            /// </summary>
            [NameInMap("lastDayUsage")]
            [Validation(Required=false)]
            public long? LastDayUsage { get; set; }

        }

    }

}
