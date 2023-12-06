// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListBackupRecordRequest : TeaModel {
        /// <summary>
        /// The timestamp when the backup task ended. Unit: milliseconds.
        /// </summary>
        [NameInMap("BackupEndTime")]
        [Validation(Required=false)]
        public long? BackupEndTime { get; set; }

        /// <summary>
        /// The timestamp when the backup task started. Unit: milliseconds.
        /// </summary>
        [NameInMap("BackupStartTime")]
        [Validation(Required=false)]
        public long? BackupStartTime { get; set; }

        /// <summary>
        /// The page number. Default value: **1**. Pages start from page 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The information that you want to use to identify the servers protected by the anti-ransomware policy. You can enter the IP address or ID of a server.
        /// </summary>
        [NameInMap("MachineRemark")]
        [Validation(Required=false)]
        public string MachineRemark { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// >  We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The backup task status. Valid values:
        /// 
        /// *   **BACKUP_COMPLETE**: The backup task is successful.
        /// *   **BACKUP_FAILED**: The backup task failed.
        /// *   **PARTIAL_COMPLETE**: The backup task is partially successful.
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

    }

}
