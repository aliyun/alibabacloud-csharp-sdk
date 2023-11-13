// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAsyncTasksResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details of the asynchronous export tasks.
        /// </summary>
        [NameInMap("AsyncTasks")]
        [Validation(Required=false)]
        public List<DescribeAsyncTasksResponseBodyAsyncTasks> AsyncTasks { get; set; }
        public class DescribeAsyncTasksResponseBodyAsyncTasks : TeaModel {
            /// <summary>
            /// The end time of the task. This value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The start time of the task. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The ID of the job.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// The task parameter. The value is a JSON string. The returned field in the value varies based on the value of **TaskType**.
            /// 
            /// If **TaskType** is set to **1**, **3**, **4**, **5**, or **6**, the following filed is returned:
            /// 
            /// *   **instanceId**: the ID of the instance. Data type: string.
            /// 
            /// If **TaskType** is set to **2**, the following field is returned:
            /// 
            /// *   **domain**: the domain name of the website. Data type: string.
            /// </summary>
            [NameInMap("TaskParams")]
            [Validation(Required=false)]
            public string TaskParams { get; set; }

            /// <summary>
            /// The execution result of the task. The value is a JSON string. The returned fields in the value vary based on the value of **TaskType**.
            /// 
            /// If **TaskType** is set to **1**, **3**, **4**, **5**, or **6**, the following fields are returned:
            /// 
            /// *   **instanceId**: the ID of the instance. Data type: string.
            /// *   **url**: the URL to download the exported file from Object Storage Service (OSS). Data type: string.
            /// 
            /// If **TaskType** is set to **2**, the following fields are returned:
            /// 
            /// *   **domain**: the domain name of the website. Data type: string.
            /// *   **url**: the URL to download the exported file from OSS. Data type: string.
            /// </summary>
            [NameInMap("TaskResult")]
            [Validation(Required=false)]
            public string TaskResult { get; set; }

            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   **0**: indicates that the task is being initialized.
            /// *   **1**: indicates that the task is in progress.
            /// *   **2**: indicates that the task is successful.
            /// *   **3**: indicates that the task failed.
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// The type of the task. Valid values:
            /// 
            /// *   **1**: the task to export the port forwarding rules of an instance
            /// *   **2**: the task to export the forwarding rules of a website protected by an instance
            /// *   **3**: the task to export the sessions and health check settings of an instance
            /// *   **4**: the task to export the mitigation policies of an instance
            /// *   **5**: the task to download the blacklist for destination IP addresses of an instance
            /// *   **6**: the task to download the whitelist for destination IP addresses of an instance
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public int? TaskType { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of asynchronous export tasks that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
