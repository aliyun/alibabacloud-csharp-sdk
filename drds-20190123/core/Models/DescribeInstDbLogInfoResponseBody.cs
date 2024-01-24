// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstDbLogInfoResponseBody : TeaModel {
        /// <summary>
        /// The time range for log query.
        /// </summary>
        [NameInMap("LogTimeRange")]
        [Validation(Required=false)]
        public DescribeInstDbLogInfoResponseBodyLogTimeRange LogTimeRange { get; set; }
        public class DescribeInstDbLogInfoResponseBodyLogTimeRange : TeaModel {
            /// <summary>
            /// The start time of the query time range.
            /// </summary>
            [NameInMap("SupportLatestTime")]
            [Validation(Required=false)]
            public long? SupportLatestTime { get; set; }

            /// <summary>
            /// The end time of the task.
            /// </summary>
            [NameInMap("SupportOldestTime")]
            [Validation(Required=false)]
            public long? SupportOldestTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
