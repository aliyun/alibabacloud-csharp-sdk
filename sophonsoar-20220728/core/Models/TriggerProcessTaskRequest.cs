// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class TriggerProcessTaskRequest : TeaModel {
        /// <summary>
        /// The type of the action. Valid values:
        /// 
        /// *   **remove**: cancels blocking or isolation.
        /// *   **retry**: submits the task again.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// The ID of the handling task.
        /// 
        /// >  You can call the [DescribeProcessTasks](~~DescribeProcessTasks~~) operation to query the IDs of handling tasks.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
