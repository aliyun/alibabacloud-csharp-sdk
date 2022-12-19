// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeScanTaskProgressResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The progress of the virus scan task. Valid values:
        /// 
        /// *   **init**: The task is being initialized.
        /// *   **Processing**: The task is running.
        /// *   **Success**: The task is complete.
        /// *   **Failed**: The task fails.
        /// </summary>
        [NameInMap("ScanTaskProgress")]
        [Validation(Required=false)]
        public string ScanTaskProgress { get; set; }

        /// <summary>
        /// The information about the asset on which the virus scan task runs. The value is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that contains the following fields:
        /// 
        /// *   **type**: the type of the asset on which the virus scan task runs. Valid values:
        /// 
        ///     *   **groupId**: server group.
        ///     *   **uuid**: server.
        /// 
        /// *   **name**: the name of the server group or server.
        /// 
        /// *   **target**: the asset on which the virus scan task runs. The value of this field varies based on the value of the type field.
        /// 
        ///     *   If the value of **type** is **groupId**, the value of this field is the ID of the server group.
        ///     *   If the value of **type** is **uuid**, the value of this field is the UUID of the server.
        /// </summary>
        [NameInMap("TargetInfo")]
        [Validation(Required=false)]
        public string TargetInfo { get; set; }

    }

}
