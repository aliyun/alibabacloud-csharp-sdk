// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUnfinishedOnceTaskRequest : TeaModel {
        /// <summary>
        /// The value of the object on which the task runs. If you set TaskType to IMAGE_SCAN, set this parameter to the UUID of the image that you want to scan. If you set TaskType to ASSETS_COLLECTION, set this parameter to the UUID of the server whose information you want to collect.
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// The type of the task. Valid values:
        /// 
        /// *   **ASSETS_COLLECTION**: asset information collection task
        /// *   **IMAGE_SCAN**: image scan task
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
