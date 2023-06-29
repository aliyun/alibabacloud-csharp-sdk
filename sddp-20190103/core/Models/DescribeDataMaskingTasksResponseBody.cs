// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataMaskingTasksResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// An array that consists of de-identification tasks.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataMaskingTasksResponseBodyItems> Items { get; set; }
        public class DescribeDataMaskingTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// The destination directory.
            /// </summary>
            [NameInMap("DstPath")]
            [Validation(Required=false)]
            public string DstPath { get; set; }

            /// <summary>
            /// The service to which the data to be de-identified belongs. Valid values: **1**, **2**, **3**, **4**, and **5**. The value 1 indicates MaxCompute. The value 2 indicates OSS. The value 3 indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.
            /// </summary>
            [NameInMap("DstType")]
            [Validation(Required=false)]
            public int? DstType { get; set; }

            /// <summary>
            /// The service to which the de-identified data belongs. Valid values include **MaxCompute, OSS, ADS, OTS, and RDS**.
            /// </summary>
            [NameInMap("DstTypeCode")]
            [Validation(Required=false)]
            public string DstTypeCode { get; set; }

            /// <summary>
            /// The time when the task was created. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// Indicates whether the de-identification task is running.
            /// </summary>
            [NameInMap("HasUnfinishProcess")]
            [Validation(Required=false)]
            public bool? HasUnfinishProcess { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// Indicates whether the source table is de-identified.
            /// </summary>
            [NameInMap("OriginalTable")]
            [Validation(Required=false)]
            public bool? OriginalTable { get; set; }

            /// <summary>
            /// The user who created the de-identification task.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The number of times that the de-identification task is run.
            /// </summary>
            [NameInMap("RunCount")]
            [Validation(Required=false)]
            public int? RunCount { get; set; }

            /// <summary>
            /// The source path.
            /// </summary>
            [NameInMap("SrcPath")]
            [Validation(Required=false)]
            public string SrcPath { get; set; }

            /// <summary>
            /// The code of the service to which the data to be de-identified belongs. Valid values: **1**, **2**, **3**, **4**, and **5**. The value 1 indicates MaxCompute. The value 2 indicates OSS. The value indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.
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
            /// The status of the task. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: enabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The name of the task.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The mode in which the de-identification task is run. Valid values:
            /// 
            /// *   **1**: manual
            /// *   **2**: scheduled
            /// *   **3**: manual and scheduled
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public int? TriggerType { get; set; }

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
