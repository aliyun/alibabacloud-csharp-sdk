// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeOnceTaskRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The timestamp when the root task ends. Unit: milliseconds.
        /// </summary>
        [NameInMap("EndTimeQuery")]
        [Validation(Required=false)]
        public long? EndTimeQuery { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the root task.
        /// 
        /// > You must specify at least one of the **TaskType** and **RootTaskId** parameters.
        /// </summary>
        [NameInMap("RootTaskId")]
        [Validation(Required=false)]
        public string RootTaskId { get; set; }

        /// <summary>
        /// The timestamp when the root task starts. Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTimeQuery")]
        [Validation(Required=false)]
        public long? StartTimeQuery { get; set; }

        /// <summary>
        /// The ID of the task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The type of the task. Valid values:
        /// 
        /// *   **CLIENT\_PROBLEM_CHECK**: a task of the Security Center agent
        /// *   **CLIENT\_DEV_OPS**: an O\&M task of Cloud Assistant
        /// *   **ASSET\_SECURITY_CHECK**: a task of asset information collection
        /// 
        /// > You must specify at least one of the **TaskType** and **RootTaskId** parameters.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
