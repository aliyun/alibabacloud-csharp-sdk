// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ListUserBackupFilesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the information about the full backup files that are returned.
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<ListUserBackupFilesResponseBodyRecords> Records { get; set; }
        public class ListUserBackupFilesResponseBodyRecords : TeaModel {
            /// <summary>
            /// The ID of the full backup file.
            /// </summary>
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            /// <summary>
            /// The information about the binary log file that contains incremental data. If incremental data is generated during the full backup, this parameter is returned.
            /// </summary>
            [NameInMap("BinlogInfo")]
            [Validation(Required=false)]
            public string BinlogInfo { get; set; }

            /// <summary>
            /// The description of the full backup file.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The time when the system started to import the full backup file. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The database engine of the instance.
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// The database engine version of the instance.
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// The time when the full backup file is successfully imported. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// The time when the full backup file is successfully imported. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// The name of the OSS bucket in which the full backup file is stored as an object.
            /// </summary>
            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            /// <summary>
            /// The metadata of the full backup file. For more information, see [Manage object metadata](~~31859~~).
            /// </summary>
            [NameInMap("OssFileMetaData")]
            [Validation(Required=false)]
            public string OssFileMetaData { get; set; }

            /// <summary>
            /// The name of the full backup file that is stored as an object in an OSS bucket.
            /// </summary>
            [NameInMap("OssFileName")]
            [Validation(Required=false)]
            public string OssFileName { get; set; }

            /// <summary>
            /// The path of the full backup file that is stored as an object in an OSS bucket.
            /// </summary>
            [NameInMap("OssFilePath")]
            [Validation(Required=false)]
            public string OssFilePath { get; set; }

            /// <summary>
            /// The size of the full backup file that is stored as an object in an OSS bucket. Unit: KB.
            /// </summary>
            [NameInMap("OssFileSize")]
            [Validation(Required=false)]
            public long? OssFileSize { get; set; }

            /// <summary>
            /// The URL to download the full backup file from the OSS bucket.
            /// </summary>
            [NameInMap("OssUrl")]
            [Validation(Required=false)]
            public string OssUrl { get; set; }

            /// <summary>
            /// The reason why the full backup file failed to be imported.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The amount of storage that is required to restore the data of the full backup file. Unit: GB.
            /// </summary>
            [NameInMap("RestoreSize")]
            [Validation(Required=false)]
            public string RestoreSize { get; set; }

            /// <summary>
            /// The retention period of the full backup file. Unit: days.
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public int? Retention { get; set; }

            /// <summary>
            /// The status of the full backup file. Valid values:
            /// 
            /// *   **Importing**: The full backup file is being imported.
            /// *   **Failed**: The full backup file fails to be imported.
            /// *   **CheckSucccess**: The full backup file passes the check.
            /// *   **BackupSuccess**: The full backup file is imported.
            /// *   **Deleted**: The full backup file is deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The zone ID of the full backup file.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
