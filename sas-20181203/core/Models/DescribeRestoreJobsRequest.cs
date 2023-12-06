// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRestoreJobsRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The unique identifier of the server on which the restoration task is run. For example, you can use the IP address or the name of the server.
        /// </summary>
        [NameInMap("MachineRemark")]
        [Validation(Required=false)]
        public string MachineRemark { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The status of the restoration task. Valid values:
        /// 
        /// *   **RUNNING**: The task is running.
        /// *   **COMPLETE**: The task is complete.
        /// *   **FAILED**: The task fails.
        /// *   **CANCELING**: The task is being canceled.
        /// *   **CANCELED**: The task is canceled.
        /// *   **PARTIAL_COMPLETE**: The task is partially successful.
        /// *   **CREATED**: The task is created but is not run.
        /// *   **EXPIRED**: The task is not updated.
        /// *   **QUEUED**: The task is waiting to be run.
        /// *   **CLIENT_DELETED**: The task fails because the anti-ransomware agent is uninstalled.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
