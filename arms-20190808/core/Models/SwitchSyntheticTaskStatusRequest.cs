// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SwitchSyntheticTaskStatusRequest : TeaModel {
        /// <summary>
        /// Specifies whether to start or stop the task. Valid values:
        /// 
        /// *   **0**: stops the task
        /// *   **1**: starts the task
        /// </summary>
        [NameInMap("SwitchStatus")]
        [Validation(Required=false)]
        public long? SwitchStatus { get; set; }

        /// <summary>
        /// The task IDs. You can specify up to 30 task IDs at a time.
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<long?> TaskIds { get; set; }

    }

}
