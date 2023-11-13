// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebAccessLogDispatchStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the log analysis feature is enabled for domain names.
        /// </summary>
        [NameInMap("SlsConfigStatus")]
        [Validation(Required=false)]
        public List<DescribeWebAccessLogDispatchStatusResponseBodySlsConfigStatus> SlsConfigStatus { get; set; }
        public class DescribeWebAccessLogDispatchStatusResponseBodySlsConfigStatus : TeaModel {
            /// <summary>
            /// The domain name.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// Indicates whether the log analysis feature is enabled. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
