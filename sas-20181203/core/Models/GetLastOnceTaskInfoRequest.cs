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
        /// *   **CLIENT_PROBLEM_CHECK**: client diagnosis task
        /// *   **CLIENT_DEV_OPS**: O\\&M task of Cloud Assistant
        /// *   **ASSETS_COLLECTION**: asset collection task
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The type of the task. Valid values:
        /// 
        /// *   **CLIENT_PROBLEM_CHECK**: client diagnosis task
        /// *   **CLIENT_DEV_OPS**: O\\&M task of Cloud Assistant
        /// *   **ASSETS_COLLECTION**: asset collection task
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
