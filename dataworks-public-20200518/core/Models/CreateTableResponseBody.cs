// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateTableResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the request task. After a request task is submitted, it is divided into multiple subtasks that are run in sequence. After the current subtask is complete, the next subtask starts to run. After all subtasks are complete, the request task is complete.
        /// 
        /// If a request task is aborted due to one of the following issues, address the issue based on the error code and initiate the request task again:
        /// 
        /// *   The request task fails to be submitted.
        /// *   After the request task is submitted, a subtask fails to run.
        /// </summary>
        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public CreateTableResponseBodyTaskInfo TaskInfo { get; set; }
        public class CreateTableResponseBodyTaskInfo : TeaModel {
            /// <summary>
            /// The details about the status of the current subtask.
            /// 
            /// *   If the current subtask is successful, success is returned.
            /// *   If the current subtask fails, the error details are displayed.
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// The ID of the subtask that you want to run. If this parameter is left empty, all subtasks are complete.
            /// </summary>
            [NameInMap("NextTaskId")]
            [Validation(Required=false)]
            public string NextTaskId { get; set; }

            /// <summary>
            /// The status of the current subtask. Valid values:
            /// 
            /// *   operating: The subtask is running.
            /// *   success: The subtask succeeds.
            /// *   failure: The subtask fails to run. For more information about the error details, see the Content parameter.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the current subtask.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
