// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListTranscodeTaskResponseBody : TeaModel {
        /// <summary>
        /// The ID of the transcoding template group.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the transcoding task.
        /// </summary>
        [NameInMap("TranscodeTaskList")]
        [Validation(Required=false)]
        public List<ListTranscodeTaskResponseBodyTranscodeTaskList> TranscodeTaskList { get; set; }
        public class ListTranscodeTaskResponseBodyTranscodeTaskList : TeaModel {
            /// <summary>
            /// Queries transcoding tasks based on the media ID. This operation does not return specific job information.
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// The ID of the audio or video file. You can use one of the following methods to obtain the ID of the file:
            /// 
            /// *   Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, view the ID of the audio or video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
            /// *   Obtain the value of VideoId from the response to the [CreateUploadVideo](~~55407~~) operation that you call to obtain the upload URL and credential.
            /// *   Obtain the value of VideoId by calling the [SearchMedia](~~86044~~) operation. This method is applicable to files that have been uploaded.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The number of entries to return on each page. Maximum value: **50**. Default value: **10**.
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            [NameInMap("TranscodeTaskId")]
            [Validation(Required=false)]
            public string TranscodeTaskId { get; set; }

            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

            /// <summary>
            /// The status of the transcoding task. Valid values:
            /// 
            /// *   **Processing**: In progress.
            /// *   **Partial**: Some transcoding jobs were complete.
            /// *   **CompleteAllSucc**: All transcoding jobs were successful.
            /// *   **CompleteAllFail**: All transcoding jobs failed. If an exception occurs in the source file, no transcoding job is initiated and the transcoding task fails.
            /// *   **CompletePartialSucc**: All transcoding jobs were complete but only some were successful.
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
