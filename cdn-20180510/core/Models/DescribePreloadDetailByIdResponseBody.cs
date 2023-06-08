// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribePreloadDetailByIdResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request. You can use the ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of queried tasks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The details of the task, including the task ID, start time, end time, domain name, success rate, status, returned error code, and completion details of all URL resources.
        /// </summary>
        [NameInMap("UrlDetails")]
        [Validation(Required=false)]
        public List<DescribePreloadDetailByIdResponseBodyUrlDetails> UrlDetails { get; set; }
        public class DescribePreloadDetailByIdResponseBodyUrlDetails : TeaModel {
            /// <summary>
            /// The time when the task was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The domain name for prefetching resources.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The time when the task ended. The time is displayed in UTC.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The progress of the prefetch task, which indicates the number of points of presence (POPs) on which the prefetch task is completed.
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

            /// <summary>
            /// The turned error code. A value of `0` indicates that the task succeeded.
            /// </summary>
            [NameInMap("RetCode")]
            [Validation(Required=false)]
            public string RetCode { get; set; }

            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   **Complete**
            /// *   **Refreshing**
            /// *   **Failed**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the task that you want to query.
            /// 
            /// You can call the PushObjectCache operation to query task IDs. Then, you can use the task IDs to query task status.
            /// 
            /// You can query one task ID at a time.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The completion details of all URL resources in the task.
            /// </summary>
            [NameInMap("Urls")]
            [Validation(Required=false)]
            public List<DescribePreloadDetailByIdResponseBodyUrlDetailsUrls> Urls { get; set; }
            public class DescribePreloadDetailByIdResponseBodyUrlDetailsUrls : TeaModel {
                /// <summary>
                /// The details of resource prefetch.
                /// 
                /// *   If the resource is prefetched on all POPs, "Successfully preloaded" is returned.
                /// *   If the resource fails to be prefetched on some POPs, the failure details separated by vertical bars (|) are returned.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The success percentage, which indicates the number of POPs on which the resource is prefetched.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public string Success { get; set; }

                /// <summary>
                /// The URL of the prefetched resource.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}
