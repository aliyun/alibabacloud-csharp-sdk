// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaRefreshJobsResponseBody : TeaModel {
        /// <summary>
        /// The media refresh or prefetch jobs.
        /// </summary>
        [NameInMap("MediaRefreshJobs")]
        [Validation(Required=false)]
        public List<GetMediaRefreshJobsResponseBodyMediaRefreshJobs> MediaRefreshJobs { get; set; }
        public class GetMediaRefreshJobsResponseBodyMediaRefreshJobs : TeaModel {
            /// <summary>
            /// The error code. This parameter is returned if the refresh or prefetch task fails.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The error message. This parameter is returned if the refresh or prefetch task fails.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The filtering conditions for stream playback. The value is a JSON string. This parameter is used as a request parameter of the [RefreshMediaPlayUrls](~~RefreshMediaPlayUrls~~) operation.
            /// </summary>
            [NameInMap("FilterPolicy")]
            [Validation(Required=false)]
            public string FilterPolicy { get; set; }

            /// <summary>
            /// The time when the task was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the task was modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The ID of the media file.
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// The ID of the job.
            /// </summary>
            [NameInMap("MediaRefreshJobId")]
            [Validation(Required=false)]
            public string MediaRefreshJobId { get; set; }

            /// <summary>
            /// The status of the job. Valid values:
            /// 
            /// *   **success**
            /// *   **fail**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The playback URLs that were refreshed or prefetched.
            /// </summary>
            [NameInMap("SuccessPlayUrls")]
            [Validation(Required=false)]
            public string SuccessPlayUrls { get; set; }

            /// <summary>
            /// The IDs of the refresh or prefetch tasks for the playback URLs of media files. Only one URL can be refreshed or prefetched in a task. This value is used in the [DescribeVodRefreshTasks](~~DescribeVodRefreshTasks~~) operation, which queries the status of refresh or prefetch tasks for playback URLs of media files.
            /// </summary>
            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public string TaskIds { get; set; }

            /// <summary>
            /// The type of the job. Valid values:
            /// 
            /// *   **Refresh**
            /// *   **Preload**
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// The user data that you passed when you submit a refresh or prefetch task.
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
