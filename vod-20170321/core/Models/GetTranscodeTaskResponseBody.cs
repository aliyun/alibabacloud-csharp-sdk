// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTranscodeTaskResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details about transcoding tasks.
        /// </summary>
        [NameInMap("TranscodeTask")]
        [Validation(Required=false)]
        public GetTranscodeTaskResponseBodyTranscodeTask TranscodeTask { get; set; }
        public class GetTranscodeTaskResponseBodyTranscodeTask : TeaModel {
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
            /// 
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
            /// Details about transcoding jobs.
            /// </summary>
            [NameInMap("TranscodeJobInfoList")]
            [Validation(Required=false)]
            public List<GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoList> TranscodeJobInfoList { get; set; }
            public class GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoList : TeaModel {
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
                /// The video resolution. Valid values:
                /// 
                /// *   **LD**: low definition
                /// *   **SD**: standard definition
                /// *   **HD**: high definition
                /// *   **FHD**: ultra high definition
                /// *   **OD**: original definition
                /// *   **2K**: 2K
                /// *   **4K**: 4K
                /// *   **SQ**: standard sound quality
                /// *   **HQ**: high sound quality
                /// *   **AUTO**: adaptive bitrate Adaptive bitrate streams are returned only if PackageSetting is set in the transcoding template. For more information, see [Basic structures](https://help.aliyun.com/document_detail/52839.html).
                /// 
                /// > This parameter indicates the definition that is configured in the transcoding template and does not indicate the actual resolution of the output video.
                /// </summary>
                [NameInMap("Definition")]
                [Validation(Required=false)]
                public string Definition { get; set; }

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
                /// The Object Storage Service (OSS) URL of the input file.
                /// </summary>
                [NameInMap("InputFileUrl")]
                [Validation(Required=false)]
                public string InputFileUrl { get; set; }

                /// <summary>
                /// The information about the output file.
                /// </summary>
                [NameInMap("OutputFile")]
                [Validation(Required=false)]
                public GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoListOutputFile OutputFile { get; set; }
                public class GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoListOutputFile : TeaModel {
                    /// <summary>
                    /// The audio streams.
                    /// </summary>
                    [NameInMap("AudioStreamList")]
                    [Validation(Required=false)]
                    public string AudioStreamList { get; set; }

                    /// <summary>
                    /// The average bitrate of the output file. Unit: Kbit/s.
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// The length of the output file. Unit: seconds.
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// The encryption method of the output file. Valid values:
                    /// 
                    /// *   **AliyunVoDEncryption**: Alibaba Cloud proprietary cryptography
                    /// *   **HLSEncryption**: HTTP Live Streaming (HLS) encryption
                    /// </summary>
                    [NameInMap("Encryption")]
                    [Validation(Required=false)]
                    public string Encryption { get; set; }

                    /// <summary>
                    /// The size of the output file. Unit: byte.
                    /// </summary>
                    [NameInMap("Filesize")]
                    [Validation(Required=false)]
                    public long? Filesize { get; set; }

                    /// <summary>
                    /// The container format of the output file.
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// The frame rate of the output file. Unit: frames per second.
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
                    /// The OSS URL of the output file.
                    /// </summary>
                    [NameInMap("OutputFileUrl")]
                    [Validation(Required=false)]
                    public string OutputFileUrl { get; set; }

                    /// <summary>
                    /// The subtitle streams.
                    /// </summary>
                    [NameInMap("SubtitleStreamList")]
                    [Validation(Required=false)]
                    public string SubtitleStreamList { get; set; }

                    /// <summary>
                    /// The video streams.
                    /// </summary>
                    [NameInMap("VideoStreamList")]
                    [Validation(Required=false)]
                    public string VideoStreamList { get; set; }

                    /// <summary>
                    /// The IDs of the watermarks used by the output file.
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
                /// The priority of the transcoding job.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                /// <summary>
                /// The ID of the transcoding job.
                /// </summary>
                [NameInMap("TranscodeJobId")]
                [Validation(Required=false)]
                public string TranscodeJobId { get; set; }

                /// <summary>
                /// The status of the transcoding job.
                /// 
                /// *   **Transcoding**
                /// *   **TranscodeSuccess**
                /// *   **TranscodeFail**
                /// </summary>
                [NameInMap("TranscodeJobStatus")]
                [Validation(Required=false)]
                public string TranscodeJobStatus { get; set; }

                /// <summary>
                /// The progress of the transcoding job. Valid values: `[0,100]`.
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

            }

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
            /// 
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
