// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTranscodeTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TranscodeTask")]
        [Validation(Required=false)]
        public GetTranscodeTaskResponseBodyTranscodeTask TranscodeTask { get; set; }
        public class GetTranscodeTaskResponseBodyTranscodeTask : TeaModel {
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            [NameInMap("TranscodeJobInfoList")]
            [Validation(Required=false)]
            public List<GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoList> TranscodeJobInfoList { get; set; }
            public class GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoList : TeaModel {
                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public string CompleteTime { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Definition")]
                [Validation(Required=false)]
                public string Definition { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("InputFileUrl")]
                [Validation(Required=false)]
                public string InputFileUrl { get; set; }

                [NameInMap("OutputFile")]
                [Validation(Required=false)]
                public GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoListOutputFile OutputFile { get; set; }
                public class GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoListOutputFile : TeaModel {
                    [NameInMap("AudioStreamList")]
                    [Validation(Required=false)]
                    public string AudioStreamList { get; set; }

                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    [NameInMap("Encryption")]
                    [Validation(Required=false)]
                    public string Encryption { get; set; }

                    [NameInMap("Filesize")]
                    [Validation(Required=false)]
                    public long? Filesize { get; set; }

                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    [NameInMap("OutputFileUrl")]
                    [Validation(Required=false)]
                    public string OutputFileUrl { get; set; }

                    [NameInMap("SubtitleStreamList")]
                    [Validation(Required=false)]
                    public string SubtitleStreamList { get; set; }

                    [NameInMap("VideoStreamList")]
                    [Validation(Required=false)]
                    public string VideoStreamList { get; set; }

                    [NameInMap("WatermarkIdList")]
                    [Validation(Required=false)]
                    public List<string> WatermarkIdList { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                [NameInMap("TranscodeJobId")]
                [Validation(Required=false)]
                public string TranscodeJobId { get; set; }

                [NameInMap("TranscodeJobStatus")]
                [Validation(Required=false)]
                public string TranscodeJobStatus { get; set; }

                [NameInMap("TranscodeProgress")]
                [Validation(Required=false)]
                public long? TranscodeProgress { get; set; }

                [NameInMap("TranscodeTemplateId")]
                [Validation(Required=false)]
                public string TranscodeTemplateId { get; set; }

            }

            [NameInMap("TranscodeTaskId")]
            [Validation(Required=false)]
            public string TranscodeTaskId { get; set; }

            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
