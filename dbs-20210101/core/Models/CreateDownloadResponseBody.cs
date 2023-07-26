// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class CreateDownloadResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDownloadResponseBodyData Data { get; set; }
        public class CreateDownloadResponseBodyData : TeaModel {
            /// <summary>
            /// The point in time of the backup set if the task is used to download a backup set at a specific point in time. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("BackupSetTime")]
            [Validation(Required=false)]
            public long? BackupSetTime { get; set; }

            /// <summary>
            /// The ID of the full backup set.
            /// </summary>
            [NameInMap("BakSetId")]
            [Validation(Required=false)]
            public string BakSetId { get; set; }

            /// <summary>
            /// The database and table information that is returned if databases and tables are filtered by the download task.
            /// </summary>
            [NameInMap("DbList")]
            [Validation(Required=false)]
            public string DbList { get; set; }

            /// <summary>
            /// The state of the download task. Valid values:
            /// 
            /// *   initializing: The download task was being initialized.
            /// *   queuing: The download task was queuing.
            /// *   running: The download task was running.
            /// *   failed: The download task failed.
            /// *   finished: The download task was complete.
            /// *   expired: The download task expired.
            /// 
            /// > If the TargetType parameter is set to URL, the download task expires in three days after the task is complete.
            /// </summary>
            [NameInMap("DownloadStatus")]
            [Validation(Required=false)]
            public string DownloadStatus { get; set; }

            /// <summary>
            /// The size of the downloaded data. Unit: bytes.
            /// </summary>
            [NameInMap("ExportDataSize")]
            [Validation(Required=false)]
            public long? ExportDataSize { get; set; }

            /// <summary>
            /// The format to which the downloaded data is converted.
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// The time when the download task was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The size of the processed data. Unit: bytes.
            /// </summary>
            [NameInMap("ImportDataSize")]
            [Validation(Required=false)]
            public long? ImportDataSize { get; set; }

            /// <summary>
            /// The number of tables that have been downloaded and the total number of tables to be downloaded.
            /// 
            /// > If the task is in the preparation stage, 0/0 is returned.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The ID of the region in which the instance resides.
            /// </summary>
            [NameInMap("RegionCode")]
            [Validation(Required=false)]
            public string RegionCode { get; set; }

            /// <summary>
            /// The destination path to which the backup set is downloaded.
            /// 
            /// > This parameter is returned if the TargetType parameter is set to OSS.
            /// </summary>
            [NameInMap("TargetPath")]
            [Validation(Required=false)]
            public string TargetPath { get; set; }

            /// <summary>
            /// The type of the destination to which the backup set is downloaded.
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// The ID of the download task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
