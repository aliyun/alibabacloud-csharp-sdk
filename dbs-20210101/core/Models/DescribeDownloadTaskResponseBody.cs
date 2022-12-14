// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeDownloadTaskResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the download tasks.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDownloadTaskResponseBodyData Data { get; set; }
        public class DescribeDownloadTaskResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the download tasks.
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public DescribeDownloadTaskResponseBodyDataContent Content { get; set; }
            public class DescribeDownloadTaskResponseBodyDataContent : TeaModel {
                [NameInMap("List")]
                [Validation(Required=false)]
                public List<DescribeDownloadTaskResponseBodyDataContentList> List { get; set; }
                public class DescribeDownloadTaskResponseBodyDataContentList : TeaModel {
                    /// <summary>
                    /// The point in time of the backup set if the task is used to download a backup set at a specific point in time. The value is a timestamp of the LONG type. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("BackupSetTime")]
                    [Validation(Required=false)]
                    public string BackupSetTime { get; set; }

                    /// <summary>
                    /// The ID of the full backup set.
                    /// </summary>
                    [NameInMap("BakSetId")]
                    [Validation(Required=false)]
                    public string BakSetId { get; set; }

                    /// <summary>
                    /// The details of the databases.
                    /// </summary>
                    [NameInMap("DbList")]
                    [Validation(Required=false)]
                    public string DbList { get; set; }

                    /// <summary>
                    /// The status of the download task. Valid values:
                    /// 
                    /// *   **Initializing**: The download task is being initialized.
                    /// *   **queuing**: The download task is queuing.
                    /// *   **running**: The download task is running.
                    /// *   **failed**: The download task fails.
                    /// *   **finished**: The download task is complete.
                    /// *   **expired**: The download task expires.
                    /// </summary>
                    [NameInMap("DownloadStatus")]
                    [Validation(Required=false)]
                    public string DownloadStatus { get; set; }

                    /// <summary>
                    /// The amount of output data. Unit: bytes.
                    /// </summary>
                    [NameInMap("ExportDataSize")]
                    [Validation(Required=false)]
                    public string ExportDataSize { get; set; }

                    /// <summary>
                    /// The format to which the downloaded backup set is converted. Valid values:
                    /// 
                    /// *   **csv**
                    /// *   **SQL**
                    /// *   **Parquet**
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// The time when the download task was created. The value is a timestamp.
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// The amount of data that is processed. Unit: bytes.
                    /// </summary>
                    [NameInMap("ImportDataSize")]
                    [Validation(Required=false)]
                    public string ImportDataSize { get; set; }

                    /// <summary>
                    /// The number of tables that have been downloaded and the total number of tables to be downloaded.
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
                    /// The destination path to which the data is downloaded if the TargeType parameter is set to OSS.
                    /// </summary>
                    [NameInMap("TargetPath")]
                    [Validation(Required=false)]
                    public string TargetPath { get; set; }

                    /// <summary>
                    /// The type of the method in which the backup set is downloaded. Valid values:
                    /// 
                    /// *   **OSS**
                    /// *   **URL**
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

            }

            /// <summary>
            /// The extra description of the download task.
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }

            /// <summary>
            /// The total number of returned pages.
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The error message.
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
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**: The request is successful.
        /// *   **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
