// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class QueryDataTrackResultDownloadStatusResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the download progress.
        /// </summary>
        [NameInMap("StatusResult")]
        [Validation(Required=false)]
        public QueryDataTrackResultDownloadStatusResponseBodyStatusResult StatusResult { get; set; }
        public class QueryDataTrackResultDownloadStatusResponseBodyStatusResult : TeaModel {
            /// <summary>
            /// The status of the download task. Valid values:
            /// 
            /// *   **INIT**: The download task is being initialized.
            /// *   **LISTING**: The download task is in a transient intermediate state during the initialization.
            /// *   **DOWNLOADING**: The download task is being processed.
            /// *   **DOWNLOAD_SUCCESS**: The download task was successfully processed.
            /// *   **DOWNLOAD_FAIL**: The download task failed.
            /// </summary>
            [NameInMap("DownloadStatus")]
            [Validation(Required=false)]
            public string DownloadStatus { get; set; }

            /// <summary>
            /// The URL that is used to download data tracking logs. This parameter is returned only when the value of DownloadStatus is DOWNLOAD_SUCCESS.
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// The description of the state.
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
