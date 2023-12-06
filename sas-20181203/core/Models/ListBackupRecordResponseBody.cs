// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListBackupRecordResponseBody : TeaModel {
        /// <summary>
        /// The details of the backup record.
        /// </summary>
        [NameInMap("BackupRecordList")]
        [Validation(Required=false)]
        public List<ListBackupRecordResponseBodyBackupRecordList> BackupRecordList { get; set; }
        public class ListBackupRecordResponseBodyBackupRecordList : TeaModel {
            /// <summary>
            /// The timestamp when the backup task ended. Unit: milliseconds.
            /// </summary>
            [NameInMap("BackupEndTime")]
            [Validation(Required=false)]
            public long? BackupEndTime { get; set; }

            /// <summary>
            /// The backup task ID.
            /// </summary>
            [NameInMap("BackupJobId")]
            [Validation(Required=false)]
            public string BackupJobId { get; set; }

            /// <summary>
            /// The backup plan ID.
            /// </summary>
            [NameInMap("BackupPlanId")]
            [Validation(Required=false)]
            public string BackupPlanId { get; set; }

            /// <summary>
            /// The timestamp when the backup task started. Unit: milliseconds.
            /// </summary>
            [NameInMap("BackupStartTime")]
            [Validation(Required=false)]
            public long? BackupStartTime { get; set; }

            /// <summary>
            /// The backup task status. Valid value:
            /// 
            /// *   **BACKUP_COMPLETE**: The backup task is successful.
            /// *   **BACKUP_FAILED**: The backup task failed.
            /// *   **PARTIAL_COMPLETE**: The backup task is partially successful.
            /// </summary>
            [NameInMap("BackupStatus")]
            [Validation(Required=false)]
            public string BackupStatus { get; set; }

            /// <summary>
            /// The ID of the anti-ransomware agent.
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// The error code of the backup task.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The error message of the backup task.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The instance ID of the server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The instance name of the asset.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

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
            /// The IP address of the server.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The ID of the region in which the backup is stored.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The UUID of the server whose data is backed up based on the anti-ransomware policy.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListBackupRecordResponseBodyPageInfo PageInfo { get; set; }
        public class ListBackupRecordResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
