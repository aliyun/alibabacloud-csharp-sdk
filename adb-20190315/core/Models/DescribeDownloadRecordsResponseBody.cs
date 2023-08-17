// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDownloadRecordsResponseBody : TeaModel {
        /// <summary>
        /// Details about the download tasks.
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeDownloadRecordsResponseBodyRecords> Records { get; set; }
        public class DescribeDownloadRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// The ID of the download task.
            /// </summary>
            [NameInMap("DownloadId")]
            [Validation(Required=false)]
            public long? DownloadId { get; set; }

            /// <summary>
            /// The error message returned when the download task has failed.
            /// </summary>
            [NameInMap("ExceptionMsg")]
            [Validation(Required=false)]
            public string ExceptionMsg { get; set; }

            /// <summary>
            /// The name of the downloaded file.
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// The status of the download task.
            /// 
            /// *   **running**: The download task is currently in progress.
            /// *   **finished**: The download task is complete.
            /// *   **failed**: The download task has failed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The download URL of the file.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
