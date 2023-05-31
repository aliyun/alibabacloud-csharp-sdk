// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOnceTaskResultInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the scan task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The name of the task. Valid values:
        /// 
        /// *   **CLIENT\_PROBLEM_CHECK**: a task of the Security Center agent
        /// *   **CLIENT\_DEV_OPS**: an O\&M task of Cloud Assistant
        /// *   **ASSET\_SECURITY_CHECK**: a task of asset information collection
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The type of the task. Valid values:
        /// 
        /// *   **CLIENT\_PROBLEM_CHECK**: a task of the Security Center agent
        /// *   **CLIENT\_DEV_OPS**: an O\&M task of Cloud Assistant
        /// *   **ASSET\_SECURITY_CHECK**: a task of asset information collection
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
