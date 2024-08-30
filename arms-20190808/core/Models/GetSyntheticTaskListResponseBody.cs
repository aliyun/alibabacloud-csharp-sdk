// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSyntheticTaskListResponseBody : TeaModel {
        /// <summary>
        /// The query results.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetSyntheticTaskListResponseBodyPageInfo PageInfo { get; set; }
        public class GetSyntheticTaskListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// Indicates whether the current page is followed by a page.
            /// </summary>
            [NameInMap("HasNextPage")]
            [Validation(Required=false)]
            public string HasNextPage { get; set; }

            /// <summary>
            /// Indicates whether a previous page exists.
            /// </summary>
            [NameInMap("HasPreviousPage")]
            [Validation(Required=false)]
            public bool? HasPreviousPage { get; set; }

            /// <summary>
            /// Indicates whether the page is the first page.
            /// </summary>
            [NameInMap("IsFirstPage")]
            [Validation(Required=false)]
            public bool? IsFirstPage { get; set; }

            /// <summary>
            /// Indicates whether the page is the last page.
            /// </summary>
            [NameInMap("IsLastPage")]
            [Validation(Required=false)]
            public bool? IsLastPage { get; set; }

            /// <summary>
            /// The task information.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetSyntheticTaskListResponseBodyPageInfoList> List { get; set; }
            public class GetSyntheticTaskListResponseBodyPageInfoList : TeaModel {
                /// <summary>
                /// The time when the task was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The number of detection points.
                /// </summary>
                [NameInMap("MonitorNumber")]
                [Validation(Required=false)]
                public long? MonitorNumber { get; set; }

                /// <summary>
                /// The ID of the synthetic monitoring task.
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// The task name.
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// The status of the task. Valid values:
                /// 
                /// *   **0**: The task is stopped.
                /// *   **1**: The task is started.
                /// *   **9**: The task is ended.
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                /// <summary>
                /// The type of the task. Valid values:
                /// 
                /// 1.  3: web page performance - IE
                /// 2.  34: web page performance - Chrome
                /// 3.  0: network quality
                /// 4.  40: file download
                /// 5.  7: API performance
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public long? TaskType { get; set; }

                /// <summary>
                /// The name of the task type.
                /// </summary>
                [NameInMap("TaskTypeName")]
                [Validation(Required=false)]
                public string TaskTypeName { get; set; }

                /// <summary>
                /// The URL for synthetic monitoring.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// The availability. Only the data of the last day is counted. If no data is available for the last day, an empty value is returned.
                /// </summary>
                [NameInMap("Usable")]
                [Validation(Required=false)]
                public float? Usable { get; set; }

            }

            /// <summary>
            /// The first page on the navigation bar.
            /// </summary>
            [NameInMap("NavigateFirstPage")]
            [Validation(Required=false)]
            public string NavigateFirstPage { get; set; }

            /// <summary>
            /// The last page on the navigation bar.
            /// </summary>
            [NameInMap("NavigateLastPage")]
            [Validation(Required=false)]
            public string NavigateLastPage { get; set; }

            /// <summary>
            /// All navigation page numbers.
            /// </summary>
            [NameInMap("NavigatePageNums")]
            [Validation(Required=false)]
            public string NavigatePageNums { get; set; }

            /// <summary>
            /// The next page.
            /// </summary>
            [NameInMap("NextPage")]
            [Validation(Required=false)]
            public string NextPage { get; set; }

            /// <summary>
            /// The total number of pages returned.
            /// </summary>
            [NameInMap("Pages")]
            [Validation(Required=false)]
            public string Pages { get; set; }

            /// <summary>
            /// The previous page.
            /// </summary>
            [NameInMap("Prepage")]
            [Validation(Required=false)]
            public string Prepage { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
