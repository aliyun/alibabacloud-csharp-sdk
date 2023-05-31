// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLogMetaResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the configurations of the log analysis feature.
        /// </summary>
        [NameInMap("LogMetaList")]
        [Validation(Required=false)]
        public List<DescribeLogMetaResponseBodyLogMetaList> LogMetaList { get; set; }
        public class DescribeLogMetaResponseBodyLogMetaList : TeaModel {
            /// <summary>
            /// The category of logs. Valid values:
            /// 
            /// *   **host**: host logs
            /// *   **network**: network logs
            /// *   **security**: security logs
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The time period after which logs in hot storage are moved to cold storage. Unit: days.
            /// 
            /// >  If the value is **-1**, logs that are stored in hot storage are not moved to cold storage.
            /// </summary>
            [NameInMap("HotTtl")]
            [Validation(Required=false)]
            public int? HotTtl { get; set; }

            /// <summary>
            /// The name of the log type.
            /// </summary>
            [NameInMap("LogDesc")]
            [Validation(Required=false)]
            public string LogDesc { get; set; }

            /// <summary>
            /// The name of the dedicated Logstore in which logs are stored.
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// The name of the project.
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// The status of the log analysis feature. Valid values:
            /// 
            /// *   **disabled**
            /// *   **enabled**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The topic of logs that are delivered.
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// The number of days during which logs can be retained.
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// The name of the dedicated Logstore in which user logs are stored.
            /// </summary>
            [NameInMap("UserLogStore")]
            [Validation(Required=false)]
            public string UserLogStore { get; set; }

            /// <summary>
            /// The name of the dedicated project in which logs are stored.
            /// </summary>
            [NameInMap("UserProject")]
            [Validation(Required=false)]
            public string UserProject { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("UserRegion")]
            [Validation(Required=false)]
            public string UserRegion { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
