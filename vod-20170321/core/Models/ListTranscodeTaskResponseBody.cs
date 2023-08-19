// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListTranscodeTaskResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details about transcoding tasks.
        /// </summary>
        [NameInMap("TranscodeTaskList")]
        [Validation(Required=false)]
        public List<ListTranscodeTaskResponseBodyTranscodeTaskList> TranscodeTaskList { get; set; }
        public class ListTranscodeTaskResponseBodyTranscodeTaskList : TeaModel {
            /// <summary>
            /// The time when the transcoding task was complete. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// The time when the transcoding task was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The status of the transcoding task. Valid values:
            /// *   **Processing**: In progress.
            /// *   **Partial**: Some transcoding jobs were complete.
            /// *   **CompleteAllSucc**: All transcoding jobs were successful.
            /// *   **CompleteAllFail**: All transcoding jobs failed. If an exception occurs in the source file, no transcoding job is initiated and the transcoding task fails.
            /// *   **CompletePartialSucc**: All transcoding jobs were complete but only some were successful.
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// The ID of the transcoding task.
            /// </summary>
            [NameInMap("TranscodeTaskId")]
            [Validation(Required=false)]
            public string TranscodeTaskId { get; set; }

            /// <summary>
            /// The ID of the transcoding template group.
            /// </summary>
            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

            /// <summary>
            /// The mode in which the transcoding task is triggered. Valid values:
            /// *   **Auto**: The transcoding task is automatically triggered when the video is uploaded.
            /// *   **Manual**: The transcoding task is triggered by calling the SubmitTranscodeJobs operation.
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

            /// <summary>
            /// The ID of the audio or video file.
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
