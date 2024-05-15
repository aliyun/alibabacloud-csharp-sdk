// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogTasksResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// ListResult
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
                /// The time when the analysis task was complete.
                /// </summary>
                [NameInMap("AnalysisTaskFinishTime")]
                [Validation(Required=false)]
                public long? AnalysisTaskFinishTime { get; set; }

                /// <summary>
                /// The status of the analysis task.
                /// </summary>
                [NameInMap("AnalysisTaskStatus")]
                [Validation(Required=false)]
                public string AnalysisTaskStatus { get; set; }

                /// <summary>
                /// The time when the task was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The end of the time range to query.
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                /// <summary>
                /// Indicates whether the task expires.
                /// </summary>
                [NameInMap("Expire")]
                [Validation(Required=false)]
                public bool? Expire { get; set; }

                /// <summary>
                /// The filter conditions.
                /// </summary>
                [NameInMap("Filters")]
                [Validation(Required=false)]
                public List<DescribeSqlLogTasksResponseBodyDataListFilters> Filters { get; set; }
                public class DescribeSqlLogTasksResponseBodyDataListFilters : TeaModel {
                    /// <summary>
                    /// The name of the filter parameter.
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
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The number of log records
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
                /// The Object Storage Service (OSS) URL or other information.
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// The number of files scanned
                /// </summary>
                [NameInMap("ScanFileSize")]
                [Validation(Required=false)]
                public long? ScanFileSize { get; set; }

                /// <summary>
                /// The beginning of the time range to query.
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

                /// <summary>
                /// The status of the task.
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
                /// The type of the task. Valid values:
                /// 
                /// *   Export
                /// *   Query
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
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request is successful, **Successful** is returned. If the request fails, an error message that contains information such as an error code is returned.
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
