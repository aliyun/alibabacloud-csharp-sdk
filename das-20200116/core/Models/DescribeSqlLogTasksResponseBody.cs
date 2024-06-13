// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogTasksResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlLogTasksResponseBodyData Data { get; set; }
        public class DescribeSqlLogTasksResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the data returned.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeSqlLogTasksResponseBodyDataList> List { get; set; }
            public class DescribeSqlLogTasksResponseBodyDataList : TeaModel {
                /// <summary>
                /// The time when the analysis task was complete. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("AnalysisTaskFinishTime")]
                [Validation(Required=false)]
                public long? AnalysisTaskFinishTime { get; set; }

                /// <summary>
                /// The state of the analysis task.
                /// 
                /// >  This parameter is a system parameter. You do not need to pay attention to the parameter.
                /// </summary>
                [NameInMap("AnalysisTaskStatus")]
                [Validation(Required=false)]
                public string AnalysisTaskStatus { get; set; }

                /// <summary>
                /// The time when the task was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The time when the task ended. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                /// <summary>
                /// Indicates whether the task expired. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Expire")]
                [Validation(Required=false)]
                public bool? Expire { get; set; }

                /// <summary>
                /// The filter parameters.
                /// </summary>
                [NameInMap("Filters")]
                [Validation(Required=false)]
                public List<DescribeSqlLogTasksResponseBodyDataListFilters> Filters { get; set; }
                public class DescribeSqlLogTasksResponseBodyDataListFilters : TeaModel {
                    /// <summary>
                    /// The name of the filter parameter.
                    /// 
                    /// >  For more information about the filter parameters, see the **Valid values of Key** section of this topic.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the filter parameter.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The ID of the database instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The number of log records.
                /// </summary>
                [NameInMap("LogCount")]
                [Validation(Required=false)]
                public long? LogCount { get; set; }

                /// <summary>
                /// The task name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The task progress.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// The URL that is returned if the value of TaskType is **Export**.
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// The number of files that are scanned.
                /// </summary>
                [NameInMap("ScanFileSize")]
                [Validation(Required=false)]
                public long? ScanFileSize { get; set; }

                /// <summary>
                /// The time when the task started. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

                /// <summary>
                /// The task state. Valid values:
                /// 
                /// *   **INIT**: The task is to be scheduled.
                /// *   **RUNNING**: The task is running.
                /// *   **FAILED**: The task failed.
                /// *   **CANCELED**: The task is canceled.
                /// *   **COMPLETED**: The task is complete.
                /// 
                /// >  If a task is in the **COMPLETED** state, you can view the results of the task.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The task ID.
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// The task type. Valid values:
                /// 
                /// *   **Export**
                /// *   **Query**
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The number of tasks.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
