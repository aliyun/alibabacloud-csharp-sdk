// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryRobotTaskListRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The task state. Valid values:
        /// 
        /// *   **INIT**: The task is not started.
        /// *   **READY**: The task is ready to start.
        /// *   **DISPATCH**: The task is being parsed.
        /// *   **EXCUTING**: The task is being executed.
        /// *   **MANUAL_STOP**: The task is manually suspended.
        /// *   **SYSTEM_STOP**: The task is suspended by the system.
        /// *   **ARREARS_STOP**: The task is suspended due to overdue payments.
        /// *   **CANCEL**: The task is manually canceled.
        /// *   **SYSTEM_CANCEL**: The task is canceled by the system.
        /// *   **FINISH**: The task is complete.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The task name.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The date when the task is created, in the yyyy-MM-dd format.
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
