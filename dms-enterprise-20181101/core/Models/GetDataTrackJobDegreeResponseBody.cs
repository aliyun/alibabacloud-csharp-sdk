// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataTrackJobDegreeResponseBody : TeaModel {
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
        /// The progress details of the data tracking task.
        /// </summary>
        [NameInMap("JobDegree")]
        [Validation(Required=false)]
        public GetDataTrackJobDegreeResponseBodyJobDegree JobDegree { get; set; }
        public class GetDataTrackJobDegreeResponseBodyJobDegree : TeaModel {
            /// <summary>
            /// The progress of binary log download. Valid values: 0 to 1. A value of 1 indicates that binary log download is complete.
            /// </summary>
            [NameInMap("DownloadCompletionDegree")]
            [Validation(Required=false)]
            public double? DownloadCompletionDegree { get; set; }

            /// <summary>
            /// The progress of binary log parsing. Valid values: 0 to 1. A value of 1 indicates that binary log parsing is complete.
            /// </summary>
            [NameInMap("FilterCompletionDegree")]
            [Validation(Required=false)]
            public double? FilterCompletionDegree { get; set; }

            /// <summary>
            /// The status of the data tracking task. Valid values:
            /// 
            /// *   **INIT**: The task is being initialized.
            /// *   **LISTING**: The binary logs are being obtained.
            /// *   **LIST_SUCCESS**: The binary logs are successfully obtained.
            /// *   **DOWNLOADING**: The binary logs are being downloaded.
            /// *   **DOWNLOAD_FAIL**: The binary logs failed to be downloaded.
            /// *   **DOWNLOAD_SUCCESS**: The binary logs are successfully downloaded.
            /// *   **FILTERING**: The binary logs are being parsed.
            /// *   **FILTER_FAIL**: The binary logs failed to be parsed.
            /// *   **FILTER_SUCCESS**: The binary logs are successfully parsed.
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// The progress of binary log obtaining. Valid values: 0 to 1. A value of 1 indicates that binary log obtaining is complete.
            /// </summary>
            [NameInMap("ListCompletionDegree")]
            [Validation(Required=false)]
            public double? ListCompletionDegree { get; set; }

            /// <summary>
            /// The description of the task status.
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
