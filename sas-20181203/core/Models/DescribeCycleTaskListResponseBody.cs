// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCycleTaskListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of periodic scan tasks.
        /// </summary>
        [NameInMap("CycleScheduleResponseList")]
        [Validation(Required=false)]
        public List<DescribeCycleTaskListResponseBodyCycleScheduleResponseList> CycleScheduleResponseList { get; set; }
        public class DescribeCycleTaskListResponseBodyCycleScheduleResponseList : TeaModel {
            /// <summary>
            /// The configuration ID.
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            /// <summary>
            /// Indicates whether the configuration for the task interval was enabled. Valid values:
            /// 
            /// *   **1**: enabled.
            /// *   **0**: disabled.
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            /// <summary>
            /// The time when the task first started.
            /// </summary>
            [NameInMap("FirstDateStr")]
            [Validation(Required=false)]
            public long? FirstDateStr { get; set; }

            /// <summary>
            /// The interval between which two consecutive tasks are run.
            /// </summary>
            [NameInMap("IntervalPeriod")]
            [Validation(Required=false)]
            public int? IntervalPeriod { get; set; }

            /// <summary>
            /// The ID of the last task.
            /// </summary>
            [NameInMap("LastTaskId")]
            [Validation(Required=false)]
            public string LastTaskId { get; set; }

            /// <summary>
            /// The time when the next task starts. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("NextStartTimeStr")]
            [Validation(Required=false)]
            public long? NextStartTimeStr { get; set; }

            /// <summary>
            /// The extended information.
            /// </summary>
            [NameInMap("Param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            /// <summary>
            /// The unit of the scan interval. Valid values:
            /// 
            /// *   **day**
            /// *   **hour**
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// The end time of the task. The time must be a time frame.
            /// </summary>
            [NameInMap("TargetEndTime")]
            [Validation(Required=false)]
            public int? TargetEndTime { get; set; }

            /// <summary>
            /// The start time of the task. The start time must be a time frame.
            /// </summary>
            [NameInMap("TargetStartTime")]
            [Validation(Required=false)]
            public int? TargetStartTime { get; set; }

            /// <summary>
            /// The name of the task.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The type of the task.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeCycleTaskListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeCycleTaskListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
