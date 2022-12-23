// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTranscodeSummaryResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the audio or video files that do not exist.
        /// </summary>
        [NameInMap("NonExistVideoIds")]
        [Validation(Required=false)]
        public List<string> NonExistVideoIds { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The transcoding summary of the file.
        /// </summary>
        [NameInMap("TranscodeSummaryList")]
        [Validation(Required=false)]
        public List<GetTranscodeSummaryResponseBodyTranscodeSummaryList> TranscodeSummaryList { get; set; }
        public class GetTranscodeSummaryResponseBodyTranscodeSummaryList : TeaModel {
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
            /// The summaries of transcoding jobs.
            /// </summary>
            [NameInMap("TranscodeJobInfoSummaryList")]
            [Validation(Required=false)]
            public List<GetTranscodeSummaryResponseBodyTranscodeSummaryListTranscodeJobInfoSummaryList> TranscodeJobInfoSummaryList { get; set; }
            public class GetTranscodeSummaryResponseBodyTranscodeSummaryListTranscodeJobInfoSummaryList : TeaModel {
                /// <summary>
                /// The average bitrate of the output video. Unit: Kbit/s.
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// The time when the transcoding job was complete. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public string CompleteTime { get; set; }

                /// <summary>
                /// The time when the transcoding job was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The duration of the output video. Unit: seconds.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// The error code returned when the transcoding job failed.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message returned when the transcoding job failed.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The size of the output video. Unit: bytes.
                /// </summary>
                [NameInMap("Filesize")]
                [Validation(Required=false)]
                public long? Filesize { get; set; }

                /// <summary>
                /// The container format of the output video.
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// The frame rate of the output video. Unit: frames per second.
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// The height of the output video. Unit: pixels.
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// The status of the transcoding job. Valid values:
                /// *   **Transcoding**
                /// *   **TranscodeSuccess**
                /// *   **TranscodeFail**
                /// </summary>
                [NameInMap("TranscodeJobStatus")]
                [Validation(Required=false)]
                public string TranscodeJobStatus { get; set; }

                /// <summary>
                /// The transcoding progress. Valid values: `[0,100]`.
                /// </summary>
                [NameInMap("TranscodeProgress")]
                [Validation(Required=false)]
                public long? TranscodeProgress { get; set; }

                /// <summary>
                /// The ID of the transcoding template.
                /// </summary>
                [NameInMap("TranscodeTemplateId")]
                [Validation(Required=false)]
                public string TranscodeTemplateId { get; set; }

                /// <summary>
                /// The IDs of the watermarks that are applied to the output video.
                /// </summary>
                [NameInMap("WatermarkIdList")]
                [Validation(Required=false)]
                public List<string> WatermarkIdList { get; set; }

                /// <summary>
                /// The width of the output video. Unit: pixels.
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

            /// <summary>
            /// The status of the transcoding task. Valid values:
            /// *   **Processing**: In progress.
            /// *   **Partial**: Some transcoding jobs were complete.
            /// *   **CompleteAllSucc**: All transcoding jobs were successful.
            /// *   **CompleteAllFail**: All transcoding jobs failed. If an exception occurs in the source file, no transcoding job is initiated and the transcoding task fails.
            /// *   **CompletePartialSucc**: All transcoding jobs were complete but only some were successful.
            /// </summary>
            [NameInMap("TranscodeStatus")]
            [Validation(Required=false)]
            public string TranscodeStatus { get; set; }

            /// <summary>
            /// The ID of the transcoding template group.
            /// </summary>
            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

            /// <summary>
            /// The ID of the audio or video file.
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
