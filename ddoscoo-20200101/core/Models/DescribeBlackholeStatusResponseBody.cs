// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeBlackholeStatusResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the blackhole filtering status of the instance.
        /// </summary>
        [NameInMap("BlackholeStatus")]
        [Validation(Required=false)]
        public List<DescribeBlackholeStatusResponseBodyBlackholeStatus> BlackholeStatus { get; set; }
        public class DescribeBlackholeStatusResponseBodyBlackholeStatus : TeaModel {
            /// <summary>
            /// Indicates whether blackhole filtering is triggered for the instance. Valid values:
            /// 
            /// *   **blackhole**: yes
            /// *   **normal**: no
            /// </summary>
            [NameInMap("BlackStatus")]
            [Validation(Required=false)]
            public string BlackStatus { get; set; }

            /// <summary>
            /// The end time of blackhole filtering. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The IP address of the instance.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The start time of blackhole filtering. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
