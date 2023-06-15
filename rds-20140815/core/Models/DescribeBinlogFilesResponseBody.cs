// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBinlogFilesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of information about the binary log file.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBinlogFilesResponseBodyItems Items { get; set; }
        public class DescribeBinlogFilesResponseBodyItems : TeaModel {
            [NameInMap("BinLogFile")]
            [Validation(Required=false)]
            public List<DescribeBinlogFilesResponseBodyItemsBinLogFile> BinLogFile { get; set; }
            public class DescribeBinlogFilesResponseBodyItemsBinLogFile : TeaModel {
                /// <summary>
                /// The checksum. The value of this parameter is calculated by using the CRC64 algorithm.
                /// </summary>
                [NameInMap("Checksum")]
                [Validation(Required=false)]
                public string Checksum { get; set; }

                /// <summary>
                /// The HTTP-based download URL of the binary log file. If the return value of this parameter is NULL, ApsaraDB RDS does not provide a download URL for the file.
                /// </summary>
                [NameInMap("DownloadLink")]
                [Validation(Required=false)]
                public string DownloadLink { get; set; }

                /// <summary>
                /// The size of the binary log file. Unit: bytes.
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// The ID of the instance to which the binary log file belongs. This parameter is used to distinguish between the binary log files that are generated on a primary instance and those that are generated on a secondary instance.
                /// </summary>
                [NameInMap("HostInstanceID")]
                [Validation(Required=false)]
                public string HostInstanceID { get; set; }

                /// <summary>
                /// The download URL that is used over an internal network.
                /// </summary>
                [NameInMap("IntranetDownloadLink")]
                [Validation(Required=false)]
                public string IntranetDownloadLink { get; set; }

                /// <summary>
                /// The expiration time of the URL. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("LinkExpiredTime")]
                [Validation(Required=false)]
                public string LinkExpiredTime { get; set; }

                /// <summary>
                /// The start time of the log data recorded in the binary log file. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("LogBeginTime")]
                [Validation(Required=false)]
                public string LogBeginTime { get; set; }

                /// <summary>
                /// The end time of the log data recorded in the binary log file. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("LogEndTime")]
                [Validation(Required=false)]
                public string LogEndTime { get; set; }

                /// <summary>
                /// The name of the binary log file.
                /// </summary>
                [NameInMap("LogFileName")]
                [Validation(Required=false)]
                public string LogFileName { get; set; }

                /// <summary>
                /// The status of the binary log file that is stored in the Object Storage Service (OSS) bucket. Valid values:
                /// 
                /// *   **Uploading**
                /// *   **Completed**
                /// </summary>
                [NameInMap("RemoteStatus")]
                [Validation(Required=false)]
                public string RemoteStatus { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of binary log files returned on the current page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total size of the binary log files.
        /// </summary>
        [NameInMap("TotalFileSize")]
        [Validation(Required=false)]
        public long? TotalFileSize { get; set; }

        /// <summary>
        /// The total number of binary log files returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
