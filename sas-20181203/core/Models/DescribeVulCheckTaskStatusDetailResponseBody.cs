// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulCheckTaskStatusDetailResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the status information about the vulnerability scan tasks on the server.
        /// </summary>
        [NameInMap("TaskStatuses")]
        [Validation(Required=false)]
        public List<DescribeVulCheckTaskStatusDetailResponseBodyTaskStatuses> TaskStatuses { get; set; }
        public class DescribeVulCheckTaskStatusDetailResponseBodyTaskStatuses : TeaModel {
            /// <summary>
            /// The ID of the main task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// An array that consists of status information about the vulnerability scan subtask.
            /// </summary>
            [NameInMap("TaskStatusList")]
            [Validation(Required=false)]
            public List<DescribeVulCheckTaskStatusDetailResponseBodyTaskStatusesTaskStatusList> TaskStatusList { get; set; }
            public class DescribeVulCheckTaskStatusDetailResponseBodyTaskStatusesTaskStatusList : TeaModel {
                /// <summary>
                /// The error code returned.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The status of the subtask. Valid values:
                /// 
                /// *   **0**: unhandled
                /// *   **1**: collecting
                /// *   **2**: collected
                /// *   **3**: matching
                /// *   **4**: complete
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the vulnerability. Valid values:
                /// 
                /// *   **cve**: Linux software vulnerability
                /// *   **sys**: Windows system vulnerability
                /// *   **cms**: Web-CMS vulnerability
                /// *   **sca**: vulnerability that is detected based on software component analysis
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The total number of vulnerability scan tasks on the server.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
