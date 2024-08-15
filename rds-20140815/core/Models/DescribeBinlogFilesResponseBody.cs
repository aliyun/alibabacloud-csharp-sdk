// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBinlogFilesResponseBody : TeaModel {
        /// <summary>
        /// The details of the log file.
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
                /// The HTTP-based download URL of the log file. If the return value of this parameter is NULL, ApsaraDB RDS does not provide a download URL for the log file.
                /// </summary>
                [NameInMap("DownloadLink")]
                [Validation(Required=false)]
                public string DownloadLink { get; set; }

                /// <summary>
                /// The size of the log file.
                /// 
                /// Unit: bytes.
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// The ID of the instance to which the log file belongs. This parameter helps determine whether the log file is generated on the primary instance or the secondary instance.
                /// 
                /// >  You can log on to the ApsaraDB RDS console and go to the instance details page. In the left-side navigation pane, click **Service Availability** to view the values of **Primary Instance No.** and **Secondary Instance No.**.
                /// </summary>
                [NameInMap("HostInstanceID")]
                [Validation(Required=false)]
                public string HostInstanceID { get; set; }

                /// <summary>
                /// The URL that is used to download files over an internal network.
                /// </summary>
                [NameInMap("IntranetDownloadLink")]
                [Validation(Required=false)]
                public string IntranetDownloadLink { get; set; }

                /// <summary>
                /// The expiration time of the URL.
                /// 
                /// The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("LinkExpiredTime")]
                [Validation(Required=false)]
                public string LinkExpiredTime { get; set; }

                /// <summary>
                /// The beginning of the time range to query.
                /// 
                /// The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("LogBeginTime")]
                [Validation(Required=false)]
                public string LogBeginTime { get; set; }

                /// <summary>
                /// The end of the time range to query.
                /// 
                /// The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("LogEndTime")]
                [Validation(Required=false)]
                public string LogEndTime { get; set; }

                /// <summary>
                /// The log file name.
                /// </summary>
                [NameInMap("LogFileName")]
                [Validation(Required=false)]
                public string LogFileName { get; set; }

                /// <summary>
                /// The status of the log file that is stored in the Object Storage Service (OSS) bucket.
                /// 
                /// Valid values:
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
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of log files on the current page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total size of the log file.
        /// </summary>
        [NameInMap("TotalFileSize")]
        [Validation(Required=false)]
        public long? TotalFileSize { get; set; }

        /// <summary>
        /// The total number of log files.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
