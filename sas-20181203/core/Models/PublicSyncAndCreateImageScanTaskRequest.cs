// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PublicSyncAndCreateImageScanTaskRequest : TeaModel {
        /// <summary>
        /// The status of the image scan task. Valid values:
        /// 
        /// *   **INIT**: The task is being initialized.
        /// *   **PRE_ANALYZER**: The task is being pre-processed.
        /// *   **SUCCESS**: The task is successful.
        /// *   **FAIL**: The task failed.
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public string Images { get; set; }

        /// <summary>
        /// The ID of the image scan task.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
