// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DeleteNodesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the task.
        /// 
        /// *   If you set the Sync parameter to true, the DeleteNodes operation is synchronous. Valid value: Not Available.
        /// *   If you set the Sync parameter to false, the DeleteNodes operation is asynchronous. You can call the [ListTasks](~~268225~~) operation to query the result of the task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
