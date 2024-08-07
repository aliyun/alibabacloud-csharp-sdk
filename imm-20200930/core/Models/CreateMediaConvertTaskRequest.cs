// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateMediaConvertTaskRequest : TeaModel {
        [NameInMap("AlignmentIndex")]
        [Validation(Required=false)]
        public int? AlignmentIndex { get; set; }

        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// 消息通知配置，支持使用MNS、RocketMQ接收异步消息通知。
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<CreateMediaConvertTaskRequestSources> Sources { get; set; }
        public class CreateMediaConvertTaskRequestSources : TeaModel {
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public double? StartTime { get; set; }

            [NameInMap("Subtitles")]
            [Validation(Required=false)]
            public List<CreateMediaConvertTaskRequestSourcesSubtitles> Subtitles { get; set; }
            public class CreateMediaConvertTaskRequestSourcesSubtitles : TeaModel {
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                [NameInMap("TimeOffset")]
                [Validation(Required=false)]
                public double? TimeOffset { get; set; }

                [NameInMap("URI")]
                [Validation(Required=false)]
                public string URI { get; set; }

            }

            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<CreateMediaConvertTaskRequestTargets> Targets { get; set; }
        public class CreateMediaConvertTaskRequestTargets : TeaModel {
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public TargetAudio Audio { get; set; }

            [NameInMap("Container")]
            [Validation(Required=false)]
            public string Container { get; set; }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public TargetImage Image { get; set; }

            [NameInMap("Segment")]
            [Validation(Required=false)]
            public CreateMediaConvertTaskRequestTargetsSegment Segment { get; set; }
            public class CreateMediaConvertTaskRequestTargetsSegment : TeaModel {
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                [NameInMap("StartNumber")]
                [Validation(Required=false)]
                public int? StartNumber { get; set; }

            }

            [NameInMap("Speed")]
            [Validation(Required=false)]
            public float? Speed { get; set; }

            [NameInMap("StripMetadata")]
            [Validation(Required=false)]
            public bool? StripMetadata { get; set; }

            [NameInMap("Subtitle")]
            [Validation(Required=false)]
            public TargetSubtitle Subtitle { get; set; }

            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            [NameInMap("Video")]
            [Validation(Required=false)]
            public TargetVideo Video { get; set; }

        }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
