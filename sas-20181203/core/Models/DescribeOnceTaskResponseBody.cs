// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeOnceTaskResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeOnceTaskResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeOnceTaskResponseBodyPageInfo : TeaModel {
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
            /// The number of entries returned per page. Default value: **20**.
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

        /// <summary>
        /// An array that consists of the tasks.
        /// </summary>
        [NameInMap("TaskManageResponseList")]
        [Validation(Required=false)]
        public List<DescribeOnceTaskResponseBodyTaskManageResponseList> TaskManageResponseList { get; set; }
        public class DescribeOnceTaskResponseBodyTaskManageResponseList : TeaModel {
            /// <summary>
            /// The execution details of the task. The value of this parameter is in the JSON format.
            /// 
            /// *   **causeCode**: the returned code for the cause
            /// *   **causeMsg**: the returned information for the cause
            /// *   **resCode**: the returned code of troubleshooting
            /// *   **resMsg**: the returned information about troubleshooting
            /// *   **problemType**: the type of the issue
            /// *   **dispatchType**: the task delivery method
            /// *   **uuid**: the UUID of the server
            /// *   **instanceId**: the instance ID of the server
            /// *   **internetIp**: the public IP address of the server
            /// *   **intranetIp**: the private IP address of the server
            /// *   **instanceName**: the instance name of the server
            /// *   **url**: the download link of the troubleshooting log
            /// </summary>
            [NameInMap("DetailData")]
            [Validation(Required=false)]
            public string DetailData { get; set; }

            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            /// <summary>
            /// The progress of the task. Unit: %.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public string ResultInfo { get; set; }

            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            /// <summary>
            /// The timestamp when the task ends. Unit: milliseconds.
            /// </summary>
            [NameInMap("TaskEndTime")]
            [Validation(Required=false)]
            public long? TaskEndTime { get; set; }

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
            /// The timestamp when the task starts. Unit: milliseconds.
            /// </summary>
            [NameInMap("TaskStartTime")]
            [Validation(Required=false)]
            public long? TaskStartTime { get; set; }

            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   **1**: started
            /// *   **2**: complete
            /// *   **3**: failed
            /// *   **4**: timed out
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// The text description of the status for the task. Valid values:
            /// 
            /// *   **INIT**: The task is to be started.
            /// *   **START**: The task is started.
            /// *   **DISPATCH**: The self-check command is issued.
            /// *   **SUCCESS**: The self-check is complete.
            /// *   **FAIL**: The task fails.
            /// *   **TIMEOUT**: The task times out.
            /// </summary>
            [NameInMap("TaskStatusText")]
            [Validation(Required=false)]
            public string TaskStatusText { get; set; }

            /// <summary>
            /// The type of the task. Valid values:
            /// 
            /// *   **CLIENT\_PROBLEM_CHECK**: a task of the Security Center agent
            /// *   **CLIENT\_DEV_OPS**: an O&M task of Cloud Assistant
            /// *   **ASSET\_SECURITY_CHECK**: a task of asset information collection
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
