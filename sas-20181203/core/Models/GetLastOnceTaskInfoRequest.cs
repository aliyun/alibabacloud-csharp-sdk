// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetLastOnceTaskInfoRequest : TeaModel {
        /// <summary>
        /// The source of the task.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The name of the task. Valid values:
        /// 
        /// *   **CLIENT\_PROBLEM_CHECK**: client diagnosis task
        /// *   **CLIENT\_DEV_OPS**: O\&M task of Cloud Assistant
        /// *   **ASSETS_COLLECTION**: asset collection task
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The type of the task. Valid values:
        /// 
        /// *   **CLIENT\_PROBLEM_CHECK**: client diagnosis task
        /// *   **CLIENT\_DEV_OPS**: O\&M task of Cloud Assistant
        /// *   **ASSETS\_COLLECTION**: asset collection task
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
