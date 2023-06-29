// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataMaskingRunHistoryResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The execution information about the de-identification task.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataMaskingRunHistoryResponseBodyItems> Items { get; set; }
        public class DescribeDataMaskingRunHistoryResponseBodyItems : TeaModel {
            /// <summary>
            /// The number of rows that are in conflict with the data to be de-identified in the destination table to which the data to be de-identified is moved.
            /// </summary>
            [NameInMap("ConflictCount")]
            [Validation(Required=false)]
            public long? ConflictCount { get; set; }

            /// <summary>
            /// The type of the service to which the de-identified data belongs. Valid values: **1**, **2**, **3**, **4**, and **5**. The value 1 indicates MaxCompute. The value 2 indicates OSS. The value indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.
            /// </summary>
            [NameInMap("DstType")]
            [Validation(Required=false)]
            public int? DstType { get; set; }

            /// <summary>
            /// The service that stores the de-identified data. Valid values include **MaxCompute, OSS, ADS, OTS, and RDS**.
            /// </summary>
            [NameInMap("DstTypeCode")]
            [Validation(Required=false)]
            public string DstTypeCode { get; set; }

            /// <summary>
            /// The end time of the de-identification task.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The error code that is returned when the de-identification task fails.
            /// </summary>
            [NameInMap("FailCode")]
            [Validation(Required=false)]
            public string FailCode { get; set; }

            /// <summary>
            /// The reason why the de-identification task fails.
            /// </summary>
            [NameInMap("FailMsg")]
            [Validation(Required=false)]
            public string FailMsg { get; set; }

            /// <summary>
            /// Indicates whether a file is available for download.
            /// 
            /// *   **1**: yes
            /// *   **0**: no
            /// </summary>
            [NameInMap("HasDownloadFile")]
            [Validation(Required=false)]
            public int? HasDownloadFile { get; set; }

            /// <summary>
            /// The number of created subtasks.
            /// </summary>
            [NameInMap("HasSubProcess")]
            [Validation(Required=false)]
            public int? HasSubProcess { get; set; }

            /// <summary>
            /// The ID of the task execution record.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The number of rows that are de-identified.
            /// </summary>
            [NameInMap("MaskingCount")]
            [Validation(Required=false)]
            public long? MaskingCount { get; set; }

            /// <summary>
            /// The progress of the de-identification task.
            /// </summary>
            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public int? Percentage { get; set; }

            /// <summary>
            /// The number of times that the de-identification task is executed.
            /// </summary>
            [NameInMap("RunIndex")]
            [Validation(Required=false)]
            public int? RunIndex { get; set; }

            /// <summary>
            /// The name of the source table.
            /// </summary>
            [NameInMap("SrcTableName")]
            [Validation(Required=false)]
            public string SrcTableName { get; set; }

            /// <summary>
            /// The type of the service to which the data to be de-identified belongs. Valid values: **1**, **2**, **3**, **4**, and **5**. The value 1 indicates MaxCompute. The value 2 indicates OSS. The value indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.
            /// </summary>
            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public int? SrcType { get; set; }

            /// <summary>
            /// The service to which the data to be de-identified belongs. Valid values include **MaxCompute, OSS, ADS, OTS, and RDS**.
            /// </summary>
            [NameInMap("SrcTypeCode")]
            [Validation(Required=false)]
            public string SrcTypeCode { get; set; }

            /// <summary>
            /// The time when the de-identification task was executed. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The status of the de-identification task. Valid values:
            /// 
            /// *   **-1**: waiting
            /// *   **0**: being executed
            /// *   **1**: executed
            /// *   **2**: failed to be executed
            /// *   **3**: terminated
            /// *   **4**: partially failed
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The ID of the identification task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The mode in which the de-identification task is executed. Valid values:
            /// 
            /// *   **1**: manual
            /// *   **2**: scheduled
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
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
