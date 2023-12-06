// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHistoryTasksStatResponseBody : TeaModel {
        /// <summary>
        /// The details of the instance.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryTasksStatResponseBodyItems> Items { get; set; }
        public class DescribeHistoryTasksStatResponseBodyItems : TeaModel {
            /// <summary>
            /// The status of the migration task. Valid values:
            /// 
            /// *   **NoStart**: The task is not started.
            /// *   **Running**:The task is in progress.
            /// *   **Success**: The task is successful.
            /// *   **Failed**: The task failed.
            /// *   **Waiting**: The task is waiting for an incremental backup file to be imported.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The total number of tasks that meet these constraints without taking pagination into account.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
