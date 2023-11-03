// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetVirusScanConfigRequest : TeaModel {
        /// <summary>
        /// The type of the task. Valid values:
        /// 
        /// *   **VIRUS_VUL_SCHEDULE_SCAN**: a virus scan task.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
