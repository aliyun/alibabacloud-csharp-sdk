// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDetachedBackupsResponseBody : TeaModel {
        /// <summary>
        /// The details of the returned data backup files.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDetachedBackupsResponseBodyItems Items { get; set; }
        public class DescribeDetachedBackupsResponseBodyItems : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeDetachedBackupsResponseBodyItemsBackup> Backup { get; set; }
            public class DescribeDetachedBackupsResponseBodyItemsBackup : TeaModel {
                /// <summary>
                /// The URL that is used to download the data backup file over the Internet. If the data backup file cannot be downloaded, an empty string is returned.
                /// </summary>
                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                /// <summary>
                /// The end time of the backup.
                /// 
                /// The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// The ID of the data backup file.
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                /// <summary>
                /// The URL that is used to download the data backup file over an internal network. If the data backup file cannot be downloaded, an empty string is returned.
                /// </summary>
                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                /// <summary>
                /// The method that is used to generate the data backup file. Valid values:
                /// 
                /// *   **Logical**: logical backup
                /// *   **Physical**: physical backup
                /// </summary>
                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                /// <summary>
                /// The backup mode of the data backup file. Valid values:
                /// 
                /// *   **Automated**
                /// *   **Manual**
                /// </summary>
                [NameInMap("BackupMode")]
                [Validation(Required=false)]
                public string BackupMode { get; set; }

                /// <summary>
                /// The size of the data backup file. Unit: bytes.
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public long? BackupSize { get; set; }

                /// <summary>
                /// The start time of the backup.
                /// 
                /// The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// The status of the data backup file. Valid values:
                /// 
                /// *   **Success**
                /// *   **Failed**
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// The backup type. Valid values:
                /// 
                /// *   **FullBackup**
                /// *   **IncrementalBackup**
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// The point in time at which the data in the data backup file is consistent. The return value of this parameter is a timestamp.
                /// 
                /// >  If the instance runs MySQL 5.6, a timestamp is returned. Otherwise, the value 0 is returned.
                /// </summary>
                [NameInMap("ConsistentTime")]
                [Validation(Required=false)]
                public long? ConsistentTime { get; set; }

                /// <summary>
                /// The description of the instance.
                /// </summary>
                [NameInMap("DBInstanceComment")]
                [Validation(Required=false)]
                public string DBInstanceComment { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The No. of the instance that generates the data backup file. This parameter is used to indicate whether the instance that generates the data backup file is a primary instance or a secondary instance.
                /// </summary>
                [NameInMap("HostInstanceID")]
                [Validation(Required=false)]
                public string HostInstanceID { get; set; }

                /// <summary>
                /// Indicates whether the data backup file is available. Valid values:
                /// 
                /// *   **0**: The data backup file is unavailable.
                /// *   **1**: The data backup file is available.
                /// </summary>
                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public int? IsAvail { get; set; }

                /// <summary>
                /// The status of the data backup file that is used to restore individual databases or tables. Valid values:
                /// 
                /// *   **OK**: The data backup file is normal.
                /// *   **LARGE**: The data backup file contains an abnormally large number of tables. It cannot be used to restore individual databases or tables.
                /// *   **EMPTY**: The data backup file is generated from a failed backup task.
                /// </summary>
                [NameInMap("MetaStatus")]
                [Validation(Required=false)]
                public string MetaStatus { get; set; }

                /// <summary>
                /// Indicates whether the data backup file can be deleted. Valid values:
                /// 
                /// *   **Enabled**: The data backup file can be deleted.
                /// *   **Disabled**: The data backup file cannot be deleted.
                /// </summary>
                [NameInMap("StoreStatus")]
                [Validation(Required=false)]
                public string StoreStatus { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of data backup files on the page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
