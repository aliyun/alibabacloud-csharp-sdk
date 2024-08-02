// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataArchiveCountResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataArchiveCountResponseBodyData Data { get; set; }
        public class GetDataArchiveCountResponseBodyData : TeaModel {
            /// <summary>
            /// The number of tickets that data archiving failed.
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            /// <summary>
            /// The number of tickets that data archiving is in progress.
            /// </summary>
            [NameInMap("ProcessingCount")]
            [Validation(Required=false)]
            public long? ProcessingCount { get; set; }

            /// <summary>
            /// The number of tickets that data archiving is successful.
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public long? SuccessCount { get; set; }

            /// <summary>
            /// The total number of data archiving tickets.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
