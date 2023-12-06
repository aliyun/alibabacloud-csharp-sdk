// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListVirusScanTaskRequest : TeaModel {
        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The timestamp when the virus scan task ended. Unit: milliseconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The public IP address of the server.
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// The private IP address of the server.
        /// </summary>
        [NameInMap("IntranetIp")]
        [Validation(Required=false)]
        public string IntranetIp { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The name of the server.
        /// </summary>
        [NameInMap("MachineName")]
        [Validation(Required=false)]
        public string MachineName { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Specifies whether the virus scan task is the root task.
        /// </summary>
        [NameInMap("RootTask")]
        [Validation(Required=false)]
        public bool? RootTask { get; set; }

        /// <summary>
        /// The ID of the root task.
        /// 
        /// >  You can call the [GetVirusScanLatestTaskStatistic](~~GetVirusScanLatestTaskStatistic~~) operation to query the ID.
        /// </summary>
        [NameInMap("RootTaskId")]
        [Validation(Required=false)]
        public string RootTaskId { get; set; }

        /// <summary>
        /// The type of the virus scan task. Valid values:
        /// 
        /// *   **system**: automatic scan task
        /// *   **user**: custom scan task
        /// </summary>
        [NameInMap("ScanType")]
        [Validation(Required=false)]
        public string ScanType { get; set; }

        /// <summary>
        /// The timestamp when the virus scan task started. Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The status of the virus scan task. Valid values:
        /// 
        /// *   **1**: running
        /// *   **2**: complete
        /// *   **3**: failed
        /// *   **4**: timed out
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The statuses of virus scan tasks.
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<int?> StatusList { get; set; }

        /// <summary>
        /// The ID of the virus scan task.
        /// 
        /// >  You can call the [ListVirusScanTask](~~ListVirusScanTask~~) operation to query the ID.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
