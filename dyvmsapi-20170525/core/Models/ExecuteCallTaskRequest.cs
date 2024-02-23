// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ExecuteCallTaskRequest : TeaModel {
        /// <summary>
        /// The time when the call task is executed, in the yyyy-MM-dd HH:mm:ss format.
        /// 
        /// > You can leave this parameter empty.
        /// </summary>
        [NameInMap("FireTime")]
        [Validation(Required=false)]
        public string FireTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The task state. Valid values:
        /// 
        /// *   **RUNNING**
        /// *   **STOP**
        /// *   **CANCEL**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The task ID. You can call the [CreateCallTask](~~CreateCallTask~~) operation to obtain the task ID.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
